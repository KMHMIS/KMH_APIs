using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IBloodGroupRepo
    {
        Task<GenericResponseModel> GetBloodGroup();
        Task<GenericResponseModel> InsertBloodGroup(BloodGroupRequestModel rm);
        Task<GenericResponseModel> UpdateBloodGroup(BloodGroupRequestModel rm);
        Task<GenericResponseModel> DeleteBloodGroup(int Id, string action);
        Task<GenericResponseModel> GetBloodGroupByActive(string action);
        Task<GenericResponseModel> GetTableData(string action);
    }
}
