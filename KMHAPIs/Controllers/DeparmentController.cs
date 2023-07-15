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
    public class DeparmentController : ControllerBase
    {
        private readonly IDeparmentRepo _repo;
        public DeparmentController(IDeparmentRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetDeparment")]
        public async Task<IActionResult> GetDeparment()
        {
            return Ok(await _repo.GetDeparment());
        }
        [HttpPost]
        [Route("InsertDeparment")]
        public async Task<IActionResult> InsertDeparment(DeparmentRequestModel obj)
        {
            return Ok(await _repo.InsertDeparment(obj));
        }
        [HttpPut]
        [Route("UpdateDeparment")]
        public async Task<IActionResult> UpdateDeparment(DeparmentRequestModel obj)
        {
            return Ok(await _repo.UpdateDeparment(obj));
        }
        [HttpDelete]
        [Route("DeleteDeparment")]
        public async Task<IActionResult> DeleteDeparment(int id, string action)
        {
            return Ok(await _repo.DeleteDeparment(id, action));
        }
        [HttpGet]
        [Route("GetDeparmentByActive")]
        public async Task<IActionResult> GetDeparmentByActive(string action)
        {
            return Ok(await _repo.GetDeparmentByActive(action));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
    }
}
