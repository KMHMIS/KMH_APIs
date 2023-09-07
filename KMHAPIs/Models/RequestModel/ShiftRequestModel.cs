using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;

namespace KMHAPIs.Models.RequestModel
{
    public class ShiftRequestModel
    {
        public string Action { get; set; }
        public long ShiftID { get; set; }
        public string W_SHIFT { get; set; }
        public string  DESCRIPTION { get; set; }
        public string IS_HALF_DAY_ALLOW { get; set; }
        public string START_TIMEEND_TIME { get; set; }
        public string CAN_ARRIVE_FROM { get; set; }
        public string CAN_ARRIVE_TO { get; set; }
        public string LATE_START { get; set; }
        public string  OT_START { get; set; }   
        public string GRACETIME { get ; set; }
        public string TWO_HOURS { get; set; }
        public string HALF_DAY { get; set; }
        public Boolean IsActive { get; set; }
    }
}
