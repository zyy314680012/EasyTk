using EasyTk.PinDuoDuo.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkLotteryUrlGenResponse : BaseResponse<PddDdkLotteryUrlGenResponse.PddDdkLotteryUrlGenData>
    {
        /// <summary>
        /// lottery_url_response
        /// </summary>
        [JsonProperty("lottery_url_response")]
        public override PddDdkLotteryUrlGenData Data { get; set; }

        public class PddDdkLotteryUrlGenData : BaseResponseData
        {
            /// <summary>
            /// 返回总数
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }

            /// <summary>
            /// 推广链接
            /// </summary>
            [JsonProperty("url_list")]
            public PddDdkLotteryUrlGenDataItem[] UrlList { get; set; }
        }

        public class PddDdkLotteryUrlGenDataItem
        {
            /// <summary>
            /// 转盘抽免单多人团链接
            /// </summary>
            [JsonProperty("multi_url_list")]
            public PddUrlList MultiUrlList { get; set; }

            /// <summary>
            /// qq小程序信息
            /// </summary>
            [JsonProperty("qq_app_info")]
            public QqAppInfo QqAppInfo { get; set; }

            /// <summary>
            /// 自定义参数
            /// </summary>
            [JsonProperty("sign")]
            public string Sign { get; set; }

            /// <summary>
            /// 转盘抽免单单人团链接
            /// </summary>
            [JsonProperty("single_url_list")]
            public PddUrlList SingleUrlList { get; set; }

            /// <summary>
            /// 小程序信息
            /// </summary>
            [JsonProperty("we_app_info")]
            public WeAppInfo WeAppInfo { get; set; }
        }
    }
}
