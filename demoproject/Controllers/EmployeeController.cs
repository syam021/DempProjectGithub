using demoproject.DataAccess.IRepostiory;
using demoproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demoproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        public IEmployeeRep EmpRef;

        public EmployeeController(IEmployeeRep _EmpRef)
        {  EmpRef = _EmpRef; }

        [HttpGet]
        [Route("GetAllEmployee")]
        public async Task< IActionResult> GetAllEmployee()
        {
           
            try
            {
                var EmpList = await EmpRef.GetAllEmployee();
                if(EmpList.Count > 0)
                 {
                    return Ok(EmpList);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            { 
              return BadRequest(ex.Message);
            
            }

        }

        [HttpGet]
        [Route("GetEmpID")]
        public async Task<IActionResult> GetEmpID(int EmpID)
        {
            try
            {
               var Emp =  await EmpRef.GetEmpID(EmpID);
                if(Emp !=null) 
                {
                    return Ok (Emp);
                }
                else { return NotFound(); }
            }
            catch (Exception ex)

            { return BadRequest("");
            }
        }

        [HttpPost]
        [Route("insertEmp")]
        public async Task<IActionResult> insertEmp(Employee employee)
        {
            try
            {
                var Count = await EmpRef.intsertEmployee(employee);
                if(Count > 0) 
                {
                   return Ok ( Count);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex) {return BadRequest(""); }
        }

        [HttpPut]
        [Route("updateEmp")]
        public async Task<IActionResult> updateEmp(Employee employee)
        
        { 
            try
            {
                var Count= await EmpRef.intsertEmployee(employee);
                if (Count > 0)
                 {
                    return Ok ( Count);
                }
                else
                {
                    return NotFound();
                }
            }

            catch (Exception ex) 
            
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("deleteEmp")]
        public async Task <IActionResult> deleteEmp(int empID)
        {
            try
            {
                var Count = await EmpRef.deleteEmployee(empID);
                if(Count > 0)
                 {
                    return Ok ( Count);
                }
                else
                {
                    return NotFound();
                }

            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
