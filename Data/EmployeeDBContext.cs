using Complaint.Models;
using Microsoft.EntityFrameworkCore;

namespace Complaint.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }


    }
   
}
