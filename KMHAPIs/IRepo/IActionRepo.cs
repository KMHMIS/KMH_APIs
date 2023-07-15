using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IActionRepo
    {
        Task<GenericResponseModel> GetAction();
        Task<GenericResponseModel> InsertAction(ActionRequestModel rm);
        Task<GenericResponseModel> UpdateAction(ActionRequestModel rm);
        Task<GenericResponseModel> DeleteAction(int Id, string action);

        Task<GenericResponseModel> GetActionByActive(string action);
    }
}
