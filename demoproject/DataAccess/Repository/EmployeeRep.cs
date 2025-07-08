using demoproject.DataAccess.IRepostiory;
using demoproject.DeptDbContext;
using demoproject.Models;
using Microsoft.EntityFrameworkCore;

namespace demoproject.DataAccess.Repository
{
    public class EmployeeRep : IEmployeeRep

    {
        public DepartmentDbcontext AAA;
        public EmployeeRep(DepartmentDbcontext _AAA)
        {
            AAA = _AAA;
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
           return await  AAA.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmpID(int EmpID)
        {
            return await AAA.Employees.FindAsync(EmpID);
        }

        public async Task<int> intsertEmployee(Employee employee)
        {
            await AAA.Employees.AddAsync(employee);
           return await AAA.SaveChangesAsync();
        }

        
        async Task<int> IEmployeeRep.deleteEmployee(int EmpId)
        {
            var sravs = AAA.Employees.Find(EmpId);
            AAA.Employees.Remove(sravs);
          return await AAA.SaveChangesAsync();
        }

        async Task<int> IEmployeeRep.updateEmployee(Employee employee)
        {
            AAA.Update(employee);
          return await AAA.SaveChangesAsync();
        }
    }
}
