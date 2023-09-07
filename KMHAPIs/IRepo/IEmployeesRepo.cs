using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IEmployeesRepo
    {
        Task<GenericResponseModel> GetEmployees();
        Task<GenericResponseModel> InsertEmployees(EmployeesRequestModel rm);
        Task<GenericResponseModel> UpdateEmployees(EmployeesRequestModel rm);
        Task<GenericResponseModel> DeleteEmployees(int id, string action,string RemovingBy);
        Task<GenericResponseModel> GetTableData(string action);
        Task<GenericResponseModel> GetDataByEmployeeID(int id, string action);
        Task<GenericResponseModel> GetEmployeeByActive(string action);
    }
}
