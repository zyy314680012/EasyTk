using EasyTk.Core;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public abstract class ShangPinParseRequest<TResponse> : BaseRequest<TResponse> where TResponse : IResponse
    {
        protected abstract override string[] GatewayArray { get; }

        #region ========================

        ///<summary> 
        ///content string	是	淘口令文案或者二合一链接或者长链接或者短链接或者喵口令。请注意，该参数需要进行Urlencode编码后传入。
        ///         淘口令文案：复制这条信息，￥ysuUbqEiTSt￥，打开【手机淘宝】即可。
        ///         二合一链接：以https://uland.taobao.com/coupon/edetail?e=开头的链接
        ///         长链接：以https://s.click.taobao.com/t?e=开头的链接
        ///         短链接：类似https://s.click.taobao.com/R7rDLHw的链接
        ///         喵口令：类似http://***.com/s/3X51L?tm=cd5add的链接
        ///         重要的事情说三遍：该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        ///<summary> 
        ///type string	是	是否返回优惠券详细信息，type=1表示返回商品ID和优惠券详细信息，注意，优惠券信息可能为空
        ///</summary>
        [JsonProperty("type")]
        public int Type { get; set; } = 0;

        ///<summary> 
        ///tlj string	否	是否解析淘礼金淘口令，tlj=1表示解析，tlj=0表示不解析，默认tlj=0
        ///</summary>
        [JsonProperty("tlj")]
        public int? Tlj { get; set; } = 0;

        ///<summary> 
        ///hjs string	否	是否解析火炬手淘口令，hjs=1表示解析，hjs=0表示不解析，默认hjs=1
        ///</summary>
        [JsonProperty("hjs")]
        public int? Hjs { get; set; } = 1;


        #endregion
    }
}
