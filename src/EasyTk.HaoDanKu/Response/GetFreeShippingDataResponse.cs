using EasyTk.HaoDanKu.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class GetFreeShippingDataResponse : GoodItemPartial
    {
        ///<summary> 
        ///integer	5.76	预估淘礼金
        ///</summary>
        [JsonProperty("ysyl_tlj_face")]
        public float? YsylTljFace { get; set; }
    }
}
