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
    public class DesignationRepo : IDesignationRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;

        public DesignationRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }
        public async Task<GenericResponseModel> GetDesignation()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_Designation";
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

        public async Task<GenericResponseModel> InsertDesignation(DesignationRequestModel rm)
        {
            try

            {
                var procedureName = "CRUD_Designation";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@DesignationName", rm.DesignationName, DbType.String, ParameterDirection.Input);
                parameters.Add("@CreatedBy", rm.CreatedBy, DbType.String, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateDesignation(DesignationRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_Designation";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@DesignationID", rm.DesignationID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@DesignationName", rm.DesignationName, DbType.String, ParameterDirection.Input);
                parameters.Add("@IsActive", rm.IsActive, DbType.Boolean, ParameterDirection.Input);
                parameters.Add("@UpdatedBy", rm.UpdatedBy, DbType.String, ParameterDirection.Input);

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
        public async Task<GenericResponseModel> DeleteDesignation(int Id, string action)
        {
            try
            {
                var procedureName = "CRUD_Designation";
                var parameters = new DynamicParameters();
                parameters.Add("@DesignationID", Id, DbType.String, ParameterDirection.Input);
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
        public async Task<GenericResponseModel> GetDesignationByActive(string action)
        {
            try
            {
                var procedureName = "CRUD_Designation";
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
