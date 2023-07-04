using KMHAPIs.Dapper;
using KMHAPIs.IRepo;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;
using KMHAPIs.Models.SpResponseModel;
using Dapper;
using System.Data;
using System.Xml.Linq;

namespace KMHAPIs.Repo
{
    public class EmployeeRepo :IEmployeeRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;
        public EmployeeRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }
        public async Task<GenericResponseModel> GetEmployee()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_Employee";
                IEnumerable<dynamic> data = await db.GetAll<dynamic>(procedureName, parameters);
                response.message = "success";
                response.status = true;
                response.data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.data = "";
                response.message = ex.Message;
                response.status = false;
                return response;
            }
        }
        public async Task<GenericResponseModel> InsertEmployee(EmployeeRequestModel rm)
        {
            try
            
            {
                var procedureName = "CRUD_Employee";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@FirstName", rm.FirstName, DbType.String, ParameterDirection.Input);
                parameters.Add("@LastName", rm.LastName, DbType.String, ParameterDirection.Input);
                parameters.Add("@DeparmentID", rm.DeparmentID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@DesignationID", rm.DesignationID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@JoiningDate", rm.JoiningDate, DbType.String, ParameterDirection.Input);
                parameters.Add("@RelievingDate", rm.RelievingDate, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfBirth", rm.DateOfBirth, DbType.String, ParameterDirection.Input);
                parameters.Add("@Salary", rm.Salary, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Address", rm.Address, DbType.String, ParameterDirection.Input);
                parameters.Add("@Email", rm.Email, DbType.String, ParameterDirection.Input);
                parameters.Add("@PhoneNo1", rm.PhoneNo1, DbType.String, ParameterDirection.Input);
                parameters.Add("@PhoneNo2", rm.PhoneNo2, DbType.String, ParameterDirection.Input);
                parameters.Add("@LastCompanyName", rm.LastCompanyName, DbType.String, ParameterDirection.Input);
                parameters.Add("@CreatedBy", rm.CreatedBy, DbType.Int64, ParameterDirection.Input);
                

                IEnumerable<dynamic> data = await db.Get<dynamic>(procedureName, parameters);
                response.message = "success";
                response.status = true;
                return response;
            }
            catch (Exception ex)
            {
                response.data = "";
                response.message = ex.Message;
                response.status = false;
                return response;
            }
        }

        public async Task<GenericResponseModel> UpdateEmployee(EmployeeRequestModel rm)
        {

            try
            {
                var procedureName = "CRUD_Employee";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@EmployeeID", rm.EmployeeID, DbType.String, ParameterDirection.Input);
                parameters.Add("@FirstName", rm.FirstName, DbType.String, ParameterDirection.Input);
                parameters.Add("@LastName", rm.LastName, DbType.String, ParameterDirection.Input);
                parameters.Add("@DeparmentID", rm.DeparmentID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@DesignationID", rm.DesignationID, DbType.String, ParameterDirection.Input);
                parameters.Add("@JoiningDate", rm.JoiningDate, DbType.String, ParameterDirection.Input);
                parameters.Add("@RelievingDate", rm.RelievingDate, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfBirth", rm.DateOfBirth, DbType.String, ParameterDirection.Input);
                parameters.Add("@Salary", rm.Salary, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Address", rm.Address, DbType.String, ParameterDirection.Input);
                parameters.Add("@Email", rm.Email, DbType.String, ParameterDirection.Input);
                parameters.Add("@PhoneNo1", rm.PhoneNo1, DbType.String, ParameterDirection.Input);
                parameters.Add("@PhoneNo2", rm.PhoneNo2, DbType.String, ParameterDirection.Input);
                parameters.Add("@LastCompanyName", rm.LastCompanyName, DbType.String, ParameterDirection.Input);
                parameters.Add("@IsActive", rm.IsActive, DbType.Boolean, ParameterDirection.Input);
                parameters.Add("@UpdatedBy", rm.UpdatedBy, DbType.Int64, ParameterDirection.Input);
                IEnumerable<dynamic> data = await db.Get<dynamic>(procedureName, parameters);
                response.message = "success";
                response.status = true;
                return response;
            }
            catch (Exception ex)
            {
                response.data = "";
                response.message = ex.Message;
                response.status = false;
                return response;
            }

        }

        public async Task<GenericResponseModel> DeleteEmployee(int id,string action)
        {
            try
            {
                var procedureName = "CRUD_Employee";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", action, DbType.String, ParameterDirection.Input);
                parameters.Add("@EmployeeID", id, DbType.String, ParameterDirection.Input);
                IEnumerable<dynamic> data = await db.Get<dynamic>(procedureName, parameters);
                response.message = "success";
                response.status = true;
                return response;
            }
            catch (Exception ex)
            {
                response.data = "";
                response.message = ex.Message;
                response.status = false;
                return response;
            }
        }

        public async Task<GenericResponseModel> GetTableData(string action)
        {
            try
            {
                var procedureName = "CRUD_Employee";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", action, DbType.String, ParameterDirection.Input);
                IEnumerable<dynamic> data = await db.GetAll<dynamic>(procedureName, parameters);
                response.message = "success";
                response.status = true;
                response.data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.data = "";
                response.message = ex.Message;
                response.status = false;
                return response;
            }
        }
        public async Task<GenericResponseModel> GetDataByEmployeeID(int id, string action)
        {
            try
            {
                var procedureName = "CRUD_Employee";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", action, DbType.String, ParameterDirection.Input);
                parameters.Add("@EmployeeID", id, DbType.String, ParameterDirection.Input);
                IEnumerable<dynamic> data = await db.GetAll<dynamic>(procedureName, parameters);
                response.message = "success";
                response.status = true;
                response.data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.data = "";
                response.message = ex.Message;
                response.status = false;
                return response;
            }
        }
    }
}
