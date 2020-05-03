using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 多多进宝主题列表查询
    /// </summary>
    public class PddDdkThemeListGetRequest : BaseRequest<PddDdkThemeListGetResponse>
    {
        public override string Type => "pdd.ddk.theme.list.get";

        #region 

        /// <summary>
        /// 返回的页码
        /// </summary>
        [JsonProperty("page")]
        public long? Page { get; set; }

        /// <summary>
        /// 返回的一页数据数量
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; }

        #endregion
    }
}
