using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class BrandTodayRecommendResponse
    {
        ///<summary> 
        ///
        ///</summary>
        [JsonProperty("data")]
        public BrandResponse.TodayRecommendData Data { get; set; }
    }
}
