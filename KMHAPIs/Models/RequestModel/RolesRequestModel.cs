namespace KMHAPIs.Models.RequestModel
{
    public class RolesRequestModel
    {
        public string Action { get; set; }
        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
    }
}
