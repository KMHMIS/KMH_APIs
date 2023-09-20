using KMHAPIs.Dapper;
using KMHAPIs.IRepo;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;
using KMHAPIs.Models.SpResponseModel;
using Dapper;
using System.Data;
using System.Xml.Linq;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace KMHAPIs.Repo
{
    public class EmployeesRepo :IEmployeesRepo
    {
        private readonly IDapper db;
        GenericResponseModel response;
        public EmployeesRepo(IDapper db, GenericResponseModel response)
        {
            this.db = db;
            this.response = response;
        }
        public async Task<GenericResponseModel> GetEmployees()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                var procedureName = "CRUD_Employees";
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
        public async Task<GenericResponseModel> InsertEmployees(EmployeesRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_Employees";
                var parameters = new DynamicParameters();
       

                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@EmployeeName ", rm.EmployeeName, DbType.String, ParameterDirection.Input);
                parameters.Add("@CardNo", rm.CardNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@DepartmentID", rm.DepartmentID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@DesignationID", rm.DesignationID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@BankID", rm.BankID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@BankAccount", rm.BankAccount, DbType.String, ParameterDirection.Input);
                parameters.Add("@GroupID ", rm.GroupID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@ShiftID", rm.ShiftID, DbType.Int64, ParameterDirection.Input);
                //parameters.Add("@RosterID", rm.RosterID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@RelationName", rm.RelationName, DbType.String, ParameterDirection.Input);
                parameters.Add("@Relation", rm.Relation, DbType.String, ParameterDirection.Input);
                parameters.Add("@Gender", rm.Gender, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Mobile", rm.MobileNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@TelNo", rm.TelNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@NIC", rm.NIC, DbType.String, ParameterDirection.Input);
                parameters.Add("@NIC_ExpDate", rm.NIC_ExpDate, DbType.String, ParameterDirection.Input);
                parameters.Add("@Address", rm.Address, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfBirth", rm.DateOfBirth, DbType.String, ParameterDirection.Input);
                parameters.Add("@Religion", rm.Religion, DbType.String, ParameterDirection.Input);
                parameters.Add("@NTN", rm.NTN, DbType.String, ParameterDirection.Input);
                parameters.Add("@Salary", rm.Salary, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@DutyHours", rm.DutyHours, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@ShortName", rm.ShortName, DbType.String, ParameterDirection.Input);
                //parameters.Add("@Add2", rm.Add1, DbType.String, ParameterDirection.Input);
                parameters.Add("@Add1", rm.Add1, DbType.String, ParameterDirection.Input);
                parameters.Add("@Qualification", rm.Qualification, DbType.String, ParameterDirection.Input);
                parameters.Add("@Expericence", rm.Expericence, DbType.String, ParameterDirection.Input);
                parameters.Add("@Remarks", rm.Remarks, DbType.String, ParameterDirection.Input);
                parameters.Add("@ProbationPeriod", rm.ProbationPeriod, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@IdentMark", rm.IdentMark, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfJoining", rm.DateOfJoining, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfLeaving", rm.DateOfLeaving, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfConfirm", rm.DateOfConfirm, DbType.String, ParameterDirection.Input);
                parameters.Add("@LeftReason", rm.LeftReason, DbType.String, ParameterDirection.Input);
                parameters.Add("@DSalTran", rm.DSalTran, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@AppliedSassi", rm.AppliedSassi, DbType.Boolean, ParameterDirection.Input);
               
                
                //parameters.Add("@CreatedIP", rm.CreatedIP, DbType.String, ParameterDirection.Input);
               
                //parameters.Add("@OldCardNo", rm.OldCardNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@EOBINo", rm.EOBINo, DbType.String, ParameterDirection.Input);
                parameters.Add("@EMPEOBIContribute", rm.EMPEOBIContribute, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@HospitalEOBIContribute", rm.HospitalEOBIContribute, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@KMH_discount", rm.KMH_discount, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Empbarcode_id", rm.Empbarcode_id, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@IsPermanent", rm.IsPermanent, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@IncomeTax", rm.IncomeTax, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@MaritalStatus", rm.MaritalStatus, DbType.String, ParameterDirection.Input);
                parameters.Add("@Deactived", rm.Deactived, DbType.Boolean, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> UpdateEmployees(EmployeesRequestModel rm)
        {
            try
            {
                var procedureName = "CRUD_Employees";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", rm.Action, DbType.String, ParameterDirection.Input);
                parameters.Add("@EmployeeName ", rm.EmployeeName, DbType.String, ParameterDirection.Input);
                parameters.Add("@CardNo", rm.CardNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@DepartmentID", rm.DepartmentID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@DesignationID", rm.DesignationID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@BankID", rm.BankID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@BankAccount", rm.BankAccount, DbType.String, ParameterDirection.Input);
                parameters.Add("@GroupID ", rm.GroupID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@ShiftID", rm.ShiftID, DbType.Int64, ParameterDirection.Input); 
                parameters.Add("@RosterID", rm.RosterID, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@RelationName", rm.RelationName, DbType.String, ParameterDirection.Input);
                parameters.Add("@Relation", rm.Relation, DbType.String, ParameterDirection.Input);
                parameters.Add("@Gender", rm.Gender, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Mobile", rm.MobileNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@TelNo", rm.TelNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@NIC", rm.NIC, DbType.String, ParameterDirection.Input);
                parameters.Add("@NIC_ExpDate", rm.NIC_ExpDate, DbType.String, ParameterDirection.Input);
                parameters.Add("@Address", rm.Address, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfBirth", rm.DateOfBirth, DbType.String, ParameterDirection.Input);
                parameters.Add("@Religion", rm.Religion, DbType.String, ParameterDirection.Input);
                parameters.Add("@NTN", rm.NTN, DbType.String, ParameterDirection.Input);
                parameters.Add("@Salary", rm.Salary, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@DutyHours", rm.DutyHours, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@ShortName", rm.ShortName, DbType.String, ParameterDirection.Input);
                parameters.Add("@Add2", rm.Add1, DbType.String, ParameterDirection.Input);
                parameters.Add("@Add1", rm.Add2, DbType.String, ParameterDirection.Input);
                parameters.Add("@Qualification", rm.Qualification, DbType.String, ParameterDirection.Input);
                parameters.Add("@Expericence", rm.Expericence, DbType.String, ParameterDirection.Input);
                parameters.Add("@Remarks", rm.Remarks, DbType.String, ParameterDirection.Input);
                parameters.Add("@ProbationPeriod", rm.ProbationPeriod, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@IdentMark", rm.IdentMark, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfJoining", rm.DateOfJoining, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfLeaving", rm.DateOfLeaving, DbType.String, ParameterDirection.Input);
                parameters.Add("@DateOfConfirm", rm.DateOfConfirm, DbType.String, ParameterDirection.Input);
                parameters.Add("@LeftReason", rm.LeftReason, DbType.String, ParameterDirection.Input);
                parameters.Add("@DSalTran", rm.DSalTran, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@AppliedSassi", rm.AppliedSassi, DbType.Boolean, ParameterDirection.Input);

                parameters.Add("@UpdatedBy", rm.UpdatedBy, DbType.Int64, ParameterDirection.Input);
                

                parameters.Add("@OldCardNo", rm.OldCardNo, DbType.String, ParameterDirection.Input);
                parameters.Add("@EOBINo", rm.EOBINo, DbType.String, ParameterDirection.Input);
                parameters.Add("@EMPEOBIContribute", rm.EMPEOBIContribute, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@HospitalEOBIContribute", rm.HospitalEOBIContribute, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@KMH_discount", rm.KMH_discount, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@Empbarcode_id", rm.Empbarcode_id, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@IsPermanent", rm.IsPermanent, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@IncomeTax", rm.IncomeTax, DbType.Int64, ParameterDirection.Input);
                parameters.Add("@MaritalStatus", rm.MaritalStatus, DbType.String, ParameterDirection.Input);
                parameters.Add("@Deactived", rm.Deactived, DbType.Boolean, ParameterDirection.Input);
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

        public async Task<GenericResponseModel> DeleteEmployees(int id, string action,string RemoverBy)
        {
            try
            {
                var procedureName = "CRUD_Employees";
                var parameters = new DynamicParameters();
                parameters.Add("@Action", action, DbType.String, ParameterDirection.Input);
                parameters.Add("@EmployeeID", id, DbType.String, ParameterDirection.Input);
                parameters.Add("@RemoverBy",RemoverBy, DbType.String, ParameterDirection.Input);
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
                var procedureName = "CRUD_Employees";
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
                var procedureName = "CRUD_Employees";
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
        public async Task<GenericResponseModel> GetEmployeeByActive(string action)
        {
            try
            {
                var procedureName = "CRUD_Employees";
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
