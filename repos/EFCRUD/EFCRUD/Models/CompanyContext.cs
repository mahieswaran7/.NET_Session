using Microsoft.EntityFrameworkCore;

namespace EFCRUD.Models
{
    public class CompanyContext :DbContext
    {
        public  CompanyContext(DbContextOptions<CompanyContext>options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(p => p.Employee)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_emp_dept");
            });
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }
}
