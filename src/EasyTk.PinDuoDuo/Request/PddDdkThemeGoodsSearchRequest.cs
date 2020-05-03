using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 多多进宝主题商品查询
    /// </summary>
    public class PddDdkThemeGoodsSearchRequest : BaseRequest<PddDdkThemeGoodsSearchResponse>
    {
        public override string Type => "pdd.ddk.theme.goods.search";

        #region 

        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("theme_id")]
        public long ThemeId { get; set; }

        #endregion
    }
}
