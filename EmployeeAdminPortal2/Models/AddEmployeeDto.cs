using System.ComponentModel.DataAnnotations;

namespace EmployeeAdminPortal2.Models;

public record AddEmployeeDto(
    [Required]
    string Name,
    [Required, EmailAddress]
    string Email,
    [Required]
    string LastName,
    string? Phone,
    [Range(0, double.MaxValue)]
    decimal Salary)
{
}