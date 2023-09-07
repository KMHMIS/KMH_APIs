using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IShiftRepo
    {
        Task<GenericResponseModel> GetShift();
        Task<GenericResponseModel> InsertShift(ShiftRequestModel rm);
        Task<GenericResponseModel> UpdateShift(ShiftRequestModel rm);
        Task<GenericResponseModel> DeleteShift(int Id, string action);
        Task<GenericResponseModel> GetShiftByActive(string action);
        Task<GenericResponseModel> GetTableData(string action);
    }
}
