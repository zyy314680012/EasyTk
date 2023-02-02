using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    /// <summary>
    /// 抖音直播间转链
    /// https://www.dataoke.com/kfpt/api-d.html?id=110
    /// </summary>
    public class InstituteLiveShareRequest : BaseRequest<WrapperResponse<InstituteLiveShareResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tiktok/tiktok-institute-live-share";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// external_info String 是 自定参数,最多7位，可以用来返利时传入用户参数，没有返利传0
        /// </summary>
        [JsonProperty("external_info")]
        public string ExternalInfo { get; set; }

        /// <summary>
        /// buyin_id String 是 主播百应ID
        /// </summary>
        [JsonProperty("buyin_id")]
        public string BuyinId { get; set; }

        /// <summary>
        /// need_qr_code String 否 是否需要二维码(1是需要，0不需要)
        /// </summary>
        [JsonProperty("need_qr_code")]
        public int? NeedQrCode { get; set; }

        #endregion
    }
}
