using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class ManArticlesResponse
    {
        ///<summary> 
        ///talent_id integer	747	文章id
        ///</summary>
        [JsonProperty("talent_id")]
        public long TalentId { get; set; }

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

    }
}
