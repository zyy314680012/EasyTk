using System;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response.Partial
{
    public class GoodItem
    {
        #region ========================

        ///<summary> 
        ///code  "6646",                 /*折淘客编号*/
        ///</summary>
        [JsonProperty("code")]
        public long? Code { get; set; }

        ///<summary> 
        ///type_one_id  "1",             /*分类ID，可参考折淘客分类*/
        ///</summary>
        [JsonProperty("type_one_id")]
        public long? TypeOneId { get; set; }

        ///<summary> 
        ///tao_id  "554832820990",       /*商品ID*/
        ///</summary>
        [JsonProperty("tao_id")]
        public string TaoId { get; set; }

        ///<summary> 
        ///title  "储物箱整理抽屉式收纳柜",                   /*商品短标题*/
        ///</summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        ///<summary> 
        ///jianjie  "【爆款返场，出口日本】进口PP材质，可叠加透明可视抽屉收纳盒，分格抽屉物品分类齐全，区域分化一目了然，自由组合，大容量，让你居家生活更舒心，收纳你的生活！【赠运费险】", /*商品简介*/
        ///</summary>
        [JsonProperty("jianjie")]
        public string JianJie { get; set; }

        ///<summary> 
        ///pict_url  "https://img.alicdn.com/bao/......jpg",                   /*商品主图*/
        ///</summary>
        [JsonProperty("pict_url")]
        public string PictUrl { get; set; }

        ///<summary> 
        ///user_type  "0",                   /*是否天猫，0是淘宝，1是天猫*/
        ///</summary>
        [JsonProperty("user_type")]
        public long? UserType { get; set; }

        ///<summary> 
        ///seller_id  "3073204721",                   /*卖家ID*/ /*店铺地址可自行拼接，http://store.taobao.com/shop/view_shop.htm?user_number_id=3073204721 */
        ///</summary>
        [JsonProperty("seller_id")]
        public long? SellerId { get; set; }

        ///<summary> 
        ///shop_dsr  "4.80",                   /*商品描述分*/
        ///</summary>
        [JsonProperty("shop_dsr")]
        public float? ShopDsr { get; set; }

        ///<summary> 
        ///volume  "169",                   /*月销量*/
        ///</summary>
        [JsonProperty("volume")]
        public long? Volume { get; set; }

        ///<summary> 
        ///size  "26.90",                   /*折扣价*/
        ///</summary>
        [JsonProperty("size")]
        public float Size { get; set; }

        ///<summary> 
        ///quanhou_jiage  "16.90",                   /*券后价*/
        ///</summary>
        [JsonProperty("quanhou_jiage")]
        public float? QuanHouJiaGe { get; set; }

        ///<summary> 
        ///date_time_yongjin  "2018/11/8 14:45:22",                   /*数据更新时间*/
        ///</summary>
        [JsonProperty("date_time_yongjin")]
        public DateTime? DateTimeYongJin { get; set; }

        ///<summary> 
        ///tkrate3  "30.00",                   /*佣金比率*/
        ///</summary>
        [JsonProperty("tkrate3")]
        public float? TkRate3 { get; set; }

        ///<summary> 
        ///yongjin_type  "MKT",                   /*佣金类型*/
        ///</summary>
        [JsonProperty("yongjin_type")]
        public string YongJinType { get; set; }

        ///<summary> 
        ///coupon_id  "fe31d6c8132c462ba59bd72e03d2eae0",                   /*优惠券ID*/
        ///</summary>
        [JsonProperty("coupon_id")]
        public string CouponId { get; set; }

        ///<summary> 
        ///coupon_start_time  "2018-11-05",                   /*优惠券开始时间*/
        ///</summary>
        [JsonProperty("coupon_start_time")]
        public DateTime? CouponStartTime { get; set; }

        ///<summary> 
        ///coupon_end_time  "2018-11-10",                   /*优惠券结束时间*/
        ///</summary>
        [JsonProperty("coupon_end_time")]
        public DateTime? CouponEndTime { get; set; }

        ///<summary> 
        ///coupon_info_money  "10",                   /*优惠券金额*/
        ///</summary>
        [JsonProperty("coupon_info_money")]
        public float? CouponInfoMoney { get; set; }

        ///<summary> 
        ///coupon_total_count  "100000",                   /*优惠券总数量*/
        ///</summary>
        [JsonProperty("coupon_total_count")]
        public long? CouponTotalCount { get; set; }

        ///<summary> 
        ///coupon_remain_count  "99965",                   /*优惠券剩余数量*/
        ///</summary>
        [JsonProperty("coupon_remain_count")]
        public long? CouponRemainCount { get; set; }

        ///<summary> 
        ///coupon_info  "满80.00元减10元",                   /*优惠券信息*/
        ///</summary>
        [JsonProperty("coupon_info")]
        public string CouponInfo { get; set; }

        ///<summary> 
        ///juhuasuan  "0",                       /*是否聚划算，1是*/
        ///</summary>
        [JsonProperty("juhuasuan")]
        public long? JuHuaSuan { get; set; }

        ///<summary> 
        ///taoqianggou  "0",                     /*是否淘抢购，1是*/
        ///</summary>
        [JsonProperty("taoqianggou")]
        public long? TaoQiangGou { get; set; }

        ///<summary> 
        ///haitao  "0",                          /*是否海淘，1是*/
        ///</summary>
        [JsonProperty("haitao")]
        public long? HaiTao { get; set; }

        ///<summary> 
        ///jiyoujia  "0",                        /*是否极有家，1是*/
        ///</summary>
        [JsonProperty("jiyoujia")]
        public long? JiYouJia { get; set; }

        ///<summary> 
        ///jinpaimaijia  "0",                    /*是否金牌卖家，1是*/
        ///</summary>
        [JsonProperty("jinpaimaijia")]
        public long? JinPaiMaiJia { get; set; }

        ///<summary> 
        ///pinpai  "0",                          /*是否精选品牌，1是*/
        ///</summary>
        [JsonProperty("pinpai")]
        public long? PinPai { get; set; }

        ///<summary> 
        ///pinpai_name  "",                      /*品牌名称*/
        ///</summary>
        [JsonProperty("pinpai_name")]
        public string PinPaiName { get; set; }

        ///<summary> 
        ///yunfeixian  "0",                      /*是否有运费险，1有*/
        ///</summary>
        [JsonProperty("yunfeixian")]
        public long? YunFeiXian { get; set; }

        ///<summary> 
        ///nick  "***旗舰店",                    /*卖家昵称*/
        ///</summary>
        [JsonProperty("nick")]
        public string Nick { get; set; }

        ///<summary> 
        ///small_images  "https://img.alicdn.com/bao/.......jpg|https://img.alicdn.com/bao/.......jpg",                   /*商品小图列表*/
        ///</summary>
        [JsonProperty("small_images")]
        public string SmallImages { get; set; }

        ///<summary> 
        ///white_image  "https://img.alicdn.com/bao/......jpg",                   /*商品白底图*/
        ///</summary>
        [JsonProperty("white_image")]
        public string WhiteImage { get; set; }

        ///<summary> 
        ///tao_title  "抽屉式收纳箱塑料储物箱整理箱衣服物家用宿舍衣柜内衣内裤收纳盒",                   /*商品长标题*/
        ///</summary>
        [JsonProperty("tao_title")]
        public string TaoTitle { get; set; }

        ///<summary> 
        ///provcity  "浙江 杭州",                   /*宝贝所在地*/
        ///</summary>
        [JsonProperty("provcity")]
        public string ProvCity { get; set; }

        ///<summary> 
        ///shop_title  "***旗舰店",                   /*店铺名称*/
        ///</summary>
        [JsonProperty("shop_title")]
        public string ShopTitle { get; set; }

        ///<summary> 
        ///zhibo_url  "https://cloud.video.taobao.com/play/u/849090736/p/2/e/6/t/1/219853683676.mp4",                   /*视频地址*/
        ///</summary>
        [JsonProperty("zhibo_url")]
        public string ZhiBoUrl { get; set; }

        ///<summary> 
        ///sellCount  "860000",                   /*淘宝网页实时总销量*/
        ///</summary>
        [JsonProperty("sellCount")]
        public long? SellCount { get; set; }

        ///<summary> 
        ///commentCount  "250000",                   /*评论数量*/
        ///</summary>
        [JsonProperty("commentCount")]
        public long? CommentCount { get; set; }

        ///<summary> 
        ///favcount  "180000",                   /*收藏数量*/
        ///</summary>
        [JsonProperty("favcount")]
        public long? FavCount { get; set; }

        ///<summary> 
        ///score1  "4.9",                   /*宝贝描述分*/
        ///</summary>
        [JsonProperty("score1")]
        public float? Score1 { get; set; }

        ///<summary> 
        ///score2  "4.9",                   /*卖家服务分*/
        ///</summary>
        [JsonProperty("score2")]
        public float? Score2 { get; set; }

        ///<summary> 
        ///score3  "4.9",                   /*物流服务分*/
        ///</summary>
        [JsonProperty("score3")]
        public float? Score3 { get; set; }

        ///<summary> 
        ///creditLevel  "15",                   /*店铺等级（1-20），一星 二星 三星 四星 五星 一钻 二钻 三钻 四钻 五钻 一皇冠 二皇冠 三皇冠 四皇冠 五皇冠  一金冠 二金冠 三金冠 四金冠 五金冠*/
        ///</summary>
        [JsonProperty("creditLevel")]
        public long? CreditLevel { get; set; }

        ///<summary> 
        ///shopIcon  "//img.alicdn.com/imgextra/de/a6/TB10dC8SX.jpg",       /*店铺logo*/
        ///</summary>
        [JsonProperty("shopIcon")]
        public string ShopIcon { get; set; }

        ///<summary> 
        ///pcDescContent  "1.jpg|2.jpg|3.jpg|4.jpg|5.jpg",  /*图文详情图片地址*/
        ///</summary>
        [JsonProperty("pcDescContent")]
        public string PcDescContent { get; set; }

        ///<summary> 
        ///item_url  "https://item.taobao.com/item.htm?id=581801364036",  /*商品url*/
        ///</summary>
        [JsonProperty("item_url")]
        public string ItemUrl { get; set; }

        ///<summary> 
        ///category_id  "50006126",                   /*叶子类目id*/
        ///</summary>
        [JsonProperty("category_id")]
        public long? CategoryId { get; set; }

        ///<summary> 
        ///category_name  "收纳盒",                   /*叶子类目name*/
        ///</summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        ///<summary> 
        ///level_one_category_id  "122928002",                   /*一级类目id*/
        ///</summary>
        [JsonProperty("level_one_category_id")]
        public long? LevelOneCategoryId { get; set; }

        ///<summary> 
        ///level_one_category_name  "收纳整理",                   /*一级类目name*/
        ///</summary>
        [JsonProperty("level_one_category_name")]
        public string LevelOneCategoryName { get; set; }

        ///<summary> 
        ///tkfee3  "5.07",                   /*返佣金额*/
        ///</summary>
        [JsonProperty("tkfee3")]
        public float? TkFee3 { get; set; }

        ///<summary> 
        ///biaoqian  ""满300元,省30元"",                   /*店铺活动*/
        ///</summary>
        [JsonProperty("biaoqian")]
        public string BiaoQian { get; set; }

        ///<summary> 
        ///tag  "赶紧拯救你厨房的油腻吧😂植护🌿加厚厨房抽纸高密度纤维纸张，吸油💧很不错5包装|￥14.8元💰✔厨房小帮手，用处多多"                   /*朋友圈文案，需要自己进行urldecode*/
        ///</summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }


        #endregion
    }
}
