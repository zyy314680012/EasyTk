using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ActivityRequest : BaseRequest<BaseResponseContainer<ActivityResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_activity.ashx"
        };

        #region ======================

        ///<summary> 
        ///activityId string	否	联盟官方活动ID
        ///</summary>
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        ///<summary> 
        ///platformType string	否	投放平台，无线或PC，1为PC，2为无线
        ///</summary>
        [JsonProperty("platformType")]
        public long? PlatformType { get; set; }

        #endregion
    }
}
