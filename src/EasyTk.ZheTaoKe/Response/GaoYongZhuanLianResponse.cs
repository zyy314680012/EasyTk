using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace EasyTk.ZheTaoKe.Response
{
    public class GaoYongZhuanLianResponse : BaseResponse
    {
    }

    public class GaoYongZhuanLianTbkPrivilegeGetResponse : GaoYongZhuanLianResponse
    {
        [JsonProperty("tbk_privilege_get_response")]
        public TbkPrivilegeData Data { get; set; }

        public class TbkPrivilegeData
        {
            [JsonProperty("result")]
            public TbkPrivilegeDataResult Result { get; set; }

            [JsonProperty("request_id")]
            public string RequestId { get; set; }
        }

        public class TbkPrivilegeDataResult
        {
            [JsonProperty("data")]
            public TbkPrivilegeDataResultData Data { get; set; }
        }

        public class TbkPrivilegeDataResultData
        {
            [JsonProperty("category_id")]
            public long? CategoryId { get; set; }

            [JsonProperty("coupon_click_url")]
            public string CouponClickUrl { get; set; }

            [JsonProperty("coupon_end_time")]
            public string CouponEndTime { get; set; }

            [JsonProperty("coupon_info")]
            public string CouponInfo { get; set; }

            [JsonProperty("coupon_remain_count")]
            public long? CouponRemainCount { get; set; }

            [JsonProperty("coupon_start_time")]
            public string CouponStartTime { get; set; }

            [JsonProperty("coupon_total_count")]
            public long? CouponTotalCount { get; set; }

            [JsonProperty("coupon_type")]
            public long? CouponType { get; set; }

            [JsonProperty("item_id")]
            public long ItemId { get; set; }

            [JsonProperty("item_url")]
            public string ItemUrl { get; set; }

            [JsonProperty("max_commission_rate")]
            public string MaxCommissionRate { get; set; }


            [JsonProperty("s_coupon_id")]
            public string SCouponId { get; set; }

            [JsonProperty("s_coupon_amount")]
            public float? SCouponAmount { get; set; }

            [JsonProperty("s_coupon_startfee")]
            public float? SCouponStartFee { get; set; }

            [JsonProperty("s_coupon_start_time")]
            public DateTime? SCouponStartTime { get; set; }

            [JsonProperty("s_coupon_end_time")]
            public DateTime? SCouponEndTime { get; set; }


            [JsonProperty("cat_leaf_name")]
            public string CatLeafName { get; set; }

            [JsonProperty("cat_name")]
            public string CatName { get; set; }

            [JsonProperty("nick")]
            public string Nick { get; set; }

            [JsonProperty("pict_url")]
            public string PictUrl { get; set; }

            [JsonProperty("provcity")]
            public string ProvCity { get; set; }

            [JsonProperty("seller_id")]
            public string SellerId { get; set; }

            [JsonProperty("small_images")]
            public string SmallImages { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("user_type")]
            public long? UserType { get; set; }

            [JsonProperty("volume")]
            public long? Volume { get; set; }

            [JsonProperty("zk_final_price")]
            public float? ZkFinalPrice { get; set; }

            [JsonProperty("tkl")]
            public string Tkl { get; set; }
        }
    }

    public class GaoYongZhuanLianOnlyUrlResponse : GaoYongZhuanLianResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GaoYongZhuanLianFullInfoResponse : GaoYongZhuanLianResponse
    {
        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("content")]
        public GaoYongZhuanLianFullInfoData[] Content { get; set; }

        public class GaoYongZhuanLianFullInfoData
        {
            [JsonProperty("code")]
            public long? Code { get; set; }

            [JsonProperty("type_one_id")]
            public long? TypeOneId { get; set; }

            [JsonProperty("tao_id")]
            public long? TaoId { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("jianjie")]
            public string JianJie { get; set; }

            [JsonProperty("pict_url")]
            public string PictUrl { get; set; }

            /// <summary>
            /// 0是淘宝，1是天猫
            /// </summary>
            [JsonProperty("user_type")]
            public long? UserType { get; set; }

            /// <summary>
            ///  /*卖家ID*/ /*店铺地址可自行拼接，http://store.taobao.com/shop/view_shop.htm?user_number_id=3073204721 */
            /// </summary>
            [JsonProperty("seller_id")]
            public long? SellerId { get; set; }

            [JsonProperty("shop_dsr")]
            public float? ShopDsr { get; set; }

            /// <summary>
            /// 月销量
            /// </summary>
            [JsonProperty("volume")]
            public long? Volume { get; set; }

            /// <summary>
            /// 折扣价
            /// </summary>
            [JsonProperty("size")]
            public float? Size { get; set; }

            /// <summary>
            /// 券后价
            /// </summary>
            [JsonProperty("quanhou_jiage")]
            public float? QuanHouJiage { get; set; }

            /// <summary>
            /// 数据更新时间
            /// </summary>
            [JsonProperty("date_time_yongjin")]
            public DateTime? DateTimeYongjin { get; set; }

            /// <summary>
            /// 佣金比率
            /// </summary>
            [JsonProperty("tkrate3")]
            public string Tkrate3 { get; set; }

            /// <summary>
            /// 佣金类型
            /// </summary>
            [JsonProperty("yongjin_type")]
            public string YongJinType { get; set; }

            [JsonProperty("coupon_id")]
            public string CouponId { get; set; }

            /// <summary>
            /// 优惠券开始时间
            /// </summary>
            [JsonProperty("coupon_start_time")]
            public DateTime? CouponStartTime { get; set; }

            /// <summary>
            /// 优惠券结束时间
            /// </summary>
            [JsonProperty("coupon_end_time")]
            public DateTime? CouponEndTime { get; set; }

            /// <summary>
            /// 优惠券金额
            /// </summary>
            [JsonProperty("coupon_info_money")]
            public float? CouponInfoMoney { get; set; }

            /// <summary>
            /// 优惠券总数量
            /// </summary>
            [JsonProperty("coupon_total_count")]
            public long? CouponTotalCount { get; set; }

            /// <summary>
            /// 优惠券剩余数量
            /// </summary>
            [JsonProperty("coupon_remain_count")]
            public long? CouponRemainCount { get; set; }

            [JsonProperty("coupon_info")]
            public string CouponInfo { get; set; }

            /// <summary>
            /// 是否聚划算，1是
            /// </summary>
            [JsonProperty("juhuasuan")]
            public int? JuHuaSuan { get; set; }

            /// <summary>
            /// 是否淘抢购，1是
            /// </summary>
            [JsonProperty("taoqianggou")]
            public int? TaoQiangQou { get; set; }

            /// <summary>
            /// 是否海淘，1是
            /// </summary>
            [JsonProperty("haitao")]
            public int? HaiTao { get; set; }

            /// <summary>
            /// 是否极有家，1是
            /// </summary>
            [JsonProperty("jiyoujia")]
            public int? JiYouJia { get; set; }

            /// <summary>
            /// 是否金牌卖家，1是
            /// </summary>
            [JsonProperty("jinpaimaijia")]
            public int? JinPaiMaiJia { get; set; }

            /// <summary>
            /// 是否精选品牌，1是
            /// </summary>
            [JsonProperty("pinpai")]
            public int? PinPai { get; set; }

            /// <summary>
            /// 品牌名称
            /// </summary>
            [JsonProperty("pinpai_name")]
            public string PinPaiName { get; set; }

            /// <summary>
            /// 是否有运费险，1有
            /// </summary>
            [JsonProperty("yunfeixian")]
            public int? YunFeiXian { get; set; }

            [JsonProperty("nick")]
            public string Nick { get; set; }

            [JsonProperty("small_images")]
            public string SmallImages { get; set; }

            [JsonProperty("white_image")]
            public string WhiteImage { get; set; }

            [JsonProperty("tao_title")]
            public string TaoTitle { get; set; }

            [JsonProperty("provcity")]
            public string ProvCity { get; set; }

            [JsonProperty("shop_title")]
            public string ShopTitle { get; set; }

            /// <summary>
            /// 视频地址
            /// </summary>
            [JsonProperty("zhibo_url")]
            public string ZhiBoUrl { get; set; }

            /// <summary>
            /// 淘宝网页实时总销量
            /// </summary>
            [JsonProperty("sellCount")]
            public long? SellCount { get; set; }

            /// <summary>
            /// 评论数量
            /// </summary>
            [JsonProperty("commentCount")]
            public long? CommentCount { get; set; }

            /// <summary>
            /// 收藏数量
            /// </summary>
            [JsonProperty("favcount")]
            public long? FavCount { get; set; }

            /// <summary>
            /// 宝贝描述分
            /// </summary>
            [JsonProperty("score1")]
            public float? Score1 { get; set; }

            /// <summary>
            /// 卖家服务分
            /// </summary>
            [JsonProperty("score2")]
            public float? Score2 { get; set; }

            /// <summary>
            /// 物流服务分
            /// </summary>
            [JsonProperty("score3")]
            public float? Score3 { get; set; }

            /// <summary>
            /// 店铺等级（1-20），一星 二星 三星 四星 五星 一钻 二钻 三钻 四钻 五钻 一皇冠 二皇冠 三皇冠 四皇冠 五皇冠  一金冠 二金冠 三金冠 四金冠 五金冠
            /// </summary>
            [JsonProperty("creditLevel")]
            public int? CreditLevel { get; set; }

            [JsonProperty("shopIcon")]
            public string ShopIcon { get; set; }

            [JsonProperty("pcDescContent")]
            public string PcDescContent { get; set; }

            [JsonProperty("taobao_url")]
            public string TaoBaoUrl { get; set; }

            /// <summary>
            /// 叶子类目id
            /// </summary>
            [JsonProperty("category_id")]
            public long? CategoryId { get; set; }

            [JsonProperty("category_name")]
            public string CategoryName { get; set; }

            /// <summary>
            /// 一级类目id
            /// </summary>
            [JsonProperty("level_one_category_id")]
            public long? LevelOneCategoryId { get; set; }

            [JsonProperty("level_one_category_name")]
            public string LevelOneCategoryName { get; set; }

            /// <summary>
            /// 返佣金额
            /// </summary>
            [JsonProperty("tkfee3")]
            public float? TkFee3 { get; set; }

            [JsonProperty("biaoqian")]
            public string BiaoQian { get; set; }

            [JsonProperty("tag")]
            public string Tag { get; set; }

            /// <summary>
            /// 二合一推广链接，已经自动拼接S券
            /// </summary>
            [JsonProperty("coupon_click_url")]
            public string CouponClickUrl { get; set; }

            /// <summary>
            /// 推广长链接，如果是渠道ID，请自行拼接上relationId的信息,否则订单信息中可能查不到渠道信息
            /// </summary>
            [JsonProperty("item_url")]
            public string ItemUrl { get; set; }

            /// <summary>
            /// 淘口令
            /// </summary>
            [JsonProperty("tkl")]
            public string Tkl { get; set; }
        }
    }
}
