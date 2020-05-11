using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    /// <summary>
    /// 店铺链接转换API：生成一个或者多个指定的店铺推广长链接地址
    /// </summary>
    public class ShopConvertRequest : BaseRequest<ShopConvertResponse>
    {
        ///<summary> 
        ///site_id string	是	备案的网站id, mm_xx_xx_xx pid三段式中的第二段
        ///</summary>
        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        ///<summary> 
        ///fields string	是	需返回的字段列表，如：user_id,click_url
        ///</summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        ///<summary> 
        ///user_ids string	是	卖家ID串，用','分割，可通过全网商品详情API接口获得,seller_id字段
        ///</summary>
        [JsonProperty("user_ids")]
        public string UserIds { get; set; }

        ///<summary> 
        ///platform string	否	链接形式：1：PC，2：无线，默认：1
        ///</summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

        ///<summary> 
        ///adzone_id string	是	广告位ID，区分效果位置
        ///</summary>
        [JsonProperty("adzone_id")]
        public string AdZoneId { get; set; }

        ///<summary> 
        ///unid string	否	自定义输入串，英文和数字组成，长度不能大于12个字符，区分不同的推广渠道
        ///</summary>
        [JsonProperty("unid")]
        public string UnId { get; set; }

        ///<summary> 
        ///signurl int	否	值为1或者2，表示返回淘宝联盟请求地址，大家拿到地址后再用自己的服务器二次请求即可获得最终结果，值为1返回http链接，值为2返回https安全链接，值为0表示直接返回最终结果。
        ///</summary>
        [JsonProperty("signurl")]
        public int SignUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_shop_convert.ashx"
        };
    }
}
