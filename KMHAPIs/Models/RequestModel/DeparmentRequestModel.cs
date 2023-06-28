namespace KMHAPIs.Models.RequestModel
{
    public class DeparmentRequestModel
    {
        public string Action { get; set; }
        public long DeparmentID { get; set; }
        public string DeparmentName { get; set; }
        public string Remarks { get; set; }
        public long ParentID { get; set;}
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set;}
    }
}
