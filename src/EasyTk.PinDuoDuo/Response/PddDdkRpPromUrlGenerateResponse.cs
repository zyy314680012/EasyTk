using EasyTk.PinDuoDuo.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkRpPromUrlGenerateResponse : BaseResponse<PddDdkRpPromUrlGenerateResponse.PddDdkRpPromUrlGenerateData>
    {
        /// <summary>
        /// 推广链接返回对象
        /// </summary>
        [JsonProperty("rp_promotion_url_generate_response")]
        public override PddDdkRpPromUrlGenerateData Data { get; set; }

        public class PddDdkRpPromUrlGenerateData : BaseResponseData
        {
            /// <summary>
            /// resource_list
            /// </summary>
            [JsonProperty("resource_list")]
            public Resource[] ResourceList { get; set; }

            /// <summary>
            /// url_list
            /// </summary>
            [JsonProperty("url_list")]
            public UrlItem[] UrlList { get; set; }
        }

        public class Resource
        {
            /// <summary>
            /// 活动描述
            /// </summary>
            [JsonProperty("desc")]
            public string Desc { get; set; }

            /// <summary>
            /// 活动地址
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

        }

        public class UrlItem
        {
            /// <summary>
            /// 推广移动短链接
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }

            /// <summary>
            /// 推广移动链接
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }

            /// <summary>
            /// 推广多人团移动短链接
            /// </summary>
            [JsonProperty("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }

            /// <summary>
            /// 推广多人团移动链接
            /// </summary>
            [JsonProperty("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }

            /// <summary>
            /// 推广多人团短链接
            /// </summary>
            [JsonProperty("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }

            /// <summary>
            /// 推广多人团链接
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
            /// 推广短链接
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// 推广链接
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
