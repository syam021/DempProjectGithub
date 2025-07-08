using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoproject.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string Address { get; set; }

       public ICollection<Employee>? Employees { get; set; }


        
    }
}
