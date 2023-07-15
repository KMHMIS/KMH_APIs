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
    public class ActionRepo : IActionRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;

        public ActionRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }

        public async Task<GenericResponseModel> GetAction()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_Action";
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

        public async Task<GenericResponseModel> InsertAction(ActionRequestModel rm)
        {
            try

            {
                var procedureName = "CRUD_Action";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@ActionName", rm.ActionName, DbType.String, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateAction(ActionRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_Action";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@ActionID", rm.ActionID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@ActionName", rm.ActionName, DbType.String, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> DeleteAction(int Id, string action)
        {
            try
            {
                var procedureName = "CRUD_Action";
                var parameters = new DynamicParameters();
                parameters.Add("@ActionID", Id, DbType.String, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> GetActionByActive(string action)
        {
            try
            {
                var procedureName = "CRUD_Action";
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
