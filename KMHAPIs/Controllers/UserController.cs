using Microsoft.AspNetCore.Mvc;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.IRepo;

namespace KMHAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        public UserController(IUserRepo _repo)
        {
            this._repo = _repo;
        }
        [HttpGet]
        [Route("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await _repo.GetUser());
        }
        [HttpPost]
        [Route("InsertUser")]
        public async Task<IActionResult> InsertUser(UserRequestModel obj)
        {
            return Ok(await _repo.InsertUser(obj));
        }
        [HttpPut]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UserRequestModel obj)
        {
            return Ok(await _repo.UpdateUser(obj));
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int id,string action)
        {
            return Ok(await _repo.DeleteUser(id,action));
        }
        [HttpGet]
        [Route("GetTableData")]
        public async Task<IActionResult> GetTableData(string action)
        {
            return Ok(await _repo.GetTableData(action));
        }
        [HttpGet]
        [Route("GetUserByActive")]
        public async Task<IActionResult> GetUserByActive(string action)
        {
            return Ok(await _repo.GetUserByActive(action));
        }
        [HttpGet]
        [Route("GetUserName")]
        public async Task<IActionResult> GetUserName(string action)
        {
            return Ok(await _repo.GetUserName(action));
        }
    }
}
