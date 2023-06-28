namespace KMHAPIs.Models.RequestModel
{
    public class FormRequestModel
    {
        public string Action { get; set; }
        public long FormID { get; set; }
        public string FormName { get; set; }
        public string URL { get; set; }
        public long ParentID { get; set; }
        public bool IsActive { get; set; }
    }
}
