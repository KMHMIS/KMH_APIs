namespace KMHAPIs.Models.RequestModel
{
    public class UserRequestModel
    {
        public string Action { get; set; }
        public long UserID{ get; set; }
        public long EmployeeID { get; set; }
        public long DeparmentID { get; set; }
        public string RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Reason { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
