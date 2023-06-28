using KMHAPIs.Models.ResponseModel;
using KMHAPIs.Models.RequestModel;


namespace KMHAPIs.IRepo
{
    public interface IAccountsRepo
    {
        Task<GenericResponseModel> Login(LoginRequestModel rm);
    }
}
