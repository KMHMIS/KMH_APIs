namespace KMHAPIs.Models.ResponseModel
{
    public class GenericResponseModel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public dynamic data { get; set; }
    }
}
