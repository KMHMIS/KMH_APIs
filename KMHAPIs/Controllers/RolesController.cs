using Microsoft.AspNetCore.Mvc;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.IRepo;


namespace KMHAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesRepo _repo;
        public RolesController(IRolesRepo _repo)
        {
            this._repo = _repo;
        }
        [HttpGet]
        [Route("GetRole")]
        public async Task<IActionResult> GetRole()
        {
            return Ok(await _repo.GetRoles());
        }
        [HttpPost]
        [Route("InsertRole")]
        public async Task<IActionResult> InsertRole(RolesRequestModel obj)
        {
            return Ok(await _repo.InsertRoles(obj));
        }
        [HttpPut]
        [Route("UpdateRole")]
        public async Task<IActionResult> UpdateRole(RolesRequestModel obj)
        {
            return Ok(await _repo.UpdateRoles(obj));
        }
        [HttpDelete]
        [Route("DeleteRole")]
        public async Task<IActionResult> DeleteRole(int id,string action)
        {
            return Ok(await _repo.DeleteRoles(id,action));
        }

    }
}
