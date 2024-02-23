using Microsoft.EntityFrameworkCore;
using web.app.Model;
namespace DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=EmployeeBase;Username=postgres;Password=postqwerty");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(builder =>
            //{
            //    builder.ToTable("Employees");

            //    builder.Property(employee => employee.Id)
            //    .HasColumnName("Id")
            //    .UseSerialColumn()
            //    .UseIdentityColumn()
            //    .UseSequence();
            //});
        }
    }
}
