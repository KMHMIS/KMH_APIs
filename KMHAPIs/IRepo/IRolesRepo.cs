using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;


namespace KMHAPIs.IRepo
{
    public interface IRolesRepo
    {
        Task<GenericResponseModel> GetRoles();
        Task<GenericResponseModel> InsertRoles(RolesRequestModel rm);
        Task<GenericResponseModel> UpdateRoles(RolesRequestModel rm);
        Task<GenericResponseModel> DeleteRoles(int EmployeeId,string action);
        Task<GenericResponseModel> GetTableData(string action);
    }
}
