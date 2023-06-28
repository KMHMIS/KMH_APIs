using KMHAPIs.IRepo;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.Repo;
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
    public class AssignRoleToUserController : ControllerBase
    {
        private readonly IAssignRoleToUserRepo _repo;
        public AssignRoleToUserController(IAssignRoleToUserRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetAssignRoleToUser")]
        public async Task<IActionResult> GetAssignRoleToUser()
        {
            return Ok(await _repo.GetAssignRoleToUser());
        }
        [HttpPost]
        [Route("InsertAssignRoleToUser")]
        public async Task<IActionResult> InsertAssignRoleToUser(AssignRoleToUserRequestModel obj)
        {
            return Ok(await _repo.InsertAssignRoleToUser(obj));
        }
        [HttpPut]
        [Route("UpdateAssignRoleToUser")]
        public async Task<IActionResult> UpdateAssignRoleToUser(AssignRoleToUserRequestModel obj)
        {
            return Ok(await _repo.UpdateAssignRoleToUser(obj));
        }
        [HttpDelete]
        [Route("DeleteAssignRoleToUser")]
        public async Task<IActionResult> DeleteAssignRoleToUser(int id, string action)
        {
            return Ok(await _repo.DeleteAssignRoleToUser(id, action));
        }
    }
}
