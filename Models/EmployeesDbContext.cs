using Microsoft.EntityFrameworkCore;

namespace AzureDeployment.Models
{
    public class EmployeesDbContext:DbContext
    {
        public EmployeesDbContext(DbContextOptions options):base(options) 
        { 
            
        } 

        public DbSet<Employee> Employees { get; set;}
    }
}
