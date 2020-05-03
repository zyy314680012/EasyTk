using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetNewestGoodsResponse
    {
        /// <summary>
        /// id	商品id	Number	19006425
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// goodsId	淘宝商品id	String	“579154850367”
        /// </summary>
        [JsonProperty("goodsId")]
        public string GoodsId { get; set; }

        /// <summary>
        /// originalPrice	原价	Number	59
        /// </summary>
        [JsonProperty("originalPrice")]
        public float? OriginalPrice { get; set; }

        /// <summary>
        /// actualPrice	实际价格	Number	39
        /// </summary>
        [JsonProperty("actualPrice")]
        public float? ActualPrice { get; set; }

        /// <summary>
        /// couponPrice	券金额	Number	20
        /// </summary>
        [JsonProperty("couponPrice")]
        public float? CouponPrice { get; set; }

        /// <summary>
        /// discounts	折扣力度	Number	0.66
        /// </summary>
        [JsonProperty("discounts")]
        public float? Discounts { get; set; }

        /// <summary>
        /// commissionType	佣金类型， 0-通用 ，1- 定向，2-高佣，3-营销计划	Number	3
        /// </summary>
        [JsonProperty("commissionType")]
        public long? CommissionType { get; set; }

        /// <summary>
        /// commissionRate	佣金比率	Number	30
        /// </summary>
        [JsonProperty("commissionRate")]
        public float? CommissionRate { get; set; }

        /// <summary>
        /// couponReceiveNum	已经领券的数量	Number	0
        /// </summary>
        [JsonProperty("couponReceiveNum")]
        public long? CouponReceiveNum { get; set; }

        /// <summary>
        /// twoHoursSales	两小时销量	Number	0
        /// </summary>
        [JsonProperty("twoHoursSales")]
        public long? TwoHoursSales { get; set; }

        /// <summary>
        /// monthSales	30天销量	Number	4861
        /// </summary>
        [JsonProperty("monthSales")]
        public long? MonthSales { get; set; }

        /// <summary>
        /// dailySales	当天销量	Number	0
        /// </summary>
        [JsonProperty("dailySales")]
        public long? DailySales { get; set; }

        /// <summary>
        /// hotPush	热推值	Number	7
        /// </summary>
        [JsonProperty("hotPush")]
        public long? HotPush { get; set; }

        /// <summary>
        /// subcid	商品在大淘客的二级分类id，该分类为前端分类，一个商品可能有多个二级分类id	List[Number]	[86369,90723]
        /// </summary>
        [JsonProperty("subcid")]
        public long[] SubCid { get; set; }

    }
}
