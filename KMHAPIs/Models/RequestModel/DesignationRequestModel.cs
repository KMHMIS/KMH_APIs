namespace KMHAPIs.Models.RequestModel
{
    public class DesignationRequestModel
    {
        public string Action { get; set; }
        public long DesignationID { get; set; }
        public string DesignationName { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

    }
}
