using demoproject.Models;

namespace demoproject.DataAccess.IRepostiory
{
    public interface IDepartmentRep

    {
        public Task<List<Department>>GetAllDepartments();
        public Task<Department> GetDepartmentById(int DeptID);
        public Task<int> insertDept(Department department);
        public Task<int> updateDept(Department department);
        public Task<int>deleteDept(int DeptID);
            
    }
}
