using ConstructionApi.DTOs;
using ConstructionApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ConstructionApi.Services
{
    public class ConstructionService
    {
        private readonly ConstructionDbContext constructionDbContext;
        private readonly IHttpContextAccessor httpContextAccessor;


        public ConstructionService(ConstructionDbContext constructionDbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.constructionDbContext = constructionDbContext;
            this.httpContextAccessor = httpContextAccessor;
        }
        public List<Client> GetClients()
        {
            return constructionDbContext.Clients.ToList();
        }

        public Client? GetClientByUserId(long userId)
        {
            return constructionDbContext.Clients.FirstOrDefault(c => c.UserID == userId);
        }

        internal IEnumerable<GetConstructionRequestsResponse> GetConstructionRequests()
        {
            var username = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            
            var userRole = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);

            try
            {
                return constructionDbContext.ConstructionRequests
                .Where(r => userRole == "Admin" || r.AddedBy == username)
                .Select(r =>
                new GetConstructionRequestsResponse
                (
                    r.ConstructionRequestID,
                    r.Description,
                    r.Remarks,
                    r.StartDate.HasValue ? r.StartDate.Value.ToString("d") : null,
                    r.EstimatedEndDate.HasValue ? r.EstimatedEndDate.Value.ToString("d") : null,
                    r.Payment != null ? r.Payment.Amount : null,
                    r.Client.Name,
                    r.Project.Name,
                    r.Status.Name,
                    r.Company.Name,
                    r.AddedOn.ToString("d"),
                    r.AddedBy
                )).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        internal async Task<GeneralResponse?> CreateConstructionRequestAsync(CreateConstructionRequestDto request)
        {

            var username = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            var userId = long.Parse(httpContextAccessor.HttpContext.User.FindFirstValue("userId"));


            await constructionDbContext.ConstructionRequests.AddAsync(
                new ConstructionRequest
                {
                    Description = request.Description,
                    Remarks = request.Remarks,
                    ClientID = userId,
                    ProjectID = request.ProjectID,
                    StatusID = 1,
                    CompanyID = request.CompanyID,
                    AddedBy = username
                });

            await constructionDbContext.SaveChangesAsync();

            return new GeneralResponse("Reqeust Created Successfully",true);
        }

        internal async Task<object?> UpdateConstructionRequestAsync(UpdateConstructionRequestDto requet)
        {

            var constructionRequest = constructionDbContext
                                        .ConstructionRequests
                                        .FirstOrDefault(c => c.ConstructionRequestID == requet.ConstructionRequestID);

            var payment = new Payment
            {
                Amount = requet.PaymentAmount,
                OrderID = Guid.NewGuid().ToString(),
                Status = PaymentStatus.Pending,
            };

            var savedPayment = constructionDbContext.Payments.Add(payment);

            await constructionDbContext.SaveChangesAsync();

            constructionRequest.StartDate = requet.StartDate;

            constructionRequest.EstimatedEndDate = requet.EstimatedEndDate;

            constructionRequest.PaymentID = savedPayment.Entity.PaymentID;

            constructionRequest.StatusID = 2;

            constructionDbContext.ConstructionRequests.Update(constructionRequest);

            await constructionDbContext.SaveChangesAsync();

            return new GeneralResponse("Request updated successfully", true);
        }

        internal async Task<object?> MakePaymentAsync(long constructionRequestId)
        {

            var constructionRequest = constructionDbContext
                                        .ConstructionRequests
                                        .Include(c => c.Payment)
                                        .FirstOrDefault(c => c.ConstructionRequestID == constructionRequestId);

           using(var transaction = await constructionDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var pendingPaymentStatusId = 3;

                    var payment = constructionRequest.Payment;

                    payment.Status = PaymentStatus.succeeded;

                    payment.ChangedOn = DateTime.UtcNow;

                    payment.AuthCode = 658412;

                    constructionRequest.StatusID = pendingPaymentStatusId;

                    constructionDbContext.Payments.Update(payment);
                    constructionDbContext.ConstructionRequests.Update(constructionRequest);


                    await constructionDbContext.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return new GeneralResponse("Payment succeded", true);

                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }

        }

        internal async Task<IEnumerable<ConstructionRequestStatus>> GetConstructionRequestStatusListAsync()
        {
            return await constructionDbContext.ConstructionRequestStatuses.ToArrayAsync();
        }

        internal async Task<IEnumerable<Company>> GetConstructionCompaniesListAsync()
        {
            return await constructionDbContext.Companies.ToArrayAsync();
        }

        internal async Task<IEnumerable<Project>> GetConstructionProjectsListAsync()
        {
            return await constructionDbContext.projects.ToArrayAsync();
        }
    }
}
