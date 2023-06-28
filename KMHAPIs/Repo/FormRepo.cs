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
    public class FormRepo :IFormRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;

        public FormRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }

        public async Task<GenericResponseModel> GetForm()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_Form";
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

        public async Task<GenericResponseModel> InsertForm(FormRequestModel rm)
        {
            try

            {
                var procedureName = "CRUD_Form";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@FormName", rm.FormName, DbType.String, ParameterDirection.Input);
                parameters.Add("@URL", rm.URL, DbType.String, ParameterDirection.Input);
                parameters.Add("@ParentID", rm.ParentID, DbType.Int64, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateForm(FormRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_Form";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@FormID", rm.FormID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@FormName", rm.FormName, DbType.String, ParameterDirection.Input);
                parameters.Add("@URL", rm.URL, DbType.String, ParameterDirection.Input);
                parameters.Add("@ParentID", rm.ParentID, DbType.Int64, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> DeleteForm(int id, string action)
        {
            try
            {
                var procedureName = "CRUD_Form";
                var parameters = new DynamicParameters();
                parameters.Add("@FormID", id, DbType.Int64, ParameterDirection.Input);
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
