using KMHAPIs.IRepo;
using KMHAPIs.Models.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;

namespace KMHAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _repo;
        public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetEmployee")]
        public async Task<IActionResult> GetEmployee()
        {
            return Ok(await _repo.GetEmployee());
        }
        [HttpPost]
        [Route("InsertEmployee")]
        public async Task<IActionResult> InsertEmployee(EmployeeRequestModel obj)
        {
            return Ok(await _repo.InsertEmployee(obj));
        }
        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(EmployeeRequestModel obj)
        {
            return Ok(await _repo.UpdateEmployee(obj));
        }
        [HttpDelete]
        [Route("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int id,string action)
        {
            return Ok(await _repo.DeleteEmployee(id,action));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
        [HttpGet]
        [Route("GetDataByEmployeeID")]
        public async Task<IActionResult> GetDataByEmployeeID(int id,string action)
        {
            return Ok(await _repo.GetDataByEmployeeID(id,action));
        }
        [HttpGet]
        [Route("GetEmployeeByActive")]
        public async Task<IActionResult> GetEmployeeByActive(string action)
        {
            return Ok(await _repo.GetEmployeeByActive(action));
        }
    }
}
