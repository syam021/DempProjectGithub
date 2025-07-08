using demoproject.Models;

namespace demoproject.DataAccess.IRepostiory
{
    public interface IEmployeeRep
    {
        public Task<List<Employee>> GetAllEmployee();
        public Task<Employee> GetEmpID(int EmpID);
        public Task<int> intsertEmployee(Employee employee);
        public Task<int> updateEmployee(Employee employee);
        public Task<int> deleteEmployee(int EmpId);


    }
}
