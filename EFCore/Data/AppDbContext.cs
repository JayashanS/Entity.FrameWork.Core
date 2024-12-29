using EFCore.Models;
using Microsoft.EntityFrameworkCore;
namespace EFCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<EmployeeDetails> EmployeesDetails { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeesProjects { get; set; }

        public string ConnectionString { get; }
        public AppDbContext()
        {
            ConnectionString = "Server=CL-HIMANTHAJ;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;TrustServerCertificate=True;";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeProject>().HasKey(ep => new { ep.EmployeeId, ep.ProjectId });
            modelBuilder.Entity<EmployeeProject>().HasOne(ep => ep.Employee).WithMany(e => e.EmployeeProjects).HasForeignKey(ep => ep.EmployeeId);
            modelBuilder.Entity<EmployeeProject>().HasOne(ep => ep.Project).WithMany(p => p.EmployeeProjects).HasForeignKey(ep => ep.ProjectId);
        }

    }
}
