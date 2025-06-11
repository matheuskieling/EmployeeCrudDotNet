using EmployeeAdminPortal2.Models;
using EmployeeAdminPortal2.Models.Entities;

namespace EmployeeAdminPortal2.Services.Interfaces;

public interface IEmployeeService
{
    Employee? GetEmployeeById(Guid id);
    List<Employee> GetAllEmployees();
    Employee AddEmployee(AddEmployeeDto dto);
    Employee? UpdateEmployee(Guid id, UpdateEmployeeDto dto);
    Guid? DeleteEmployee(Guid id);
}