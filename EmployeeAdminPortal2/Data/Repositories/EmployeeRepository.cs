using EmployeeAdminPortal2.Data.Repositories.Interfaces;
using EmployeeAdminPortal2.Models;
using EmployeeAdminPortal2.Models.Entities;

namespace EmployeeAdminPortal2.Data.Repositories;

public class EmployeeRepository(AppDbContext dbContext) : IEmployeeRepository
{
    public Employee? GetEmployeeById(Guid id)
    {
        return dbContext.Employees.Find(id);
    }

    public List<Employee> GetAllEmployees()
    {
        return dbContext.Employees.ToList();
    }

    public Employee AddEmployee(AddEmployeeDto dto)
    {
        var employee = new Employee()
        {
            Name = dto.Name,
            LastName = dto.LastName,
            Email = dto.Email,
            Phone = dto.Phone,
            Salary = dto.Salary
        };
        var result = dbContext.Employees.Add(employee);
        dbContext.SaveChanges();
        return employee;
    }

    public Employee? UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
    {
        var employee = dbContext.Employees.Find(id);
        if (employee is null) return null;
        employee.Name = updateEmployeeDto.Name ?? employee.Name;
        employee.Email = updateEmployeeDto.Email ?? employee.Email;
        employee.LastName = updateEmployeeDto.LastName ?? employee.LastName;
        employee.Phone = updateEmployeeDto.Phone ?? employee.Phone;
        employee.Salary = updateEmployeeDto.Salary ?? employee.Salary;
        
        dbContext.Employees.Update(employee);
        dbContext.SaveChanges();
        return employee;
    }

    public Guid? DeleteEmployee(Guid id)
    {
        var employee = dbContext.Employees.Find(id);
        if (employee is null) return null;
        dbContext.Employees.Remove(employee);
        dbContext.SaveChanges();
        return id;
    }
}