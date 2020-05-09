using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ShortUrlTaoBaoGetRequest : BaseRequest<ShortUrlGetResponse>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_shorturl_taobao_get.ashx"
        };

        #region =====================

        ///<summary> 
        ///content string	是	输入原始url，转换得到淘宝短链接。要转短链接的网址，需要进行Urlencode编码，只支持uland.taobao.com，s.click.taobao.com， ai.taobao.com，temai.taobao.com的域名转换，否则判错。
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        #endregion
    }

    public class ShortUrlSinaGetRequest : ShortUrlTaoBaoGetRequest
    {
        ///<summary> 
        ///type string	否	短链类型，type=0表示新浪短链，type=1表示搜狐短链，默认type=0。
        ///</summary>
        [JsonProperty("type")]
        public int Type { get; set; } = 0;

        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_shorturl_sina_get.ashx"
        };
    }

    public class ShortUrlBaiduGetRequest : ShortUrlTaoBaoGetRequest
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_shorturl_baidu_get.ashx"
        };
    }
}
