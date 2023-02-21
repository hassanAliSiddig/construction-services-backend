namespace ConstructionApi.DTOs
{
    public record CreateConstructionRequestDto
    (
        string Description,
        string Remarks,
        long ProjectID,
        long CompanyID
    );
}
