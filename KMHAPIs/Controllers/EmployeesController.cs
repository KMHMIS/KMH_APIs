using KMHAPIs.IRepo;
using KMHAPIs.Models.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Concurrent;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;


namespace KMHAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
       private readonly IEmployeesRepo _repo;
        public EmployeesController(IEmployeesRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _repo.GetEmployees());
        }
        [HttpPost]
        [Route("InsertEmployees")]
        public async Task<IActionResult> InsertEmployees(EmployeesRequestModel obj)
        {
            return Ok(await _repo.InsertEmployees(obj));
        }
        [HttpPut]
        [Route("UpdateEmployees")]
        public async Task<IActionResult> UpdateEmployees(EmployeesRequestModel obj)
        {
            return Ok(await _repo.UpdateEmployees(obj));
        }
        [HttpDelete]
        [Route("DeleteEmployees")]
        public async Task<IActionResult> DeleteEmployees(int id, string action,string RemovingBy)
        {
            return Ok(await _repo.DeleteEmployees(id, action, RemovingBy));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
        [HttpGet]
        [Route("GetDataByEmployeeID")]
        public async Task<IActionResult> GetDataByEmployeeID(int id, string action)
        {
            return Ok(await _repo.GetDataByEmployeeID(id, action));
        }
        [HttpGet]
        [Route("GetEmployeeByActive")]
        public async Task<IActionResult> GetEmployeeByActive(string action)
        {
            return Ok(await _repo.GetEmployeeByActive(action));
        }
    }
}
