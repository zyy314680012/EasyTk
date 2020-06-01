using Newtonsoft.Json;
using System;

namespace EasyTk.HaoDanKu.Response
{
    [Obsolete]
    public class BrandTodayRecommendResponse
    {
        ///<summary> 
        ///
        ///</summary>
        [JsonProperty("data")]
        public BrandResponse.TodayRecommendData Data { get; set; }
    }
}
