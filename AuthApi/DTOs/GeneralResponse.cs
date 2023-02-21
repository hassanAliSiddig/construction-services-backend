namespace AuthApi.DTOs
{
    public record GeneralResponse(string message, bool isSuccessful, object? data = null, string? error = null);
}
