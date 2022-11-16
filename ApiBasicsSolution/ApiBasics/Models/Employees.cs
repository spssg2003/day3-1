namespace ApiBasics.Models;

public record EmployeeDetailsResponse
{
    public int Id { get; init; }
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = string.Empty;
    public string EmailAddress { get; init; } = string.Empty;
}


public record EmployeeCreateRequest
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Department { get; init; }
}
