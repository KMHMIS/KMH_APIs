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
    public class RolesRepo :IRolesRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;

        public RolesRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }
        public async Task<GenericResponseModel> GetRoles()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_Roles";
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

        public async Task<GenericResponseModel> InsertRoles(RolesRequestModel rm)
        {
            try

            {
                var procedureName = "CRUD_Roles";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@RoleName", rm.RoleName, DbType.String, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateRoles(RolesRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_Roles";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@RoleID", rm.RoleID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@RoleName", rm.RoleName, DbType.String, ParameterDirection.Input);
                parameters.Add("@IsActive", rm.IsActive, DbType.Boolean, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> DeleteRoles(int Id,string action)
        {
            try
            {
                var procedureName = "CRUD_Roles";
                var parameters = new DynamicParameters();
                parameters.Add("@RoleID", Id, DbType.String, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> GetTableData(string action)
        {
            try
            {
                var procedureName = "CRUD_Roles";
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
    }
}
