using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response.Partial
{
    public class PddUrlList
    {
        /// <summary>
        /// 唤醒拼多多app短链接
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// 唤醒拼多多app长链接
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// schema的链接
        /// </summary>
        [JsonProperty("schema_url")]
        public string SchemaUrl { get; set; }

        /// <summary>
        /// 短链接
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// 长链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 唤醒微信短链接
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public string WeAppWebViewShortUrl { get; set; }

        /// <summary>
        /// 唤醒微信链接
        /// </summary>
        [JsonProperty("we_app_web_view_url")]
        public string WeAppWebViewUrl { get; set; }

        /// <summary>
        /// 微信小程序链接
        /// </summary>
        [JsonProperty("we_app_page_path")]
        public string WeAppPagePath { get; set; }
    }
}
