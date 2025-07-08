using demoproject.Models;
using Microsoft.EntityFrameworkCore;

namespace demoproject.DeptDbContext
{
    public class DepartmentDbcontext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees{ get;set; }
        public DepartmentDbcontext(DbContextOptions<DepartmentDbcontext> options) : base(options) { }
    }
}
