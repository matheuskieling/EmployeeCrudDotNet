using EmployeeAdminPortal2.Models;
using EmployeeAdminPortal2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController(IEmployeeService service) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        var employees = service.GetAllEmployees();
        return Ok(employees);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetEmployeeById(Guid id)
    {
        var employee = service.GetEmployeeById(id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
    }

    [HttpPost]
    public IActionResult AddEmployee(AddEmployeeDto dto)
    {
        var employee = service.AddEmployee(dto);
        return CreatedAtAction(nameof(GetAllEmployees), new { id = employee.Id }, employee);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
    {
        var employee = service.UpdateEmployee(id, updateEmployeeDto);
        return Ok(employee);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEmployee(Guid id)
    {
        var deletedId = service.DeleteEmployee(id);
        if (deletedId is null)
        {
            return NotFound();
        }
        return NoContent();
    }
}