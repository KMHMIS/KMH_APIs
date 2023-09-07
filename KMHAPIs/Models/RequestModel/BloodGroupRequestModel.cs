namespace KMHAPIs.Models.RequestModel
{
    public class BloodGroupRequestModel
    {
        public string Action { get; set; }
        public long GroupID { get; set; }
        public string GroupName { get; set; }
        public Boolean IsActive { get; set; }
    }
}
