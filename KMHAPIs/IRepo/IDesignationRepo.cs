using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IDesignationRepo
    {
        Task<GenericResponseModel> GetDesignation();
        Task<GenericResponseModel> InsertDesignation(DesignationRequestModel rm);
        Task<GenericResponseModel> UpdateDesignation(DesignationRequestModel rm);
        Task<GenericResponseModel> DeleteDesignation(int Id, string action);
        Task<GenericResponseModel> GetDesignationByActive(string action);
    }
}
