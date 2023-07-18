namespace KMHAPIs.Models.RequestModel
{
    public class AssignFormToRoleRequestModel
    {
        public string Action { get; set; }
        public long ID { get; set; }
        public long FormID { get; set; }
        public long RoleID { get; set; }
        public string ActionID { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set;}
    }
}
