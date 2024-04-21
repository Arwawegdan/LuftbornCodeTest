using Domains;

namespace LuftbornCodeTest;

public class TodoListTaskRepository : BaseRepository<TodoListTask>, ITodoListTaskRepository
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<TodoListTask> _dbSet;
    public TodoListTaskRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
        _dbSet = context.Set<TodoListTask>();
    }

    public async Task<IEnumerable<TodoListTask>> GetFinishedTasks()
    {
        return await _dbSet.Where(e => e.Status.Equals(Status.Finished)).ToListAsync();
    }
    public async Task<IEnumerable<TodoListTask>> GetInProgresTasks()
    {
        return await _dbSet.Where(e => e.Status.Equals(Status.Inprogress)).ToListAsync();
    }

    public async Task<TodoListTask> UpdatePartially(int id, TodoListTaskDtos todoListTaskDtos)
    {
        if (todoListTaskDtos == null || id != todoListTaskDtos.Id)
            throw new ArgumentException("Invalid todoListTask or ID mismatch");

        var existingTask = await _dbSet.FindAsync(id);

        if (existingTask == null)
            throw new ArgumentException($"TodoListTask with ID {id} not found");

        if (todoListTaskDtos.Status != null) existingTask.Status = todoListTaskDtos.Status.Value;
        if (todoListTaskDtos.Discription != null) existingTask.Discription = todoListTaskDtos.Discription;
        if (todoListTaskDtos.Deadline != null) existingTask.Deadline = todoListTaskDtos.Deadline.Value;

        existingTask.ModificationDate = DateTime.Now; 
        await Task.Run(() => _dbSet.Update(existingTask));
        await _context.SaveChangesAsync();

        return existingTask; 
    }
}