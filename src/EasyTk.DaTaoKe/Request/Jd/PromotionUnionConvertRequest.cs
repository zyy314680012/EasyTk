using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.Jd;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.Jd
{
    /// <summary>
    /// 转链京东一元购商品
    /// </summary>
    public class PromotionUnionConvertRequest : BaseRequest<WrapperResponseList<PromotionUnionConvertResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/dels/jd/kit/outer/promotion-union-convert";

        public override string Version => "v1.0.0";

        /// <summary>
        /// code String 是 自定义标识，用于区分下游推广渠道。只能由数字和字符串组成且字符串长度在5-16之间
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        ///  materialId String 是 推广物料url，例如活动链接、商品链接等；不支持仅传入skuid
        /// </summary>
        [JsonProperty("materialId")]
        public string MaterialId { get; set; }

        /// <summary>
        /// chainType Integer 否 转链类型，默认短链，短链有效期60天 1：长链2：短链3：长链+短链
        /// </summary>
        [JsonProperty("chainType")]
        public int? ChainType { get; set; } = 2;
    }
}
