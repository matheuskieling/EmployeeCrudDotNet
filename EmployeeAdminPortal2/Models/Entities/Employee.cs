using System.ComponentModel.DataAnnotations;

namespace EmployeeAdminPortal2.Models.Entities;

public class Employee
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; } = null!;
    public required string Email { get; set; } = null!;
    public required string LastName { get; set; } = null!;
    public string? Phone { get; set; }
    public decimal Salary { get; set; } 
}