using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IEmployeeRepo
    {
        Task<GenericResponseModel> GetEmployee();
        Task<GenericResponseModel> InsertEmployee(EmployeeRequestModel rm);
        Task<GenericResponseModel> UpdateEmployee(EmployeeRequestModel rm);
        Task<GenericResponseModel> DeleteEmployee(int id ,string action);
        Task<GenericResponseModel> GetTableData(string action);
        Task<GenericResponseModel> GetDataByEmployeeID(int id,string action);
    }
}
