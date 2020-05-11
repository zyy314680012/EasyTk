using System;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ActivityResponse
    {
        ///<summary> 
        ///activityId  "1571715733668",
        ///</summary>
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        ///<summary> 
        ///pageUrl  "https://tb.ele.me/wow/ele-ad/act/elmtkhd?wh_biz=tm&from=cps_tk",
        ///</summary>
        [JsonProperty("pageUrl")]
        public string PageUrl { get; set; }

        ///<summary> 
        ///avgCommissionRate  "6",
        ///</summary>
        [JsonProperty("avgCommissionRate")]
        public float? AvgCommissionRate { get; set; }

        ///<summary> 
        ///pageName  "饿了么天天抢红包 送大额满减券",
        ///</summary>
        [JsonProperty("pageName")]
        public string PageName { get; set; }

        ///<summary> 
        ///bannerUrl  "https://nr-op.elemecdn.com/image/mussel-1571051890863344.png",
        ///</summary>
        [JsonProperty("bannerUrl")]
        public string BannerUrl { get; set; }

        ///<summary> 
        ///platformName  "淘宝",
        ///</summary>
        [JsonProperty("platformName")]
        public string PlatformName { get; set; }

        ///<summary> 
        ///platformType  2,
        ///</summary>
        [JsonProperty("platformType")]
        public int? PlatformType { get; set; }

        ///<summary> 
        ///startTime  "2019-12-04",
        ///</summary>
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        ///<summary> 
        ///endTime  "2099-12-31"
        ///</summary>
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }
    }
}
