using KMHAPIs.Dapper;
using KMHAPIs.IRepo;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;
using KMHAPIs.Models.SpResponseModel;
using Dapper;
using System.Data;
using System.Xml.Linq;
using System;

namespace KMHAPIs.Repo
{
    public class AssignRoleToUserRepo : IAssignRoleToUserRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;

        public AssignRoleToUserRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }

      
        public async Task<GenericResponseModel> GetAssignRoleToUser()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_AssginRoleToUser";
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

        public async Task<GenericResponseModel> InsertAssignRoleToUser(AssignRoleToUserRequestModel rm)
        {
            try

            {
                var procedureName = "CRUD_AssginRoleToUser";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@RoleID", rm.RoleID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@UserID", rm.UserID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@ActionID", rm.ActionID, DbType.Int64, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateAssignRoleToUser(AssignRoleToUserRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_AssginRoleToUser";
                var parameters = new DynamicParameters();
                parameters.Add("@ID", rm.ID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@RoleID", rm.RoleID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@UserID", rm.UserID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@ActionID", rm.ActionID, DbType.Int64, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> DeleteAssignRoleToUser(int id, string action)
        {
            try
            {
                var procedureName = "CRUD_AssginRoleToUser";
                var parameters = new DynamicParameters();
                parameters.Add("@ID", id, DbType.String, ParameterDirection.Input);
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
