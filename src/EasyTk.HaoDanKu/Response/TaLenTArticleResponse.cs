using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class TaLenTArticleResponse
    {
        ///<summary> 
        ///id integer	747	文章id
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        ///<summary> 
        ///name string	约会七夕|怎么穿才能拥有自己的style	文章标题
        ///</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        ///<summary> 
        ///shorttitle string	七夕攻略男神计划	文章短标题
        ///</summary>
        [JsonProperty("shorttitle")]
        public string ShortTitle { get; set; }

        ///<summary> 
        ///compose_image string	hhttp://img.haodanku.com/Fki91HkTxd-VnFnJYB03D8POp2KF	APP信息流主图
        ///</summary>
        [JsonProperty("compose_image")]
        public string ComposeImage { get; set; }

        ///<summary> 
        ///app_image string	http://img.haodanku.com/FiKDisnwbuhzcPLPr3ylmnNKKgd-	置顶图片
        ///</summary>
        [JsonProperty("app_image")]
        public string AppImage { get; set; }

        ///<summary> 
        ///label string	#七夕节#	文章标签
        ///</summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        ///<summary> 
        ///itemid_str string	570590072641,573978790339,574960973786,575563450217	文章包含商品的id
        ///</summary>
        [JsonProperty("itemid_str")]
        public string ItemIdStr { get; set; }

        ///<summary> 
        ///article_banner string	http://img.haodanku.com/Fh0ZAyfA__EMlaqAwqy90igAntQE	文章banner
        ///</summary>
        [JsonProperty("article_banner")]
        public string ArticleBanner { get; set; }

        ///<summary> 
        ///highquality Integer	1	文章置顶1是，0否
        ///</summary>
        [JsonProperty("highquality")]
        public long? HighQuality { get; set; }

        ///<summary> 
        ///readtimes Integer	351	浏览量
        ///</summary>
        [JsonProperty("readtimes")]
        public long? ReadTimes { get; set; }

        ///<summary> 
        ///talent_name string	半夏微凉	达人名号
        ///</summary>
        [JsonProperty("talent_name")]
        public string TalentName { get; set; }

        ///<summary> 
        ///head_img string	http://img.haodanku.com/FoJtOF0ufi3bcCSJ1nEgMtJfu_n4	达人头像
        ///</summary>
        [JsonProperty("head_img")]
        public string HeadImg { get; set; }

        ///<summary> 
        ///followtimes Integer	19	点赞量
        ///</summary>
        [JsonProperty("followtimes")]
        public long? FollowTimes { get; set; }

        ///<summary> 
        ///itemnum Integer	6	文章包含商品的数量
        ///</summary>
        [JsonProperty("itemnum")]
        public long? ItemNum { get; set; }

        ///<summary> 
        ///article string	<section style="padding: 3px; border: 3px solid #4c4c4c; margin: 22px 0;">\r\n\t\t\t\t\t\t\t\t\t\t\t<section style="padding: 10px; border: 1px solid #808080; color: #635959; font-size: 1.4rem; text-align: center;">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<p>鹊桥仙</p><p>纤云弄巧，飞星传恨，银汉迢迢暗渡。金风玉露一相逢，便胜却人间无数。<br/></p><p>柔情似水，佳期如梦，忍顾鹊桥归路!两情若是久长时，又岂在朝朝暮暮!……	带标签的文章正文
        ///</summary>
        [JsonProperty("article")]
        public string Article { get; set; }

        ///<summary> 
        ///items array	[]	商品数组
        ///</summary>
        [JsonProperty("items")]
        public TaLenTArticleItem[] Items { get; set; }

        public class TaLenTArticleItem
        {
            ///<summary> 
            ///itemid Integer	570590072641	商品ID
            ///</summary>
            [JsonProperty("itemid")]
            public long? ItemId { get; set; }

            ///<summary> 
            ///itemshorttitle string	韩版中长款吊带碎花连衣裙	商品短标题
            ///</summary>
            [JsonProperty("itemshorttitle")]
            public string ItemShortTitle { get; set; }

            ///<summary> 
            ///itemtitle string	2018新款女装遮肚子碎花黑色韩版宽松雪纺连衣裙过膝中长款吊带裙	商品标题
            ///</summary>
            [JsonProperty("itemtitle")]
            public string ItemTitle { get; set; }

            ///<summary> 
            ///itemendprice float	28.00	券后价
            ///</summary>
            [JsonProperty("itemendprice")]
            public float? ItemEndPrice { get; set; }

            ///<summary> 
            ///rkrates float	30.00	佣金比例
            ///</summary>
            [JsonProperty("rkrates")]
            public float? RkRates { get; set; }

            ///<summary> 
            ///couponmoney Integer	70	优惠券面额
            ///</summary>
            [JsonProperty("couponmoney")]
            public float? CouponMoney { get; set; }

            ///<summary> 
            ///tkmoney float	8.40	预估佣金
            ///</summary>
            [JsonProperty("tkmoney")]
            public float? TkMoney { get; set; }

            ///<summary> 
            ///itemsale Integer	1782	总销量
            ///</summary>
            [JsonProperty("itemsale")]
            public long? ItemSale { get; set; }

            ///<summary> 
            ///couponurl string	https://uland.taobao.com/quan/detail?sellerId=2234460366&activityId=1924abad62a448b3ad4c3137219723b2	优惠券链接
            ///</summary>
            [JsonProperty("couponurl")]
            public string CouponUrl { get; set; }

            ///<summary> 
            ///itempic string	https://img.alicdn.com/imgextra/i4/3012913363/TB2sItlaGAoBKNjSZSyXXaHAVXa_!!3012913363.jpg	商品主图链接
            ///</summary>
            [JsonProperty("itempic")]
            public string ItemPic { get; set; }

        }
    }
}
