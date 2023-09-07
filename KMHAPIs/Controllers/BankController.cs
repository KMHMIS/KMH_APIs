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
    public class BankController : ControllerBase
    {
        private readonly IBankRepo _repo;
        public BankController(IBankRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetBank")]
        public async Task<IActionResult> GetBank()
        {
            return Ok(await _repo.GetBank());
        }
        [HttpPost]
        [Route("InsertBank")]
        public async Task<IActionResult> InsertBank(BankRequestModel obj)
        {
            return Ok(await _repo.InsertBank(obj));
        }
        [HttpPut]
        [Route("UpdateBank")]
        public async Task<IActionResult> UpdateBank(BankRequestModel obj)
        {
            return Ok(await _repo.UpdateBank(obj));
        }
        [HttpDelete]
        [Route("DeleteBank")]
        public async Task<IActionResult> DeleteBank(int id, string action)
        {
            return Ok(await _repo.DeleteBank(id, action));
        }
        [HttpGet]
        [Route("GetBankByActive")]
        public async Task<IActionResult> GetBankByActive(string action)
        {
            return Ok(await _repo.GetBankByActive(action));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
    }
}
