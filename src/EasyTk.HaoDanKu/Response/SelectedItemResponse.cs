using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class SelectedItemResponse
    {
        ///<summary> 
        ///edit_id string	31144	单品id
        ///</summary>
        [JsonProperty("edit_id")]
        public long EditId { get; set; }

        ///<summary> 
        ///itempic string	["http:\/\/img04.taobaocdn.com:80\/tfscom\/TB1bTopHQOWBuNjSsppXXXPgpXa", "http:\/\/img03.taobaocdn.com:80\/tfscom\/TB1wFOjHFmWBuNjSspdXXbugXXa", "https:\/\/img.alicdn.com\/imgextra\/i3\/1665061275\/TB2TCQasKuSBuNjy1XcXXcYjFXa_!!1665061275.jpg"]	多张宝贝图片，含实拍图（由于图片原图过大影响加载速度，建议加上后缀_310x310.jpg，如https://img.alicdn.com/imgextra/i2/3412518427/TB26gs7bb7U5uJjSZFFXXaYHpXa_!!3412518427.jpg_310x310.jpg）
        ///</summary>
        [JsonProperty("itempic")]
        public string[] ItemPic { get; set; }

        ///<summary> 
        ///itemtitle string	南极人3条大毛巾纯棉 加大加厚全棉洗脸擦脸成人情侣面巾柔软吸水	宝贝标题
        ///</summary>
        [JsonProperty("itemtitle")]
        public string ItemTitle { get; set; }

        ///<summary> 
        ///couponurl string	https:\/\/uland.taobao.com\/quan\/detail?sellerId=1665061275&activityId=243bbf00f2864d76a1cb632f27ec9351	优惠券链接
        ///</summary>
        [JsonProperty("couponurl")]
        public string CouponUrl { get; set; }

        ///<summary> 
        ///content string	大热天的，毛巾要勤更换哦$普通表情[85]$\n南极人大牌的，柔软不伤肤$普通表情[123]$\n$emoji表情[55]$纯棉3条装，真的非~常~大~\n淘抢购~券后【21】$emoji表情[27]$包邮	单品导购内容（表情未处理）
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        ///<summary> 
        ///comment string	购买方法~$普通表情[119]$\n原价：24.00元，券后：21.00元\n\n$emoji表情[66]$复制这条信息，$淘口令$，打开『手机TAO宝』即可领券下单！|超市这种纯棉大毛巾，一条要15$emoji表情[158]$今天咱这价格也太值了吧！	朋友圈评论内容（表情未处理），多条评论用“|”做区分
        ///</summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        ///<summary> 
        ///show_time integer	1532942702	展示时间戳
        ///</summary>
        [JsonProperty("show_time")]
        public string ShowTime { get; set; }

        ///<summary> 
        ///itemendprice float	21.0	宝贝券后价
        ///</summary>
        [JsonProperty("itemendprice")]
        public float? ItemEndPrice { get; set; }

        ///<summary> 
        ///couponmoney float	3	优惠券金额
        ///</summary>
        [JsonProperty("couponmoney")]
        public float? CouponMoney { get; set; }

        ///<summary> 
        ///dummy_click_statistics string	3422	该商品被分享次数
        ///</summary>
        [JsonProperty("dummy_click_statistics")]
        public long DummyClickStatistics { get; set; }

        ///<summary> 
        ///itemprice float	24.0	在售价
        ///</summary>
        [JsonProperty("itemprice")]
        public float? ItemPrice { get; set; }

        ///<summary> 
        ///tkrates float	30	佣金比例
        ///</summary>
        [JsonProperty("tkrates")]
        public float? TkRates { get; set; }

        ///<summary> 
        ///show_content string	大热天的，毛巾要勤更换哦<img src='http:\/\/img.haodanku.com\/1_bqfh116.png'>南极人大牌的，柔软不伤肤<img src='http:\/\/img.haodanku.com\/1_bqfh116.png'>纯棉3条装，真的非~常~大~淘抢购~券后【21】<img src='http:\/\/img.haodanku.com\/1_bqfh32.png'>包邮	导购文案展示内容，含表情copy_content	string	大热天的，毛巾要勤更换哦[飞吻]南极人大牌的，柔软不伤肤[NO]👍纯棉3条装，真的非~常~大~淘抢购~券后【21】😱包邮	导购文案复制内容，含表情show_comment	string	购买方法~<img src='http:\/\/img.haodanku.com\/1_bqfh116.png'>原价：24.00元，券后：21.00元<img src='http:\/\/img.haodanku.com\/1_bqfh116.png'>复制这条信息，$淘口令$，打开『手机TAO宝』即可领券下单！|超市这种纯棉大毛巾，一条要15<img src='http:\/\/img.haodanku.com\/3_bqfh76.png'>今天咱这价格也太值了吧！	朋友圈评论展示内容，含表情，多条评论用“|”做区分copy_comment	string	大热天的，毛巾要勤更换哦[飞吻]南极人大牌的，柔软不伤肤[NO]👍纯棉3条装，真的非~常~大~淘抢购~券后【21】😱包邮	朋友圈评论复制内容，含表情，多条评论用“|”做区分
        ///</summary>
        [JsonProperty("show_content")]
        public string ShowContent { get; set; }

    }
}
