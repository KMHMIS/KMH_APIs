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
    public class BloodGroupController : ControllerBase
    {
        private readonly IBloodGroupRepo _repo;
        public BloodGroupController(IBloodGroupRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetBloodGroup")]
        public async Task<IActionResult> GetBloodGroup()
        {
            return Ok(await _repo.GetBloodGroup());
        }
        [HttpPost]
        [Route("InsertBloodGroup")]
        public async Task<IActionResult> InsertBloodGroup(BloodGroupRequestModel obj)
        {
            return Ok(await _repo.InsertBloodGroup(obj));
        }
        [HttpPut]
        [Route("UpdateBloodGroup")]
        public async Task<IActionResult> UpdateBloodGroup(BloodGroupRequestModel obj)
        {
            return Ok(await _repo.UpdateBloodGroup(obj));
        }
        [HttpDelete]
        [Route("DeleteBloodGroup")]
        public async Task<IActionResult> DeleteBloodGroup(int id, string action)
        {
            return Ok(await _repo.DeleteBloodGroup(id, action));
        }
        [HttpGet]
        [Route("GetBloodGroupByActive")]
        public async Task<IActionResult> GetBloodGroupByActive(string action)
        {
            return Ok(await _repo.GetBloodGroupByActive(action));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
    }
}
