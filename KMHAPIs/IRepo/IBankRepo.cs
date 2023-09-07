using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.IRepo
{
    public interface IBankRepo
    {
        Task<GenericResponseModel> GetBank();
        Task<GenericResponseModel> InsertBank(BankRequestModel rm);
        Task<GenericResponseModel> UpdateBank(BankRequestModel rm);
        Task<GenericResponseModel> DeleteBank(int Id, string action);
        Task<GenericResponseModel> GetBankByActive(string action);
        Task<GenericResponseModel> GetTableData(string action);
    }
}
