namespace LuftbornCodeTest;

public interface ITodoListTaskRepository : IBaseRepository<TodoListTask>
{
    Task<IEnumerable<TodoListTask>> GetInProgresTasks();
    Task<IEnumerable<TodoListTask>> GetFinishedTasks();
    Task<TodoListTask> UpdatePartially(int id, TodoListTaskDtos todoListTaskDtos); 
}