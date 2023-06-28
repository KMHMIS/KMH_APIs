using System.ComponentModel.DataAnnotations;
using System.Net;

namespace KMHAPIs.Models.RequestModel
{
    public class EmployeeRequestModel
    {
        
        public long EmployeeID { get; set; }
        public string Action { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long DeparmentID { get; set; }
        public long DesignationID { get; set; }
        public string JoiningDate { get; set; }
        public string RelievingDate { get; set; }
        public string DateOfBirth { get; set; }
        public long Salary { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set;}
        public string LastCompanyName { get; set;}
        public bool IsActive { get; set;}
        public int CreatedBy { get; set;}
        public int UpdatedBy { get; set;}

    }
}
