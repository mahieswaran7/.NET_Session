using Microsoft.EntityFrameworkCore;

namespace EFCoreTask.Models
{
    public class ChangepondContext:DbContext
    {
        public ChangepondContext(DbContextOptions<ChangepondContext> options) : base(options) { }

        
        public DbSet<Employee> Employees { get; set; }
    }
}
