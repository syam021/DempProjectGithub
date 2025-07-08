using Azure.Core;
using demoproject.DataAccess.IRepostiory;
using demoproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demoproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        public IDepartmentRep DeptRef;

        public DepartmentController(IDepartmentRep _deptRef)
        {
            DeptRef = _deptRef;
        }
        [HttpGet]
        [Route("AllDepartment")]
        public async Task<IActionResult> AllDepartment()
        {
            try
            {
                var DeptList = await DeptRef.GetAllDepartments();
                if (DeptList.Count > 0)
                {
                    return Ok(DeptList);

                }
                else 
                {
                    return NotFound("Records not Found ");
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }


        }

        [HttpGet]
        [Route("GetDepartmentById")]
        public async Task<IActionResult> GetDepartmentById(int DeptID)
        {
            try
            {
                var Dept = await DeptRef.GetDepartmentById(DeptID);
                if (Dept != null)
                {
                    return Ok(Dept);

                }
                else
                {
                    return NotFound();
                }


            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }


        [HttpPost]
        [Route("insertDept")]
        public async Task<IActionResult> insertDept(Department department)
        {
            try
            {
                var Count = await DeptRef.insertDept(department);
                if (Count > 0)
                {
                    return Ok(Count);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)

            {
                return BadRequest(ex);
            }
        }


        [HttpPut]
        [Route("updateDept")]
        public async Task<IActionResult> updateDept(Department department)
        {
            try
            {
                var Count = await DeptRef.updateDept(department);
                if (Count > 0)
                {
                    return Ok(Count);

                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        [Route("deleteDept")]
        public async Task<IActionResult> deleteDept(int DeptID)
        {
            try
            {
                var Count = await DeptRef.deleteDept(DeptID);
                if(Count > 0)
                {
                    return Ok (Count);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
