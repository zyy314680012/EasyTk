using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Response
{
    public class SuperSearchResponse : BaseResponse
    {
        ///<summary> 
        ///tb_p Integer	1	作为请求地址中获取下一页联盟超级搜数据的参数值
        ///</summary>
        [JsonProperty("tb_p")]
        public long TbP { get; set; }


        /// <summary>
        /// 数据
        /// </summary>
        [JsonProperty("data")]
        public List<SuperSearchResultData> Data { get; set; }

        public class SuperSearchResultData
        {
            ///<summary> 
            ///itemid Integer	553757100845	宝贝ID
            ///</summary>
            [JsonProperty("itemid")]
            public long ItemId { get; set; }

            ///<summary> 
            ///itemtitle string	南极人魅金创意不锈钢垃圾桶家用卫生间客厅卧室脚踏式厕所带盖筒	宝贝标题
            ///</summary>
            [JsonProperty("itemtitle")]
            public string ItemTitle { get; set; }

            ///<summary> 
            ///itemshorttitle string	南极人家用卫生间客厅垃圾袋60个	宝贝短标题
            ///</summary>
            [JsonProperty("itemshorttitle")]
            public string ItemShortTitle { get; set; }

            ///<summary> 
            ///itemdesc string	南极人加厚垃圾袋60支，采用高强度PE新材料韧性足、无异味、承重佳、封底结实不易漏，避免烂袋尴尬，千万家庭的选择，抢到就是赚！【送运费险】	宝贝推荐语
            ///</summary>
            [JsonProperty("itemdesc")]
            public string ItemDesc { get; set; }

            ///<summary> 
            ///itemprice float	8.10	在售价
            ///</summary>
            [JsonProperty("itemprice")]
            public float? ItemPrice { get; set; }

            ///<summary> 
            ///itemsale integer	33879	宝贝月销量
            ///</summary>
            [JsonProperty("itemsale")]
            public long? ItemSale { get; set; }

            ///<summary> 
            ///itempic string	https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg	宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
            ///</summary>
            [JsonProperty("itempic")]
            public string ItemPic { get; set; }

            ///<summary> 
            ///itemendprice float	3.10	宝贝券后价
            ///</summary>
            [JsonProperty("itemendprice")]
            public float? ItemEndPrice { get; set; }

            ///<summary> 
            ///shoptype string	B	店铺类型：天猫店（B）淘宝店（C）
            ///</summary>
            [JsonProperty("shoptype")]
            public string ShopType { get; set; }

            ///<summary> 
            ///couponurl string	https://uland.taobao.com/quan/detail??sellerId=3162813958&activityId=1d5771905a774f01ad345d26ad8a55b2	优惠券链接
            ///</summary>
            [JsonProperty("couponurl")]
            public string CouponUrl { get; set; }

            ///<summary> 
            ///activityid string	1d5771905a774f01ad345d26ad8a55b2	优惠券活动ID
            ///</summary>
            [JsonProperty("activityid")]
            public string ActivityId { get; set; }

            ///<summary> 
            ///couponmoney float	5.6	优惠券金额
            ///</summary>
            [JsonProperty("couponmoney")]
            public float? CouponMoney { get; set; }

            ///<summary> 
            ///videoid integer	0	商品视频ID（id大于0的为有视频单，视频拼接地址http://cloud.video.taobao.com/play/u/1/p/1/e/6/t/1/+videoid+.mp4）
            ///</summary>
            [JsonProperty("videoid")]
            public long? VideoId { get; set; }

            ///<summary> 
            ///tkrates float	70.50	佣金比例
            ///</summary>
            [JsonProperty("tkrates")]
            public float? TkRates { get; set; }

            ///<summary> 
            ///couponstarttime integer	1509120000	优惠券开始时间
            ///</summary>
            [JsonProperty("couponstarttime")]
            public long? CouponStartTime { get; set; }

            ///<summary> 
            ///couponendtime integer	1509292799	优惠券结束时间
            ///</summary>
            [JsonProperty("couponendtime")]
            public long? CouponEndTime { get; set; }

            ///<summary> 
            ///item_from string	haodanku	数据来源：haodanku（来自好单库精选高佣商品），tb（来自联盟超级搜API）
            ///</summary>
            [JsonProperty("item_from")]
            public string ItemFrom { get; set; }
        }
    }
}
