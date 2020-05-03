using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.Partial
{
    public class GoodItemPartial
    {
        ///<summary> 
        ///id 商品id	Number	18926311
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        ///<summary> 
        ///goodsId 淘宝商品id	String	“589284195570”
        ///</summary>
        [JsonProperty("goodsId")]
        public string GoodsId { get; set; }

        ///<summary> 
        ///itemLink 商品淘宝链接	String	“https://detail.tmall.com/item.htm?id=589284195570“
        ///</summary>
        [JsonProperty("itemLink")]
        public string ItemLink { get; set; }

        ///<summary> 
        ///title 淘宝标题	String	“西维里男士睡衣夏季韩版真丝短袖丝绸薄款宽松青年冰丝家居服套装”
        ///</summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        ///<summary> 
        ///dtitle 大淘客短标题	String	“夏季睡衣男冰丝短袖丝绸家居服套装”
        ///</summary>
        [JsonProperty("dtitle")]
        public string DTitle { get; set; }

        ///<summary> 
        ///desc 推广文案	String	“宽松舒适，难以磨损典，雅而优美，倍感丝滑，质感优越，庄严而心仪，简约设计，色调清新脱俗，适合各种场合”
        ///</summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        ///<summary> 
        ///cid 商品在大淘客的分类id	Number	10
        ///</summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }

        ///<summary> 
        ///subcid 商品在大淘客的二级分类id，该分类为前端分类，一个商品可能有多个二级分类id	List[Number]	[86369,90723]
        ///</summary>
        [JsonProperty("subcid")]
        public long[] SubCid { get; set; }

        ///<summary> 
        ///tbcid 商品在淘宝的分类id	Number	50012772
        ///</summary>
        [JsonProperty("tbcid")]
        public long? TbCid { get; set; }

        ///<summary> 
        ///mainPic 商品主图链接	String	“img.alicdn.com/imgextra/i2/4014489195/O1CN01kYlVPs2HnMKYwLLRm_!!4014489195.jpg”
        ///</summary>
        [JsonProperty("mainPic")]
        public string MainPic { get; set; }

        ///<summary> 
        ///marketingMainPic 营销主图链接	String	“https://sr.ffquan.com/super_pic/o_1d6fpckjs1ii3h9dkibk9b7h38.jpg“
        ///</summary>
        [JsonProperty("marketingMainPic")]
        public string MarketingMainPic { get; set; }

        ///<summary> 
        ///originalPrice 商品原价	Number	38.5
        ///</summary>
        [JsonProperty("originalPrice")]
        public float? OriginalPrice { get; set; }

        ///<summary> 
        ///actualPrice 券后价	Number	28.5
        ///</summary>
        [JsonProperty("actualPrice")]
        public float? ActualPrice { get; set; }

        ///<summary> 
        ///discounts 折扣力度	Number	0.74
        ///</summary>
        [JsonProperty("discounts")]
        public float? Discounts { get; set; }

        ///<summary> 
        ///commissionType 佣金类型，0-通用，1-定向，2-高佣，3-营销计划	Number	3
        ///</summary>
        [JsonProperty("commissionType")]
        public long? CommissionType { get; set; }

        ///<summary> 
        ///commissionRate 佣金比例	Number	20
        ///</summary>
        [JsonProperty("commissionRate")]
        public float? CommissionRate { get; set; }

        ///<summary> 
        ///couponLink 优惠券链接	String	“https://uland.taobao.com/quan/detail?sellerId=4014489195&activityId=df6c5ba6aa6d4f21a303b50cca2f4a45“
        ///</summary>
        [JsonProperty("couponLink")]
        public string CouponLink { get; set; }

        ///<summary> 
        ///couponTotalNum 券总量	Number	7000
        ///</summary>
        [JsonProperty("couponTotalNum")]
        public long? CouponTotalNum { get; set; }

        ///<summary> 
        ///couponReceiveNum 领券量	Number	1000
        ///</summary>
        [JsonProperty("couponReceiveNum")]
        public long? CouponReceiveNum { get; set; }

        ///<summary> 
        ///couponEndTime 优惠券结束时间	String	“2019-04-08 23:59:59”
        ///</summary>
        [JsonProperty("couponEndTime")]
        public string CouponEndTime { get; set; }

        ///<summary> 
        ///couponStartTime 优惠券开始时间	String	“2019-04-01 00:00:00”
        ///</summary>
        [JsonProperty("couponStartTime")]
        public string CouponStartTime { get; set; }

        ///<summary> 
        ///couponPrice 优惠券金额	Number	10
        ///</summary>
        [JsonProperty("couponPrice")]
        public float? CouponPrice { get; set; }

        ///<summary> 
        ///couponConditions 优惠券使用条件	String	“38”
        ///</summary>
        [JsonProperty("couponConditions")]
        public string CouponConditions { get; set; }

        ///<summary> 
        ///monthSales 30天销量	Number	1030
        ///</summary>
        [JsonProperty("monthSales")]
        public long? MonthSales { get; set; }

        ///<summary> 
        ///twoHoursSales 2小时销量	Number	30
        ///</summary>
        [JsonProperty("twoHoursSales")]
        public long? TwoHoursSales { get; set; }

        ///<summary> 
        ///dailySales 当日销量	Number	20
        ///</summary>
        [JsonProperty("dailySales")]
        public long? DailySales { get; set; }

        ///<summary> 
        ///brand 是否是品牌商品	Number	4
        ///</summary>
        [JsonProperty("brand")]
        public long? Brand { get; set; }

        ///<summary> 
        ///brandId 品牌id	Number	2301323020
        ///</summary>
        [JsonProperty("brandId")]
        public long? BrandId { get; set; }

        ///<summary> 
        ///brandName 品牌名称	String	“西维里”
        ///</summary>
        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        ///<summary> 
        ///createTime 商品上架时间	String	“2019-03-29 10:00:06”
        ///</summary>
        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        ///<summary> 
        ///tchaoshi 是否天猫超市商品，1-天猫超市商品，0-非天猫超市商品	Number	0
        ///</summary>
        [JsonProperty("tchaoshi")]
        public long? TChaoShi { get; set; }

        ///<summary> 
        ///activityType 活动类型，1-无活动，2-淘抢购，3-聚划算	Number	1
        ///</summary>
        [JsonProperty("activityType")]
        public long? ActivityType { get; set; }

        ///<summary> 
        ///activityStartTime 活动开始时间	String	“2019-03-29 10:00:06”
        ///</summary>
        [JsonProperty("activityStartTime")]
        public string ActivityStartTime { get; set; }

        ///<summary> 
        ///activityEndTime 活动结束时间	String	“2019-04-29 10:00:06”
        ///</summary>
        [JsonProperty("activityEndTime")]
        public string ActivityEndTime { get; set; }

        ///<summary> 
        ///shopType 店铺类型，1-天猫，0-淘宝	Number	1
        ///</summary>
        [JsonProperty("shopType")]
        public long? ShopType { get; set; }

        ///<summary> 
        ///haitao 是否海淘，1-海淘商品，0-非海淘商品	Number	0
        ///</summary>
        [JsonProperty("haitao")]
        public long? HaiTao { get; set; }

        ///<summary> 
        ///goldSellers 是否金牌卖家，1-金牌卖家，0-非金牌卖家	Number	0
        ///</summary>
        [JsonProperty("goldSellers")]
        public long? GoldSellers { get; set; }

        ///<summary> 
        ///sellerId 淘宝卖家id	String	“4014489195”
        ///</summary>
        [JsonProperty("sellerId")]
        public string SellerId { get; set; }

        ///<summary> 
        ///shopName 店铺名称	String	“西维里旗舰店”
        ///</summary>
        [JsonProperty("shopName")]
        public string ShopName { get; set; }

        ///<summary> 
        ///shopLevel 淘宝店铺等级	Number	11
        ///</summary>
        [JsonProperty("shopLevel")]
        public long? ShopLevel { get; set; }

        ///<summary> 
        ///descScore 描述分	Number	4.8
        ///</summary>
        [JsonProperty("descScore")]
        public float? DescScore { get; set; }

        ///<summary> 
        ///dsrScore 描述相符	Number	4.8
        ///</summary>
        [JsonProperty("dsrScore")]
        public float? DsrScore { get; set; }

        ///<summary> 
        ///dsrPercent 描述同行比	Number	0.0
        ///</summary>
        [JsonProperty("dsrPercent")]
        public float? DsrPercent { get; set; }

        ///<summary> 
        ///shipScore 服务态度	Number	4.8
        ///</summary>
        [JsonProperty("shipScore")]
        public float? ShipScore { get; set; }

        ///<summary> 
        ///shipPercent 服务同行比	Number	10.32
        ///</summary>
        [JsonProperty("shipPercent")]
        public float? ShipPercent { get; set; }

        ///<summary> 
        ///serviceScore 物流服务	Number	4.8
        ///</summary>
        [JsonProperty("serviceScore")]
        public float? ServiceScore { get; set; }

        ///<summary> 
        ///servicePercent 物流同行比	Number	5.82
        ///</summary>
        [JsonProperty("servicePercent")]
        public float? ServicePercent { get; set; }

        ///<summary> 
        ///hotPush 热推值	Number	456
        ///</summary>
        [JsonProperty("hotPush")]
        public long? HotPush { get; set; }

        ///<summary> 
        ///teamName 放单人名称	String	“阿甘团队”
        ///</summary>
        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        ///<summary> 
        ///quanMLink 定金，若无定金，则显示0	Number	10
        ///</summary>
        [JsonProperty("quanMLink")]
        public float? QuanMLink { get; set; }

        ///<summary> 
        ///hzQuanOver 立减，若无立减金额，则显示0	Number	100
        ///</summary>
        [JsonProperty("hzQuanOver")]
        public float? HzQuanOver { get; set; }

        ///<summary> 
        ///yunfeixian 0.不包运费险 1.包运费险	Number	1
        ///</summary>
        [JsonProperty("yunfeixian")]
        public long? YunFeiXian { get; set; }

        ///<summary> 
        ///estimateAmount 预估淘礼金	Number	25.2
        ///</summary>
        [JsonProperty("estimateAmount")]
        public float? EstimateAmount { get; set; }

        ///<summary> 
        ///shopLogo 店铺logo	String	https://img.alicdn.com/imgextra//59/df/TB1lJVxNFXXXXcoXFXXSutbFXXX.jpg
        ///</summary>
        [JsonProperty("shopLogo")]
        public string ShopLogo { get; set; }

        ///<summary> 
        ///specialText 特色文案	List	
        ///</summary>
        [JsonProperty("specialText")]
        public string[] SpecialText { get; set; }

        ///<summary> 
        ///freeshipRemoteDistrict 偏远地区包邮，0.不包邮，1.包邮	Number	1
        ///</summary>
        [JsonProperty("freeshipRemoteDistrict")]
        public long? FreeShipRemoteDistrict { get; set; }
    }
}
