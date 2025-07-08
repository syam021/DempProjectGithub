using demoproject.DataAccess.IRepostiory;
using demoproject.DeptDbContext;
using demoproject.Models;
using Microsoft.EntityFrameworkCore;

namespace demoproject.DataAccess.Repository
{
    public class DepartmentRep : IDepartmentRep

    {
        public DepartmentDbcontext BBB;
       public DepartmentRep(DepartmentDbcontext _BBB)
        {
            BBB = _BBB;
        }

        public async Task<int> deleteDept(int DeptID)
        {
            var sam = BBB.Departments.Find(DeptID);
            BBB.Departments.Remove(sam);
           return await BBB.SaveChangesAsync();
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            return await BBB.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartmentById(int DeptID)
        {
            return await BBB.Departments.FindAsync(DeptID);
        }

        public async Task<int> insertDept(Department department)
        {
            await BBB.Departments.AddAsync(department);
            return await BBB.SaveChangesAsync();
        }

        public async Task<int> updateDept(Department department)
        {
            BBB.Departments.Update(department);
            return await BBB.SaveChangesAsync();
        }
    }
}
