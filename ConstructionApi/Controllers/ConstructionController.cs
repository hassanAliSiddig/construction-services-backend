using ConstructionApi.DTOs;
using ConstructionApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ConstructionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ConstructionController : ControllerBase
    {
        private readonly ConstructionService constructionService;

        public ConstructionController(ConstructionService constructionService)
        {
            this.constructionService = constructionService;
        }

        [HttpGet("get-construction-requests")]
        public IActionResult GetConstructionRequests()
            => Ok(constructionService.GetConstructionRequests());


        [Authorize(Roles = "Admin")]
        [HttpGet("get-clients")]
        public IActionResult GetClients()
            => Ok(constructionService.GetClients());

        [HttpGet("get-client-by-user-id")]
        public IActionResult GetClientByUserId([FromQuery] long userId)
            => Ok(constructionService.GetClientByUserId(userId));

        [Authorize(Roles = "Client")]
        [HttpPost("submit-construction-request")]
        public async Task<IActionResult> CreateConstructionRequestAsync(CreateConstructionRequestDto request)
            => Ok(await constructionService.CreateConstructionRequestAsync(request));


        [Authorize(Roles = "Admin")]
        [HttpPost("update-construction-request")]
        public async Task<IActionResult> UpdateConstructionRequestAsync(UpdateConstructionRequestDto requet)
            => Ok(await constructionService.UpdateConstructionRequestAsync(requet));

        [HttpPost("make-payment/{constructionRequestId:long}")]
        public async Task<IActionResult> MakePaymentAsync([FromRoute] long constructionRequestId)
            => Ok(await constructionService.MakePaymentAsync(constructionRequestId));

        [HttpGet("get-construction-request-status-list")]
        public async Task<IActionResult> GetConstructionRequestStatusListAsync()
            => Ok(await constructionService.GetConstructionRequestStatusListAsync());

        [HttpGet("get-construction-companies-list")]
        public async Task<IActionResult> GetConstructionCompaniesListAsync()
            => Ok(await constructionService.GetConstructionCompaniesListAsync());

        [HttpGet("get-construction-projects-list")]
        public async Task<IActionResult> GetConstructionProjectsListAsync()
            => Ok(await constructionService.GetConstructionProjectsListAsync());
    }
}
