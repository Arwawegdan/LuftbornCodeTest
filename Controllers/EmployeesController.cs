using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace LuftbornCodeTest;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController(IEmployeeRepository _employeeRepository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
    {
        IEnumerable<Employee> employees = await _employeeRepository.Get();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetEmployee(int id)
    {
        var employee = await _employeeRepository.Get();

        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEmployee(int id, Employee employee)
    {
        if (id != employee.Id)
            return BadRequest();
   
        await _employeeRepository.Update(employee);

        return NoContent();
    }


    [HttpPost]
    public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
    {
        await _employeeRepository.Add(employee);

        return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        await _employeeRepository.Remove(id);

        return NoContent();
    }
}