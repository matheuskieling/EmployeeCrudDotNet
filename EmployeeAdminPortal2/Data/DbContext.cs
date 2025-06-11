using EmployeeAdminPortal2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Employee> Employees { get; set; }
}