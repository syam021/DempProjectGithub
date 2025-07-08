using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoproject.Models
{

    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpNm { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        [ForeignKey("Department")]
       public int DeptID { get; set; }
        public Department Department { get; set; }  


    }
}
