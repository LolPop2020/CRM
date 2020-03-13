using CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
