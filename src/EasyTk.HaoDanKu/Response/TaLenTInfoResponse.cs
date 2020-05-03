using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Response
{
    public class TaLenTInfoResponse
    {
        ///<summary> 
        ///topdata array	[]	置顶文章数组
        ///</summary>
        [JsonProperty("topdata")]
        public TaLenTInfoData[] TopData { get; set; }

        ///<summary> 
        ///newdata array	[]	最新文章数组
        ///</summary>
        [JsonProperty("newdata")]
        public TaLenTInfoData[] NewData { get; set; }

        ///<summary> 
        ///clickdata array	[]	阅读量降序排列的文章信息
        ///</summary>
        [JsonProperty("clickdata")]
        public TaLenTInfoData[] ClickData { get; set; }

        [JsonProperty("talent_Category")]
        public Dictionary<long, string> TalentCategory { get; set; }

        public class TaLenTInfoData
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
            ///image string	http://img.alicdn.com/imgextra/i3/1663047112/TB2Od9lFER1BeNjy0FmXXb0wVXa_!!1663047112.jpg	文章商品主图
            ///</summary>
            [JsonProperty("image")]
            public string Image { get; set; }

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
            ///tk_item_id string	570590072641,573978790339,574960973786,575563450217	文章包含商品的id
            ///</summary>
            [JsonProperty("tk_item_id")]
            public string TkItemId { get; set; }

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
            ///article string	5毛钱从小卖部带回你最爱的零食，不仅解决了嘴馋，还拥有了大大的幸福”作为90后，提起童年，你脑海里第一时间浮	正文简介
            ///</summary>
            [JsonProperty("article")]
            public string Article { get; set; }

            ///<summary> 
            ///talentcat Integer	2	文章类别（1.好物,2.潮流,3.美食,4.生活）
            ///</summary>
            [JsonProperty("talentcat")]
            public long? TalentCat { get; set; }

            ///<summary> 
            ///itemnum string	6	文章包含商品的数量
            ///</summary>
            [JsonProperty("itemnum")]
            public long? ItemNum { get; set; }
        }
    }
}
