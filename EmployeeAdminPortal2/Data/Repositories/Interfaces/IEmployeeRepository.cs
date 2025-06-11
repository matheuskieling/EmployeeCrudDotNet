using EmployeeAdminPortal2.Models;
using EmployeeAdminPortal2.Models.Entities;

namespace EmployeeAdminPortal2.Data.Repositories.Interfaces;

public interface IEmployeeRepository
{
    Employee? GetEmployeeById(Guid id);
    List<Employee> GetAllEmployees();
    Employee AddEmployee(AddEmployeeDto dto);
    Employee? UpdateEmployee(Guid id, UpdateEmployeeDto dto);
    Guid? DeleteEmployee(Guid id);
}