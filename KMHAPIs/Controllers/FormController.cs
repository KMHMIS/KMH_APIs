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
    public class FormController : ControllerBase
    {
        private readonly IFormRepo _repo;
        public FormController(IFormRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetForm")]
        public async Task<IActionResult> GetForm()
        {
            return Ok(await _repo.GetForm());
        }
        [HttpPost]
        [Route("InsertForm")]
        public async Task<IActionResult> InsertForm(FormRequestModel obj)
        {
            return Ok(await _repo.InsertForm(obj));
        }
        [HttpPut]
        [Route("UpdateForm")]
        public async Task<IActionResult> UpdateForm(FormRequestModel obj)
        {
            return Ok(await _repo.UpdateForm(obj));
        }
        [HttpDelete]
        [Route("DeleteForm")]
        public async Task<IActionResult> DeleteForm(int id, string action)
        {
            return Ok(await _repo.DeleteForm(id, action));
        }
        [HttpGet]
        [Route("GetFormByActive")]
        public async Task<IActionResult> GetFormByActive(string action)
        {
            return Ok(await _repo.GetFormByActive(action));
        }
        [HttpGet]
        [Route("GetDataTable")]
        public async Task<IActionResult> GetDataTable(string action)
        {
            return Ok(await _repo.GetDataTable(action));
        }
    }
}
