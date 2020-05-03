using EasyTk.PinDuoDuo.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkResourceUrlGenResponse : BaseResponse<PddDdkResourceUrlGenResponse.PddDdkResourceUrlGenData>
    {
        /// <summary>
        /// resource_url_response
        /// </summary>
        [JsonProperty("resource_url_response")]
        public override PddDdkResourceUrlGenData Data { get; set; }

        public class PddDdkResourceUrlGenData : BaseResponseData
        {
            /// <summary>
            /// 多人团链接
            /// </summary>
            [JsonProperty("multi_url_list")]
            public PddUrlList MultiUrlList { get; set; }

            /// <summary>
            /// qq小程序信息
            /// </summary>
            [JsonProperty("qq_app_info")]
            public QqAppInfo QqAppInfo { get; set; }

            /// <summary>
            /// sign
            /// </summary>
            [JsonProperty("sign")]
            public string Sign { get; set; }

            /// <summary>
            /// 单人团链接
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
