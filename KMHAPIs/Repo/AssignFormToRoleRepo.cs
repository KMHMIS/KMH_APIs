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
    public class AssignFormToRoleRepo : IAssignFormToRoleRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;

        public AssignFormToRoleRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }
        public async Task<GenericResponseModel> GetAssignFormToRole()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_AssignFormToRole";
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

        public async Task<GenericResponseModel> InsertAssignFormToRole(AssignFormToRoleRequestModel rm)
        {
            try

            {
                var procedureName = "CRUD_AssignFormToRole";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@FormID", rm.FormID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@RoleID", rm.RoleID, DbType.Int64, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateAssignFormToRole(AssignFormToRoleRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_AssignFormToRole";
                var parameters = new DynamicParameters();
                parameters.Add("@ID", rm.ID, DbType.String, ParameterDirection.Input);
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@FormID", rm.FormID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@RoleID", rm.RoleID, DbType.Int64, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> DeleteAssignFormToRole(int id, string action)
        {
            try
            {
                var procedureName = "CRUD_AssignFormToRole";
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
