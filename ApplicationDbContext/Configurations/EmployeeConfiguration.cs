namespace LuftbornCodeTest;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    private const int MaxLength = 255;

    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Name);
        
        builder.Property(e => e.Name)
               .IsRequired()
               .HasMaxLength(MaxLength);

    }
}

