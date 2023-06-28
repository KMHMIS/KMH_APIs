using System.ComponentModel.DataAnnotations;

namespace KMHAPIs.Models.RequestModel
{
    public class LoginRequestModel
    {
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
    }
}
