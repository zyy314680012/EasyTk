using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class TklCreateRequest : BaseRequest<TklCreateResponse>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_tkl_create.ashx"
        };

        #region ============================

        ///<summary> 
        ///text string	是	口令弹框内容，长度大于5个字符，如：美美小编精心推荐。尽量不要带特殊符号或特殊词，否则生成的淘口令手淘里可能打不开。
        ///</summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        ///<summary> 
        ///url string	是	口令跳转目标页，如：https://uland.taobao.com/，必须以https开头，可以是二合一链接、长链接、短链接等各种淘宝高佣链接；支持渠道备案链接。请注意，该参数需要进行Urlencode编码后传入。。重要的事情说三遍：该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！
        ///</summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        ///<summary> 
        ///logo string	否	口令弹框logoURL，如：https://img.alicdn.com/bao/uploaded/i2.jpg_200x200.jpg
        ///</summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        ///<summary> 
        ///signurl int	否	值为1或者2，表示返回淘宝联盟请求地址，大家拿到地址后再用自己的服务器二次请求即可获得最终结果，值为1返回http链接，值为2返回https安全链接，值为0表示直接返回淘口令最终结果。
        ///</summary>
        [JsonProperty("signurl")]
        public int SignUrl { get; set; }

        #endregion
    }
}
