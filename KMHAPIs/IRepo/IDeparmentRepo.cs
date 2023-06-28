using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IDeparmentRepo
    {
        Task<GenericResponseModel> GetDeparment();
        Task<GenericResponseModel> InsertDeparment(DeparmentRequestModel rm);
        Task<GenericResponseModel> UpdateDeparment(DeparmentRequestModel rm);
        Task<GenericResponseModel> DeleteDeparment(int id,string action);
        Task<GenericResponseModel> GetDeparmentByActive(string action);
                    
    }
}
