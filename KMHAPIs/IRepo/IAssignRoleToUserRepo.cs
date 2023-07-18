using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IAssignRoleToUserRepo
    {
        Task<GenericResponseModel> GetAssignRoleToUser();
        Task<GenericResponseModel> InsertAssignRoleToUser(AssignRoleToUserRequestModel rm);
        Task<GenericResponseModel> UpdateAssignRoleToUser(AssignRoleToUserRequestModel rm);
        Task<GenericResponseModel> DeleteAssignRoleToUser(int id, string action);

        Task<GenericResponseModel> GetTableData(string action);
    }
}
