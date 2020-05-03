using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetTbServiceResponse
    {
        /// <summary>
        /// title	商品信息-商品标题	String	毛呢阔腿裤港味复古女裤子秋冬九分裤萝卜裤显瘦高腰韩版2017新款
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// volume	商品信息-30天销量	Number	123
        /// </summary>
        [JsonProperty("volume")]
        public long? Volume { get; set; }

        /// <summary>
        /// nick	店铺信息-卖家昵称	String	旗舰店
        /// </summary>
        [JsonProperty("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// coupon_start_time	优惠券信息-优惠券开始时间	String	2017-10-29
        /// </summary>
        [JsonProperty("coupon_start_time")]
        public string CouponStartTime { get; set; }

        /// <summary>
        /// coupon_end_time	优惠券信息-优惠券结束时间	String	2017-10-29
        /// </summary>
        [JsonProperty("coupon_end_time")]
        public string CouponEndTime { get; set; }

        /// <summary>
        /// tk_total_sales	商品信息-淘客30天推广量	String	11
        /// </summary>
        [JsonProperty("tk_total_sales")]
        public long? TkTotalSales { get; set; }

        /// <summary>
        /// coupon_id	优惠券信息-优惠券id	String	d62db1ab8d9546b1bf0ff49bda5fc33b
        /// </summary>
        [JsonProperty("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// pict_url	商品信息-商品主图	String	https://img.alicdn.com/bao/uploaded/i4/745957850/TB1WzSRmV9gSKJjSspbXXbeNXXa_!!0-item_pic.jpg
        /// </summary>
        [JsonProperty("pict_url")]
        public string PictUrl { get; set; }

        /// <summary>
        /// small_images	商品信息-商品小图列表	String[]	https://img.alicdn.com/i4/3077291146/TB2NA3poDnI8KJjSszgXXc8ApXa_!!3077291146.jpg
        /// </summary>
        [JsonProperty("small_images")]
        public ItemSmallImages SmallImages { get; set; }

        /// <summary>
        /// reserve_price	商品信息-商品一口价格	String	102.00
        /// </summary>
        [JsonProperty("reserve_price")]
        public float? ReservePrice { get; set; }

        /// <summary>
        /// zk_final_price	商品信息-商品折扣价格	String	88.00
        /// </summary>
        [JsonProperty("zk_final_price")]
        public float? ZkFinalPrice { get; set; }

        /// <summary>
        /// user_type	店铺信息-卖家类型，0-表示集市，1-表示天猫	Number	1
        /// </summary>
        [JsonProperty("user_type")]
        public long? UserType { get; set; }

        /// <summary>
        /// seller_id	店铺信息-卖家id	Number	232332
        /// </summary>
        [JsonProperty("seller_id")]
        public long? SellerId { get; set; }

        /// <summary>
        /// coupon_total_count	优惠券信息-优惠券总量	Number	22323
        /// </summary>
        [JsonProperty("coupon_total_count")]
        public long? CouponTotalCount { get; set; }

        /// <summary>
        /// coupon_remain_count	优惠券信息-优惠券剩余量	Number	111
        /// </summary>
        [JsonProperty("coupon_remain_count")]
        public long? CouponRemainCount { get; set; }

        /// <summary>
        /// coupon_info	优惠券信息-优惠券满减信息	String	满299元减20元
        /// </summary>
        [JsonProperty("coupon_info")]
        public string CouponInfo { get; set; }

        /// <summary>
        /// shop_title	店铺信息-店铺名称	String	xx旗舰店
        /// </summary>
        [JsonProperty("shop_title")]
        public string ShopTitle { get; set; }

        /// <summary>
        /// shop_dsr	店铺信息-店铺dsr评分	Number	13
        /// </summary>
        [JsonProperty("shop_dsr")]
        public float? ShopDsr { get; set; }

        /// <summary>
        /// level_one_category_name	商品信息-一级类目名称	String	女装
        /// </summary>
        [JsonProperty("level_one_category_name")]
        public string LevelOneCategoryName { get; set; }

        /// <summary>
        /// level_one_category_id	商品信息-一级类目ID	Number	20
        /// </summary>
        [JsonProperty("level_one_category_id")]
        public long? LevelOneCategoryId { get; set; }

        /// <summary>
        /// category_name	商品信息-叶子类目名称	String	连衣裙
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// category_id	商品信息-叶子类目id	Number	162201
        /// </summary>
        [JsonProperty("category_id")]
        public long? CategoryId { get; set; }

        /// <summary>
        /// short_title	商品信息-商品短标题	String	xxsd
        /// </summary>
        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        /// <summary>
        /// white_image	商品信息-商品白底图	String	https://img.alicdn.com/bao/uploaded/i4/745957850/TB1WzSRmV9gSKJjSspbXXbeNXXa\_!!0-item_pic.jpg
        /// </summary>
        [JsonProperty("white_image")]
        public string WhiteImage { get; set; }

        /// <summary>
        /// coupon_start_fee	优惠券信息-优惠券起用门槛	String	满X元可用。如：满299元减20元
        /// </summary>
        [JsonProperty("coupon_start_fee")]
        public string CouponStartFee { get; set; }

        /// <summary>
        /// coupon_amount	优惠券信息-优惠券面额	String	如：满299元减20元
        /// </summary>
        [JsonProperty("coupon_amount")]
        public string CouponAmount { get; set; }

        /// <summary>
        /// item_description	商品信息-宝贝描述(推荐理由)	String	季凉被 全棉亲肤
        /// </summary>
        [JsonProperty("item_description")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// item_id	商品信息-宝贝id	Number	5678899993
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// commission_rate	佣金比例	Number	5
        /// </summary>
        [JsonProperty("commission_rate")]
        public float? CommissionRate { get; set; }

        /// <summary>
        /// ysyl_tlj_face	预估淘礼金	Number	5
        /// </summary>
        [JsonProperty("ysyl_tlj_face")]
        public float? YsylTljFace { get; set; }

        /// <summary>
        /// presale_deposit	预售定金	Number	5
        /// </summary>
        [JsonProperty("presale_deposit")]
        public float? PreSaleDeposit { get; set; }

        /// <summary>
        /// presale_discount_fee_text	定金立减	String	预售立减30
        /// </summary>
        [JsonProperty("presale_discount_fee_text")]
        public string PreSaleDiscountFeeText { get; set; }

        public class ItemSmallImages
        {
            [JsonProperty("string")]
            public string[] String { get; set; }
        }
    }
}
