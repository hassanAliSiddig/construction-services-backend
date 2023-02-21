using ConstructionApi.Models;

namespace ConstructionApi.DTOs
{
    public record GetConstructionRequestsResponse
        (
            long ConstructionRequestID,
            string Description,
            string Remarks,
            string? StartDate,
            string? EstimatedEndDate,
            double? PaymentAmount,
            string Client,
            string Project,
            string Status,
            string Company,
            string AddedOn,
            string AddedBy
        );
}
