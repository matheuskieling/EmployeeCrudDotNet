using System.ComponentModel.DataAnnotations;

namespace EmployeeAdminPortal2.Models;

public record UpdateEmployeeDto(
    string? Name,
    [EmailAddress]
    string? Email,
    string? LastName,
    string? Phone,
    [Range(0, double.MaxValue)]
    decimal? Salary)
{
}