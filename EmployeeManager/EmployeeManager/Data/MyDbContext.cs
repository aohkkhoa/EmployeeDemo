using EmployeeManager.models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}