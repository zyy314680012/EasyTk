using EasyTk.PinDuoDuo.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkCmsPromUrlGenerateResponse : BaseResponse
    {
        /// <summary>
        /// 商城推广链接返回对象
        /// </summary>
        [JsonProperty("cms_promotion_url_generate_response")]
        public PddDdkCmsPromUrlGenerateData CmsPromotionUrlGenerateResponse { get; set; }

        public class PddDdkCmsPromUrlGenerateData : BaseResponseData
        {
            /// <summary>
            /// total
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("url_list")]
            public PddDdkCmsPromUrlGenerateDataItem[] UrlList { get; set; }
        }

        public class PddDdkCmsPromUrlGenerateDataItem
        {
            /// <summary>
            /// 唤醒拼多多app短链
            /// </summary>
            [JsonProperty("mobile_short_url")]
            public string MobileShortUrl { get; set; }

            /// <summary>
            /// 唤醒拼多多app链接
            /// </summary>
            [JsonProperty("mobile_url")]
            public string MobileUrl { get; set; }

            /// <summary>
            /// 多人团唤醒拼多多app链接
            /// </summary>
            [JsonProperty("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }

            /// <summary>
            /// 多人团唤醒拼多多app长链接
            /// </summary>
            [JsonProperty("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }

            /// <summary>
            /// 多人团短链
            /// </summary>
            [JsonProperty("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }

            /// <summary>
            /// 多人团长链
            /// </summary>
            [JsonProperty("multi_group_url")]
            public string MultiGroupUrl { get; set; }

            /// <summary>
            /// 双人团链接列表
            /// </summary>
            [JsonProperty("multi_url_list")]
            public PddUrlList MultiUrlList { get; set; }

            /// <summary>
            /// 多人团唤醒微信推广短链接
            /// </summary>
            [JsonProperty("multi_we_app_web_view_short_url")]
            public string MultiWeAppWebViewShortUrl { get; set; }

            /// <summary>
            /// 多人团唤醒微信推广长链接
            /// </summary>
            [JsonProperty("multi_we_app_web_view_url")]
            public string MultiWeAppWebViewUrl { get; set; }

            /// <summary>
            /// h5短链接
            /// </summary>
            [JsonProperty("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// CPSsign
            /// </summary>
            [JsonProperty("sign")]
            public string Sign { get; set; }

            /// <summary>
            /// 单人团链接列表
            /// </summary>
            [JsonProperty("single_url_list")]
            public PddUrlList SingleUrlList { get; set; }

            /// <summary>
            /// h5长链接
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// 唤醒微信短链
            /// </summary>
            [JsonProperty("we_app_web_view_short_url")]
            public string WeAppWebViewShortUrl { get; set; }

            /// <summary>
            /// 唤醒微信长链
            /// </summary>
            [JsonProperty("we_app_web_view_url")]
            public string WeAppWebViewUrl { get; set; }
        }
    }
}
