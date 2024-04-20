var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.RegisteredServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

ApplicationDbContext applicationDbContext = app.Services.CreateScope()
                                               .ServiceProvider.GetRequiredService<ApplicationDbContext>();
applicationDbContext.Database.Migrate();

app.Run();