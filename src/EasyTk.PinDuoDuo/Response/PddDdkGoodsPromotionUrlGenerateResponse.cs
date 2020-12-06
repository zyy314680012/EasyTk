using EasyTk.PinDuoDuo.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkGoodsPromotionUrlGenerateResponse : BaseResponse<PddDdkGoodsPromotionUrlGenerateResponse.PddDdkGoodsPromotionUrlGenerateData>
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_promotion_url_generate_response")]
        public override PddDdkGoodsPromotionUrlGenerateData Data { get; set; }

        public class PddDdkGoodsPromotionUrlGenerateData : BaseResponseData
        {
            /// <summary>
            /// 多多进宝推广链接对象列表
            /// </summary>
            [JsonProperty("goods_promotion_url_list")]
            public GoodsPromotionUrl[] GoodsPromotionUrlList { get; set; }

            public class GoodsPromotionUrl
            {
                /// <summary>
                /// 推广移动短链接，对应出参mobile_url的短链接，与mobile_url功能一致。
                /// </summary>
                [JsonProperty("mobile_short_url")]
                public string MobileShortUrl { get; set; }

                /// <summary>
                /// 推广移动链接，用户安装拼多多APP的情况下会唤起APP，否则唤起H5页面
                /// </summary>
                [JsonProperty("mobile_url")]
                public string MobileUrl { get; set; }

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
                /// 推广长链接
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }

                /// <summary>
                /// 微博推广短链接
                /// </summary>
                [JsonProperty("weibo_app_web_view_short_url")]
                public string WeiboAppWebViewShortUrl { get; set; }

                /// <summary>
                /// 微博推广链接
                /// </summary>
                [JsonProperty("weibo_app_web_view_url")]
                public string WeiboAppWebViewUrl { get; set; }

                /// <summary>
                /// 小程序信息
                /// </summary>
                [JsonProperty("we_app_info")]
                public WeAppInfo WeAppInfo { get; set; }
            }
        }
    }
}
