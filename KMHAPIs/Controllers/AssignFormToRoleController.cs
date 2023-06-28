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
    public class AssignFormToRoleController : ControllerBase
    {
        private readonly IAssignFormToRoleRepo _repo;
        public AssignFormToRoleController(IAssignFormToRoleRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetAssignFormToRole")]
        public async Task<IActionResult> GetAssignFormToRole()
        {
            return Ok(await _repo.GetAssignFormToRole());
        }
        [HttpPost]
        [Route("InsertAssignFormToRole")]
        public async Task<IActionResult> InsertAssignFormToRole(AssignFormToRoleRequestModel obj)
        {
            return Ok(await _repo.InsertAssignFormToRole(obj));
        }
        [HttpPut]
        [Route("UpdateAssignFormToRole")]
        public async Task<IActionResult> UpdateAssignFormToRole(AssignFormToRoleRequestModel obj)
        {
            return Ok(await _repo.UpdateAssignFormToRole(obj));
        }
        [HttpDelete]
        [Route("DeleteAssignFormToRole")]
        public async Task<IActionResult> DeleteAssignFormToRole(int id, string action)
        {
            return Ok(await _repo.DeleteAssignFormToRole(id, action));
        }
    }
}
