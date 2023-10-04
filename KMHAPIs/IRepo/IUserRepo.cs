using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IUserRepo
    {
        Task<GenericResponseModel> GetUser();
        Task<GenericResponseModel> InsertUser(UserRequestModel rm);
        Task<GenericResponseModel> UpdateUser(UserRequestModel rm);
        Task<GenericResponseModel> DeleteUser(int Id,string action);
        Task<GenericResponseModel> GetTableData(string action);
        Task<GenericResponseModel> GetUserByActive(string action);
        Task<GenericResponseModel> GetUserName(string action);
    }
}
