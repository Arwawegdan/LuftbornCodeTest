namespace LuftbornCodeTest;

public class TodoListTaskConfiguration : IEntityTypeConfiguration<TodoListTask>
{
    public void Configure(EntityTypeBuilder<TodoListTask> builder)
    {
        builder.ToTable("ToDoListTasks");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Discription)
               .IsRequired();

        builder.Property(e => e.Deadline)
               .IsRequired();
    }
}

