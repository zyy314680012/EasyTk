using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response.Partial
{
    /// <summary>
    /// 拼多多小程序
    /// </summary>
    public class QqAppInfo
    {
        /// <summary>
        /// 拼多多小程序id
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Banner图
        /// </summary>
        [JsonProperty("banner_url")]
        public string BannerUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 小程序path值
        /// </summary>
        [JsonProperty("page_path")]
        public string PagePath { get; set; }

        /// <summary>
        /// 小程序icon
        /// </summary>
        [JsonProperty("qq_app_icon_url")]
        public string QqAppIconUrl { get; set; }

        /// <summary>
        /// 来源名
        /// </summary>
        [JsonProperty("source_display_name")]
        public string SourceDisplayName { get; set; }

        /// <summary>
        /// 小程序标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
