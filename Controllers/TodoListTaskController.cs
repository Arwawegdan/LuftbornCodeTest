using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace LuftbornCodeTest;

[Route("api/[controller]")]
[ApiController]
public class TodoListTaskController(ITodoListTaskRepository _todoListTaskRepository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoListTask>>> GetEmployee()
    {
        IEnumerable<TodoListTask> tasks = await _todoListTaskRepository.Get();
        return Ok(tasks);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TodoListTask>> GetEmployee(int id)
    {
        var TodoListTask = await _todoListTaskRepository.Get();

        if (TodoListTask == null)
        {
            return NotFound();
        }

        return Ok(TodoListTask);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEmployee(int id, TodoListTask TodoListTask)
    {
        if (id != TodoListTask.Id)
            return BadRequest();
   
        await _todoListTaskRepository.Update(TodoListTask);

        return NoContent();
    }


    [HttpPost]
    public async Task<ActionResult<TodoListTask>> PostTask(TodoListTask TodoListTask)
    {
        await _todoListTaskRepository.Add(TodoListTask);

        return CreatedAtAction("GetEmployee", new { id = TodoListTask.Id }, TodoListTask);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTask(int id)
    {
        await _todoListTaskRepository.Remove(id);

        return NoContent();
    }
}