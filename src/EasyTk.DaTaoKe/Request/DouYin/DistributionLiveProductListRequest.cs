using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    /// <summary>
    /// 抖音直播间商品
    /// https://www.dataoke.com/kfpt/api-d.html?id=111
    /// </summary>
    public class DistributionLiveProductListRequest : BaseRequest<WrapperResponse<DistributionLiveProductListResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tiktok/tiktok-distribution-live-product-list";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// author_buyin_id String 是 主播百应ID
        /// </summary>
        [JsonProperty("author_buyin_id")]
        public string AuthorBuyinId { get; set; }

        #endregion
    }
}
