using EasyTk.HaoDanKu.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class UpdateItemResponse
    {
        ///<summary> 
        ///Integer	2720653	自增ID
        ///</summary>
        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        ///<summary> 
        ///Integer	553757100845	宝贝ID
        ///</summary>
        [JsonProperty("itemid")]
        public long ItemId { get; set; }

        ///<summary> 
        ///integer	33879	宝贝月销量
        ///</summary>
        [JsonProperty("itemsale")]
        public long? ItemSale { get; set; }

        ///<summary> 
        ///integer	5612	宝贝近2小时跑单
        ///</summary>
        [JsonProperty("itemsale2")]
        public long? ItemSale2 { get; set; }

        ///<summary> 
        ///integer	10493	当天销量
        ///</summary>
        [JsonProperty("todaysale")]
        public long? TodaySale { get; set; }

        ///<summary> 
        ///344	好单指数
        ///</summary>
        [JsonProperty("general_index")]
        public long? GeneralIndex { get; set; }

        ///<summary> 
        ///xxxx	优惠券链接
        ///</summary>
        [JsonProperty("couponurl")]
        public string CouponUrl { get; set; }

        ///<summary> 
        ///integer	0	优惠券领取量
        ///</summary>
        [JsonProperty("couponreceive")]
        public long? CouponReceive { get; set; }

        ///<summary> 
        ///integer	100000	优惠券剩余量
        ///</summary>
        [JsonProperty("couponsurplus")]
        public long? CouponSurplus { get; set; }

        ///<summary> 
        ///xxxxx	优惠券id
        ///</summary>
        [JsonProperty("activityid")]
        public string ActivityId { get; set; }

        ///<summary> 
        ///10	优惠券金额
        ///</summary>
        [JsonProperty("couponmoney")]
        public float? CouponMoney { get; set; }
    }
}
