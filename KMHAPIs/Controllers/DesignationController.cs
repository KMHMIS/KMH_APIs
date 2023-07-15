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
    public class DesignationController : ControllerBase
    {

        private readonly IDesignationRepo _repo;
        public DesignationController(IDesignationRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetDesignation")]
        public async Task<IActionResult> GetDesignation()
        {
            return Ok(await _repo.GetDesignation());
        }
        [HttpPost]
        [Route("InsertDesignation")]
        public async Task<IActionResult> InsertDesignation(DesignationRequestModel obj)
        {
            return Ok(await _repo.InsertDesignation(obj));
        }
        [HttpPut]
        [Route("UpdateDesignation")]
        public async Task<IActionResult> UpdateDesignation(DesignationRequestModel obj)
        {
            return Ok(await _repo.UpdateDesignation(obj));
        }
        [HttpDelete]
        [Route("DeleteDesignation")]
        public async Task<IActionResult> DeleteDesignation(int id, string action)
        {
            return Ok(await _repo.DeleteDesignation(id, action));
        }
        [HttpGet]
        [Route("GetDesignationByActive")]
        public async Task<IActionResult> GetDeparmentByActive(string action)
        {
            return Ok(await _repo.GetDesignationByActive(action));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
    }
}
