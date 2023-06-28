using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IAssignFormToRoleRepo
    {
        Task<GenericResponseModel> GetAssignFormToRole();
        Task<GenericResponseModel> InsertAssignFormToRole(AssignFormToRoleRequestModel rm);
        Task<GenericResponseModel> UpdateAssignFormToRole(AssignFormToRoleRequestModel rm);
        Task<GenericResponseModel> DeleteAssignFormToRole(int id, string action);

    }
}
