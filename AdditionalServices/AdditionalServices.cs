namespace LuftbornCodeTest;

public static class AdditionalServices
{
    public static void RegisteredServices(this WebApplicationBuilder builder)
    {
        builder.RegisterDatabaseService();
        builder.RegisterRepositories();
    }
    public static void RegisterDatabaseService(this WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<ApplicationDbContext>(c =>
                       c.UseSqlServer(connectionString)
                        .EnableDetailedErrors()
                        .EnableSensitiveDataLogging()
                        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
    }

    public static void RegisterRepositories(this WebApplicationBuilder builder)
    {
             builder.Services.AddTransient<ITodoListTaskRepository, TodoListTaskRepository>();
    }
}
