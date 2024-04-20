namespace LuftbornCodeTest;

public class TodoListTaskRepository : BaseRepository<TodoListTask>, ITodoListTaskRepository
{
    public TodoListTaskRepository(ApplicationDbContext context) : base(context) { }
}