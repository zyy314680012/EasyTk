using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response.Partial
{
    public abstract class GoodItemPartial
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
        ///string	南极人魅金创意不锈钢垃圾桶家用卫生间客厅卧室脚踏式厕所带盖筒	宝贝标题
        ///</summary>
        [JsonProperty("itemtitle")]
        public string ItemTitle { get; set; }

        ///<summary> 
        ///string	南极人家用卫生间客厅垃圾袋60个	宝贝短标题
        ///</summary>
        [JsonProperty("itemshorttitle")]
        public string ItemShortTitle { get; set; }

        ///<summary> 
        ///string	南极人加厚垃圾袋60支，采用高强度PE新材料韧性足、无异味、承重佳、封底结实不易漏，避免烂袋尴尬，千万家庭的选择，抢到就是赚！【送运费险】	宝贝推荐语
        ///</summary>
        [JsonProperty("itemdesc")]
        public string ItemDesc { get; set; }

        ///<summary> 
        ///float	8.10	在售价
        ///</summary>
        [JsonProperty("itemprice")]
        public float? ItemPrice { get; set; }

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
        ///string	https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg	宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        ///</summary>
        [JsonProperty("itempic")]
        public string ItemPic { get; set; }

        ///<summary> 
        ///string	0_553757100845_1509175123.jpg	推广长图（带http://img.haodanku.com/0_553757100845_1509175123.jpg-600进行访问）
        ///</summary>
        [JsonProperty("itempic_copy")]
        public string ItemPicCopy { get; set; }

        ///<summary> 
        ///string	https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg	轮播主图，用英文逗号分隔开来（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        ///</summary>
        [JsonProperty("taobao_image")]
        public string TaoBaoImage { get; set; }

        ///<summary> 
        ///integer	10	商品类目：
        /// 1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        ///</summary>
        [JsonProperty("fqcat")]
        public long? FqCat { get; set; }


        ///<summary> 
        ///float	3.10	宝贝券后价
        ///</summary>
        [JsonProperty("itemendprice")]
        public float? ItemEndPrice { get; set; }

        ///<summary> 
        ///string	B	店铺类型： 天猫店（B） 淘宝店（C）
        ///</summary>
        [JsonProperty("shoptype")]
        public string ShopType { get; set; }

        ///<summary> 
        ///string	https://uland.taobao.com/quan/detail??sellerId=3162813958&amp;activityId=1d5771905a774f01ad345d26ad8a55b2	优惠券链接
        ///</summary>
        [JsonProperty("couponurl")]
        public string CouponUrl { get; set; }

        ///<summary> 
        ///float	5.6	优惠券金额
        ///</summary>
        [JsonProperty("couponmoney")]
        public float? CouponMoney { get; set; }

        ///<summary> 
        ///integer	0	是否为品牌产品（1是）
        ///</summary>
        [JsonProperty("is_brand")]
        public int? IsBrand { get; set; }

        ///<summary> 
        ///integer	0	是否为直播（1是）
        ///</summary>
        [JsonProperty("is_live")]
        public int? IsLive { get; set; }

        ///<summary> 
        ///string	南极人加厚垃圾袋60支，采用高强度PE新材料韧性足、无异味、承重佳、封底结实不易漏，避免烂袋尴尬，千万家庭的选择，抢到就是赚！【送运费险】	推广导购文案
        ///</summary>
        [JsonProperty("guide_article")]
        public string GuideArticle { get; set; }

        ///<summary> 
        ///integer	0	商品视频ID（id大于0的为有视频单，视频拼接地址http://cloud.video.taobao.com/play/u/1/p/1/e/6/t/1/+videoid+.mp4）
        ///</summary>
        [JsonProperty("videoid")]
        public long? VideoId { get; set; }

        ///<summary> 
        ///string	普通活动	活动类型：普通活动 聚划算 淘抢购
        ///</summary>
        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        ///<summary> 
        ///string	https://s.click.taobao.com/KjSknfw	营销计划链接
        ///</summary>
        [JsonProperty("planlink")]
        public string PlanLink { get; set; }

        ///<summary> 
        ///integer	3162813958	店主的userid
        ///</summary>
        [JsonProperty("userid")]
        public long? UserId { get; set; }

        ///<summary> 
        ///string	南极人唯欲专卖店	店铺掌柜名
        ///</summary>
        [JsonProperty("sellernick")]
        public string SellerNick { get; set; }

        ///<summary> 
        ///string	南极人唯欲专卖店	店铺名
        ///</summary>
        [JsonProperty("shopname")]
        public string ShopName { get; set; }

        ///<summary> 
        ///string	营销计划	佣金计划：隐藏 营销
        ///</summary>
        [JsonProperty("tktype")]
        public string TkType { get; set; }

        ///<summary> 
        ///float	70.50	佣金比例
        ///</summary>
        [JsonProperty("tkrates")]
        public float? TkRates { get; set; }

        ///<summary> 
        ///integer	0	是否村淘（1是）
        ///</summary>
        [JsonProperty("cuntao")]
        public int? CunTao { get; set; }

        ///<summary> 
        ///float	2.19	预计可得（宝贝价格 * 佣金比例 / 100）
        ///</summary>
        [JsonProperty("tkmoney")]
        public float? TkMoney { get; set; }

        ///<summary> 
        ///integer	0	当天优惠券领取量
        ///</summary>
        [JsonProperty("couponreceive2")]
        public long? CouponReceive2 { get; set; }

        ///<summary> 
        ///integer	100000	优惠券剩余量
        ///</summary>
        [JsonProperty("couponsurplus")]
        public long? CouponSurplus { get; set; }

        ///<summary> 
        ///integer	100000	优惠券总数量
        ///</summary>
        [JsonProperty("couponnum")]
        public long? CouponNum { get; set; }

        ///<summary> 
        ///string	单笔满8元可用	优惠券使用条件
        ///</summary>
        [JsonProperty("couponexplain")]
        public string CouponExPlain { get; set; }

        ///<summary> 
        ///integer	1509120000	优惠券开始时间
        ///</summary>
        [JsonProperty("couponstarttime")]
        public long? CouponStartTime { get; set; }

        ///<summary> 
        ///integer	1509292799	优惠券结束时间
        ///</summary>
        [JsonProperty("couponendtime")]
        public long? CouponEndTime { get; set; }

        ///<summary> 
        ///integer	1509174000	活动开始时间
        ///</summary>
        [JsonProperty("start_time")]
        public long? StartTime { get; set; }

        ///<summary> 
        ///integer	1509292799	活动结束时间
        ///</summary>
        [JsonProperty("end_time")]
        public long? EndTime { get; set; }

        ///<summary> 
        ///integer	1509174000	发布时间
        ///</summary>
        [JsonProperty("starttime")]
        public long? PublishTime { get; set; }

        ///<summary> 
        ///integer	0	举报处理条件 0未举报 1为待处理 2为忽略 3为下架
        ///</summary>
        [JsonProperty("report_status")]
        public long ReportStatus { get; set; }

        ///<summary> 
        ///integer	344	好单指数
        ///</summary>
        [JsonProperty("general_index")]
        public long GeneralIndex { get; set; }

        ///<summary> 
        ///string	若梦****追梦	放单人名号
        ///</summary>
        [JsonProperty("seller_name")]
        public string SellerName { get; set; }

        ///<summary> 
        ///float	5.0	折扣力度
        ///</summary>
        [JsonProperty("discount")]
        public float? DisCount { get; set; }

        ///<summary> 
        ///float	5.0	双十一定金
        ///</summary>
        [JsonProperty("deposit")]
        public float? Deposit { get; set; }

        ///<summary> 
        ///float	5.0	双十一定金抵扣金额
        ///</summary>
        [JsonProperty("deposit_deduct")]
        public float? DepositDeduct { get; set; }

        ///<summary> 
        ///integer	0	是否包邮商品：1为是
        ///</summary>
        [JsonProperty("is_shipping")]
        public int? IsShipping { get; set; }
    }
}
