namespace KMHAPIs.Models.RequestModel
{
    public class AssignRoleToUserRequestModel
    {
        public long ID { get; set; }
        public string Action { get; set; }
        public long RoleID { get; set; }
        public long UserID { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set;}
    }
}
