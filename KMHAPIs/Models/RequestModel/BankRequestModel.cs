namespace KMHAPIs.Models.RequestModel
{
    public class BankRequestModel
    {
        public string Action { get; set; }
        public long BankID { get; set; }
        public string BankName { get; set;}
        public Boolean IsActive { get; set;}
    }
}
