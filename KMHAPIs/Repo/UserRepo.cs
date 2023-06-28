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

    public class UserRepo :IUserRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;

        public UserRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }

       

        public async Task<GenericResponseModel> GetUser()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_Users";
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

        public async Task<GenericResponseModel> InsertUser(UserRequestModel rm)
        {
            try

            {
                var procedureName = "CRUD_Users";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@EmployeeID", rm.EmployeeID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@FirstName", rm.FirstName, DbType.String, ParameterDirection.Input);
                parameters.Add("@LastName", rm.LastName, DbType.String, ParameterDirection.Input);
                parameters.Add("@UserName", rm.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("@Password", rm.Password, DbType.String, ParameterDirection.Input);
                parameters.Add("@Reason", rm.Reason, DbType.String, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateUser(UserRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_Users";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@UserID", rm.UserID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@EmployeeID", rm.EmployeeID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@FirstName", rm.FirstName, DbType.String, ParameterDirection.Input);
                parameters.Add("@LastName", rm.LastName, DbType.String, ParameterDirection.Input);
                parameters.Add("@UserName", rm.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("@Password", rm.Password, DbType.String, ParameterDirection.Input);
                parameters.Add("@Reason", rm.Reason, DbType.String, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> DeleteUser(int id, string action)
        {
            try
            {
                var procedureName = "CRUD_Users";
                var parameters = new DynamicParameters();
                parameters.Add("@UserID", id, DbType.String, ParameterDirection.Input);
                parameters.Add("@Action", action, DbType.String, ParameterDirection.Input);
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
    }
}
