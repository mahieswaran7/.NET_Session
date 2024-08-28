using Microsoft.EntityFrameworkCore;

namespace FileUploadInMVC.Models
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configuring the Connection String
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-6P5NK25R\SQLSERVER2022DEV;Database=FileHandlingDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //Adding Domain Classes as DbSet Properties
        public DbSet<FileModel> Files { get; set; }
    }
}