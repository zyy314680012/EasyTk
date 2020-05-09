using System;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ShangPinIdResponse : BaseResponse
    {
        #region =====================

        ///<summary> 
        ///item_id  "610638877760",
        ///</summary>
        [JsonProperty("item_id")]
        public long? ItemId { get; set; }

        ///<summary> 
        ///activity_id  "03c5c230bff346eb805121447e2d42b2",
        ///</summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        ///<summary> 
        ///amount  "3.00",
        ///</summary>
        [JsonProperty("amount")]
        public float? Amount { get; set; }

        ///<summary> 
        ///startFee  "6.0",
        ///</summary>
        [JsonProperty("startFee")]
        public float? StartFee { get; set; }

        ///<summary> 
        ///effectiveStartTime  "2020-05-07 00:00:00",
        ///</summary>
        [JsonProperty("effectiveStartTime")]
        public DateTime? EffectiveStartTime { get; set; }

        ///<summary> 
        ///effectiveEndTime  "2020-05-14 23:59:59",
        ///</summary>
        [JsonProperty("effectiveEndTime")]
        public DateTime? EffectiveEndTime { get; set; }

        ///<summary> 
        ///shopLogo  "",
        ///</summary>
        [JsonProperty("shopLogo")]
        public string ShopLogo { get; set; }

        ///<summary> 
        ///shopName  "布鲁迪保罗旗舰店"
        ///</summary>
        [JsonProperty("shopName")]
        public string ShopName { get; set; }

        #endregion
    }
}