using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetOwnerGoodsResponse
    {
        /// <summary>
        /// id	商品id	Number	18592060
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// goodsId	淘宝商品id	Number	521027319777
        /// </summary>
        [JsonProperty("goodsId")]
        public string GoodsId { get; set; }

        /// <summary>
        /// createTime	上架时间	String	“2019-03-09 07:43:38”
        /// </summary>
        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        /// <summary>
        /// lowerShelfTime	下架时间	String	“2019-03-09 11:43:29”
        /// </summary>
        [JsonProperty("lowerShelfTime")]
        public string LowerShelfTime { get; set; }

        /// <summary>
        /// refuseReason	拒绝理由/下架理由，无上架时间则是拒绝理由，有上架时间则是下架理由	String	券过期或失效,系统下架!!
        /// </summary>
        [JsonProperty("refuseReason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// consumptionCoupon	消费点券	String	100
        /// </summary>
        [JsonProperty("consumptionCoupon")]
        public string ConsumptionCoupon { get; set; }

        /// <summary>
        /// userId	用户id	String	688412
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// note	备注	String	“没有备注”
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// shelfTime	提交时间	Date	“2019-03-09T07:43:38”
        /// </summary>
        [JsonProperty("shelfTime")]
        public string ShelfTime { get; set; }

        /// <summary>
        /// monthSales	销量	Number	52358
        /// </summary>
        [JsonProperty("monthSales")]
        public long? MonthSales { get; set; }

        /// <summary>
        /// commissionRate	佣金比例	Number	20
        /// </summary>
        [JsonProperty("commissionRate")]
        public float? CommissionRate { get; set; }

        /// <summary>
        /// couponReceiveNum	领券量	Number	3000
        /// </summary>
        [JsonProperty("couponReceiveNum")]
        public long? CouponReceiveNum { get; set; }

        /// <summary>
        /// shelfStatus	上下架状态，默认为1，1-未下架商品，0-已下架商品	Number	0
        /// </summary>
        [JsonProperty("shelfStatus")]
        public long? ShelfStatus { get; set; }

    }
}
