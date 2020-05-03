using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetPrivilegeLinkResponse
    {
        /// <summary>
        /// couponClickUrl	商品优惠券推广链接	String	https://uland.taobao.com/coupon/edetail?e=nqUNB1NOF3Bt3vqbdXnGloankzPYmeEFkgNrw6YHQf9pZTj41Orn8MwBAs06HAOzqQomYNedOiHDYPmqkFXqLR0HgBdG%2FDDL%2F1M%2FBw7Sf%2FesGXLf%2BqX4cbeC%2F2cR0p0NlWH0%2BknxpnCJJP%2FQkZSsyo1HvKjXo4uz&pid=mm_26381042_12970066_52864659&af=1
        /// </summary>
        [JsonProperty("couponClickUrl")]
        public string CouponClickUrl { get; set; }

        /// <summary>
        /// couponEndTime	优惠券结束时间	String	2016-09-26
        /// </summary>
        [JsonProperty("couponEndTime")]
        public string CouponEndTime { get; set; }

        /// <summary>
        /// couponInfo	优惠券面额	String	满16元减10元
        /// </summary>
        [JsonProperty("couponInfo")]
        public string CouponInfo { get; set; }

        /// <summary>
        /// couponStartTime	优惠券开始时间	String	2016-09-25
        /// </summary>
        [JsonProperty("couponStartTime")]
        public string CouponStartTime { get; set; }

        /// <summary>
        /// itemId	商品id	Number	524136796550
        /// </summary>
        [JsonProperty("itemId")]
        public long ItemId { get; set; }

        /// <summary>
        /// couponTotalCount	优惠券总量	Number	8000
        /// </summary>
        [JsonProperty("couponTotalCount")]
        public long? CouponTotalCount { get; set; }

        /// <summary>
        /// couponRemainCount	优惠券剩余量	Number	6859
        /// </summary>
        [JsonProperty("couponRemainCount")]
        public long? CouponRemainCount { get; set; }

        /// <summary>
        /// itemUrl	商品淘客链接	String	https://s.click.taobao.com/t?spm=a2e2e.10720394/c.90202110.1.4399704cUUhhH0&e=m%3D2%26s%3D0NJS731SUEdw4vFB6t2Z2ueEDrYVVa64LKpWJ%2Bin0XLjf2vlNIV67uIA4kDYDopEpOjgxi0uT208hw4H8GMUew7uoRPWrIBwR7CIpaNCoiKr9WTFywb%2BCtGNFs53xi4QGSKqJrqeJvt5ArodCWjzv9fsai3uVirbXH%2BQH9e66Y4%3D
        /// </summary>
        [JsonProperty("itemUrl")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// tpwd	淘口令	String	￥vpZTYeQ3RtO￥
        /// </summary>
        [JsonProperty("tpwd")]
        public string TPwd { get; set; }

        /// <summary>
        /// maxCommissionRate	佣金比例	Number	20
        /// </summary>
        [JsonProperty("maxCommissionRate")]
        public float? MaxCommissionRate { get; set; }

        /// <summary>
        /// shortUrl	短链接	String	https://s.click.taobao.com/xaulr5w
        /// </summary>
        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

    }
}
