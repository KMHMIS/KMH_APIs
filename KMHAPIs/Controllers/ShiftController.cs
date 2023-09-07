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
    public class ShiftController : ControllerBase
    {
        private readonly IShiftRepo _repo;
        public ShiftController(IShiftRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetShift")]
        public async Task<IActionResult> GetShift()
        {
            return Ok(await _repo.GetShift());
        }
        [HttpPost]
        [Route("InsertShift")]
        public async Task<IActionResult> InsertShift(ShiftRequestModel obj)
        {
            return Ok(await _repo.InsertShift(obj));
        }
        [HttpPut]
        [Route("UpdateShift")]
        public async Task<IActionResult> UpdateShift(ShiftRequestModel obj)
        {
            return Ok(await _repo.UpdateShift(obj));
        }
        [HttpDelete]
        [Route("DeleteShift")]
        public async Task<IActionResult> DeleteShift(int id, string action)
        {
            return Ok(await _repo.DeleteShift(id, action));
        }
        [HttpGet]
        [Route("GetShiftByActive")]
        public async Task<IActionResult> GetShiftByActive(string action)
        {
            return Ok(await _repo.GetShiftByActive(action));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
    }
}
