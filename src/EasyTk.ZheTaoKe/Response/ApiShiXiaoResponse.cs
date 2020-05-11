using Newtonsoft.Json;
using System;

namespace EasyTk.ZheTaoKe.Response
{
    public class ApiShiXiaoResponse
    {
        /// <summary>
        /// 原始商品编号code
        /// code": 2851915,
        /// </summary>
        [JsonProperty("code")]
        public long? Code { get; set; }

        /// <summary>
        /// id": 8333457,
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 商品编号
        /// tao_id": 616576297728,
        /// </summary>
        [JsonProperty("tao_id")]
        public long? TaoId { get; set; }

        /// <summary>
        /// 店铺seller_id
        /// seller_id": 2120743746,
        /// </summary>
        [JsonProperty("seller_id")]
        public long? SellerId { get; set; }

        /// <summary>
        /// 优惠券id
        /// activity_id": "9cf3a1c7b1384f44a10a6ecd6d469697",
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 失效原因。1:优惠券无效，2:对应宝贝已下架或非淘客宝贝，3:商品上架时间超过7天，4:商家主动下架，5:黑名单下架，6:本券金额小于官券金额 
        /// reason_type": 7,
        /// </summary>
        [JsonProperty("reason_type")]
        public string ReasonType { get; set; }

        /// <summary>
        /// 失效时间
        /// date_time": "2020/05/11 22:40:02"
        /// </summary>
        [JsonProperty("date_time")]
        public DateTime? DateTime { get; set; }

    }
}
