using EasyTk.PinDuoDuo.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkThemePromUrlGenerateResponse : BaseResponse<PddDdkThemePromUrlGenerateResponse.PddDdkThemePromUrlGenerateData>
    {
        /// <summary>
        /// 主题活动推广返回对象
        /// </summary>
        [JsonProperty("theme_promotion_url_generate_response")]
        public override PddDdkThemePromUrlGenerateData Data { get; set; }

        public class PddDdkThemePromUrlGenerateData : BaseResponseData
        {
            /// <summary>
            /// 主题活动推广url列表
            /// </summary>
            [JsonProperty("url_list")]
            public UrlItem[] UrlList { get; set; }
        }

        public class UrlItem
        {
            /// <summary>
            /// 主题活动推广移动短链接
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }

            /// <summary>
            /// 主题活动推广移动链接
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }

            /// <summary>
            /// 主题活动推广开团移动端短链接
            /// </summary>
            [JsonProperty("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }

            /// <summary>
            /// 主题活动推广开团移动端链接
            /// </summary>
            [JsonProperty("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }

            /// <summary>
            /// 主题活动推广开团短链接
            /// </summary>
            [JsonProperty("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }

            /// <summary>
            /// 主题活动推广开团链接
            /// </summary>
            [JsonProperty("multi_group_url")]
            public string MultiGroupUrl { get; set; }

            /// <summary>
            /// qq小程序信息
            /// </summary>
            [JsonProperty("qq_app_info")]
            public QqAppInfo QqAppInfo { get; set; }

            /// <summary>
            /// schema的链接
            /// </summary>
            [JsonProperty("schema_url")]
            public string SchemaUrl { get; set; }

            /// <summary>
            /// 主题活动推广短链
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// 主题活动推广链接
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// 小程序信息
            /// </summary>
            [JsonProperty("we_app_info")]
            public WeAppInfo WeAppInfo { get; set; }
        }
    }
}
