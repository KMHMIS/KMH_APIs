using System.Drawing;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace KMHAPIs.Models.RequestModel
{
    public class EmployeesRequestModel
    {
		public string Action { get; set; }
		public long EmployeeID { get; set; }
		public string EmployeeName { get; set; }
        public string CardNo { get; set; }
        public long DepartmentID { get; set; }
        public long  DesignationID { get; set; }
        public long BankID { get; set; }
        public string BankAccount { get; set; }
        public long GroupID { get; set; }
        public long ShiftID { get; set; }
        public long RosterID { get; set; }
        public string RelationName { get; set; }
        public string Relation { get; set; }
        public long Gender { get; set; }
        public string MobileNo { get; set; }
        public string TelNo { get; set; }
        public string NIC { get; set; }
        public string NIC_ExpDate { get; set; }
	    public string Address { get; set; }
	    public string DateOfBirth { get; set; }
	    public string Religion { get; set; }
        public string NTN { get; set; }
        public long Salary { get; set; }
        public long DutyHours { get; set; }
        public string ShortName { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Qualification { get; set; }
        public string Expericence { get; set; }
	    public string Remarks { get; set; }
        public long ProbationPeriod { get; set; }
        public string IdentMark { get; set; }
        public string DateOfJoining { get; set; }
	    public string DateOfLeaving { get; set; }
	    public string DateOfConfirm { get; set; }
	    public string LeftReason    { get; set; }
	    public long DSalTran     { get; set; }     
        public long AppliedSassi { get; set; }	 
        public long IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedIP { get; set; }
        public int UpdatedBy { get; set; }
	    public int RemoverBy { get; set; }
        public string OldCardNo { get; set; }
        public string EOBINo { get; set; }
        public int EMPEOBIContribute { get; set; }
        public int HospitalEOBIContribute { get; set; }
        public int KMH_discount { get; set; }
        public int Empbarcode_id { get; set; }
        public int IsPermanent { get; set; }
        public int IncomeTax { get; set; }
        public string MaritalStatus { get; set; }
        public Boolean Deactived { get; set; }

    }
}
