using EasyTk.HaoDanKu.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class LowPricePinkAgeDataResponse : GoodItemPartial
    {
        ///<summary> 
        ///integer	9522	放单人ID
        ///</summary>
        [JsonProperty("seller_id")]
        public long? SellerId { get; set; }
    }
}
