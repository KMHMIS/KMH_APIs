using Microsoft.AspNetCore.Mvc;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.IRepo;

namespace KMHAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
     private readonly IAccountsRepo _accountsRepo;
        public AccountsController(IAccountsRepo _accountsRepo)
        {
            this._accountsRepo = _accountsRepo;
        }

        [HttpPost]
        [Route("Login")]

        public async Task<IActionResult> Login(LoginRequestModel loginRequestModel)
        {
            return Ok(await _accountsRepo.Login(loginRequestModel));
        }
    }
}
