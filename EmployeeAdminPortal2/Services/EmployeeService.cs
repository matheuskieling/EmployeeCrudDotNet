using EmployeeAdminPortal2.Data.Repositories.Interfaces;
using EmployeeAdminPortal2.Models;
using EmployeeAdminPortal2.Models.Entities;
using EmployeeAdminPortal2.Services.Interfaces;

namespace EmployeeAdminPortal2.Services;

public class EmployeeService(IEmployeeRepository repository) : IEmployeeService
{
    public Employee? GetEmployeeById(Guid id)
    {
        return repository.GetEmployeeById(id);
    }

    public List<Employee> GetAllEmployees()
    {
        return repository.GetAllEmployees();
    }

    public Employee AddEmployee(AddEmployeeDto dto)
    {
        return repository.AddEmployee(dto);
    }

    public Employee? UpdateEmployee(Guid id, UpdateEmployeeDto dto)
    {
        return repository.UpdateEmployee(id, dto);
    }

    public Guid? DeleteEmployee(Guid id)
    {
        return repository.DeleteEmployee(id);
    }
}