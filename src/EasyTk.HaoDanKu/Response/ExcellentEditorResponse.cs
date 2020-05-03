using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class ExcellentEditorResponse
    {
        ///<summary> 
        ///product_id Integer	2720653	自增ID
        ///</summary>
        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        ///<summary> 
        ///itemid Integer	553757100845	宝贝ID
        ///</summary>
        [JsonProperty("itemid")]
        public long ItemId { get; set; }

        ///<summary> 
        ///time string	1526547000	发布时间时间戳
        ///</summary>
        [JsonProperty("time")]
        public long? Time { get; set; }

        ///<summary> 
        ///itemshorttitle string	容威酸奶机家用全自动玻璃内胆炒酸奶机家用小型迷你纳豆米酒机	宝贝短标题
        ///</summary>
        [JsonProperty("itemshorttitle")]
        public string ItemShortTitle { get; set; }

        ///<summary> 
        ///itemprice float	8.10	在售价
        ///</summary>
        [JsonProperty("itemprice")]
        public float? ItemPrice { get; set; }

        ///<summary> 
        ///itempic string	https:\/\/img.alicdn.com\/imgextra\/i4\/716824265\/TB29otVd7fb_uJkHFrdXXX2IVXa_!!716824265.jpg	宝贝主图原始图像（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https:\/\/img.alicdn.com\/imgextra\/i4\/716824265\/TB29otVd7fb_uJkHFrdXXX2IVXa_!!716824265.jpg_310x310.jpg）
        ///</summary>
        [JsonProperty("itempic")]
        public string ItemPic { get; set; }

        ///<summary> 
        ///itemendprice float	3.10	宝贝券后价
        ///</summary>
        [JsonProperty("itemendprice")]
        public float? ItemEndPrice { get; set; }

        ///<summary> 
        ///shoptype string	B	店铺类型：天猫（B）淘宝店（C）
        ///</summary>
        [JsonProperty("shoptype")]
        public string ShopType { get; set; }

        ///<summary> 
        ///couponurl string	https://uland.taobao.com/quan/detail??sellerId=3162813958&activityId=1d5771905a774f01ad345d26ad8a55b2	优惠券链接
        ///</summary>
        [JsonProperty("couponurl")]
        public string CouponUrl { get; set; }

        ///<summary> 
        ///couponmoney float	5.6	优惠券金额
        ///</summary>
        [JsonProperty("couponmoney")]
        public float? CouponMoney { get; set; }

        ///<summary> 
        ///tkrates float	70.50	佣金比例
        ///</summary>
        [JsonProperty("tkrates")]
        public float? TkRates { get; set; }

        ///<summary> 
        ///tkmoney float	2.19	预计可得（宝贝价格 * 佣金比例 / 100）
        ///</summary>
        [JsonProperty("tkmoney")]
        public float? TkMoney { get; set; }

        ///<summary> 
        ///text string	铛铛铛，你看看加点水果，真的很好吃哟	文案展示内容
        ///</summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        ///<summary> 
        ///copy_text string	铛铛铛，你看看加点水果，真的很好吃哟[机智]酸奶，还是自己做出来的好吃呀😍家用全自动[玫瑰]玻璃内胆炒酸奶机⚡咱们券后【24.9起】——————————文案复制内容original_text	string	铛铛铛，你看看加点水果，真的很好吃哟[机智]酸奶，还是自己做出来的好吃呀$emoji表情[23]$家用全自动[玫瑰]玻璃内胆炒酸奶机$emoji表情[124]$咱们券后【24.9起】——————————文案展示内容,表情未处
        ///</summary>
        [JsonProperty("copy_text")]
        public string CopyText { get; set; }

    }
}
