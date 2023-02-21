using AuthApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly AuthDbContext authDbContext;
        private readonly ILogger<AuthController> logger;
        private readonly IConfiguration _configuration;

        public record GetAccessTokenRequest(string Username, string Password);

        public AuthController(
            AuthDbContext authDbContext, 
            ILogger<AuthController> logger,
            IConfiguration configuration)
        {
            this.authDbContext = authDbContext;
            this.logger = logger;
            this._configuration = configuration;
        }

        public record SetAdminUserRequest(string username, string password, string adminSetterKey);
        [Authorize(Roles = "AdminSetter")]
        [HttpPost("set-admin-user")]
        public IActionResult SetAdminUser(SetAdminUserRequest request)
        {
            if (authDbContext.AuthUsers.Any(u => u.Role == AuthRoles.Admin))
            {
                return BadRequest(new { message = "the admin already exists", isSuccess = false, error = "ADMIN_ALREADY_EXISTS" });

            }

            if (_configuration["AdminSetterKey"].Equals(request.adminSetterKey, StringComparison.Ordinal) == false)
            {
                return BadRequest(new { message = "the admin setter key is invalid", isSuccess = false, error = "INVALID_ADMIN_SETTER_KEY" });
            }

            authDbContext.AuthUsers.Add(new AuthUser { 
                Username = request.username,
                Password = request.password,
                Role = AuthRoles.Admin,
                AddedBy = "AdminSetter",
                AddedOn = DateTime.UtcNow,
                ChangedBy = "AdminSetter",
                ChangedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active
            });


            authDbContext.SaveChanges();

            return Ok(new {message = "Admin added successfully", isSuccess = true});
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Append("refresh-jwt", "", new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(-1),
                Secure = true,
                HttpOnly = true,
                Domain = "",
                Path = "api/auth",
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.None
            });

            return Ok(new { Logout = true, message = "logged out successfully" });
        }

        [HttpPost("get-access-token")]
        public IActionResult GetAccessToken([FromBody] GetAccessTokenRequest request)
        {
            logger.LogInformation("Login Attempt: ", request.Username);
            var user = authDbContext.AuthUsers.FirstOrDefault(u => u.Username == request.Username && u.Password == request.Password);

            if (user != null)
            {

                var authClaims = new List<Claim>
                {
                    new Claim("userId",user.AuthUserID.ToString()),
                    new Claim(ClaimTypes.Name, request.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var refreshToken = GetToken(authClaims, _configuration.GetValue<double>("AuthCookieOptions:refreshCookieMaxAge"));

                authClaims.Add(new Claim(ClaimTypes.Role, user.Role.ToString()));

                var accessToken = GetToken(authClaims);

                logger.LogInformation("Successfull Login: ", request.Username);

                var authCookieBuilder = new CookieBuilder();

                authCookieBuilder.Name = "refresh-jwt";
                authCookieBuilder.HttpOnly = true;
                authCookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                authCookieBuilder.Path = "auth/";
                authCookieBuilder.Domain = "";
                authCookieBuilder.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.None;
                authCookieBuilder.MaxAge = TimeSpan.FromMinutes(_configuration.GetValue<double>("AuthCookieOptions:refreshCookieMaxAge"));

                Response.Cookies.Append(
                    "refresh-jwt",
                    new JwtSecurityTokenHandler().WriteToken(refreshToken),
                    authCookieBuilder.Build(HttpContext)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(accessToken),
                    expiration = accessToken.ValidTo
                });
            }

            logger.LogInformation("Failed Login: ", request.Username);

            return Unauthorized();
        }

        [HttpGet("refresh-access-token")]
        public IActionResult RefreshAccessToken()
        {
            var refreshJwt = Request.Cookies.FirstOrDefault(c => c.Key == "refresh-jwt");

            if (string.IsNullOrEmpty(refreshJwt.Value))
            {
                return Unauthorized(new { message = "refresh token is missing" });
            }

            var tokenHandler = new JwtSecurityTokenHandler();

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var tokenParams = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = authSigningKey,
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
            };

            try
            {
                tokenHandler.ValidateToken(refreshJwt.Value, tokenParams, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;

                var userName = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;


                if (string.IsNullOrEmpty(userName))
                {
                    return Unauthorized(new { message = "The refresh Token Does Not Have The Name Claim" });
                }


                var user = authDbContext.AuthUsers.FirstOrDefault(u => u.Username == userName);

                if (user is null)
                {
                    return Unauthorized(new { message = "Invalid User" });
                }

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim("userId",user.AuthUserID.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                authClaims.Add(new Claim(ClaimTypes.Role, user.Role.ToString()));

                var accessToken = GetToken(authClaims);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(accessToken),
                    expiration = accessToken.ValidTo
                });

            }
            catch (Exception ex)
            {

                return Unauthorized(new { message = "Invalid Refresh Token" });
            }

            return Ok(refreshJwt);
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims, double? tokenExpiryInMinutes = null)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: tokenExpiryInMinutes is null
                ? DateTime.Now.AddMinutes(_configuration.GetValue<double>("JWT:DefaultTokenAge"))
                : DateTime.Now.AddMinutes((double)tokenExpiryInMinutes),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}
