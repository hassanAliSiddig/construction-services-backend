namespace ConstructionApi.DTOs
{
    public record UpdateConstructionRequestDto
    (
        long ConstructionRequestID,
        DateTime? StartDate,
        DateTime? EstimatedEndDate,
        double PaymentAmount
    );
}
