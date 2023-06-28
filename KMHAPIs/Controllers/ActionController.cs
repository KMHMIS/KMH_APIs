using Microsoft.AspNetCore.Mvc;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.IRepo;



namespace KMHAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IActionRepo _repo;
        public ActionController(IActionRepo _repo)
        {
            this._repo = _repo;
        }
        [HttpGet]
        [Route("GetAction")]
        public async Task<IActionResult> GetAction()
        {
            return Ok(await _repo.GetAction());
        }
        [HttpPost]
        [Route("InsertAction")]
        public async Task<IActionResult> InsertAction(ActionRequestModel obj)
        {
            return Ok(await _repo.InsertAction(obj));
        }
        [HttpPut]
        [Route("UpdateAction")]
        public async Task<IActionResult> UpdateAction(ActionRequestModel obj)
        {
            return Ok(await _repo.UpdateAction(obj));
        }
        [HttpDelete]
        [Route("DeleteAction")]
        public async Task<IActionResult> DeleteAction(int id, string action)
        {
            return Ok(await _repo.DeleteAction(id, action));
        }
    }
}
