using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    /// <summary>
    /// 抖音商品转链
    /// https://www.dataoke.com/kfpt/api-d.html?id=92
    /// </summary>
    public class KolProductShareRequest : BaseRequest<WrapperResponse<KolProductShareResponse>>
    {
        public override string GetApiUrl() => "https://openapiv2.dataoke.com/open-api/tiktok-kol-product-share";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// productUrl String 是 要转链的商品链接/口令
        /// </summary>
        [JsonProperty("productUrl")]
        public string ProductUrl { get; set; }

        /// <summary>
        /// externalInfo String 是 自定参数,最多7位，可以用来返利时传入用户参数，没有返利传0 只允许 数字、字母和_
        /// </summary>
        [JsonProperty("externalInfo")]
        public string ExternalInfo { get; set; }

        #endregion
    }
}
