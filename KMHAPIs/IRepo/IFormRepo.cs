using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IFormRepo
    {
        Task<GenericResponseModel> GetForm();
        Task<GenericResponseModel> InsertForm(FormRequestModel rm);
        Task<GenericResponseModel> UpdateForm(FormRequestModel rm);
        Task<GenericResponseModel> DeleteForm(int id, string action);

    }
}
