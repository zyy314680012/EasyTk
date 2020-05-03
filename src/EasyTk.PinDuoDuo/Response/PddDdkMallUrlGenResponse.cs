using EasyTk.PinDuoDuo.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkMallUrlGenResponse : BaseResponse<PddDdkMallUrlGenResponse.PddDdkMallUrlGenData>
    {
        /// <summary>
        /// mall_coupon_generate_url_response
        /// </summary>
        [JsonProperty("mall_coupon_generate_url_response")]
        public override PddDdkMallUrlGenData Data { get; set; }

        public class PddDdkMallUrlGenData : BaseResponseData
        {
            /// <summary>
            /// 推广链接
            /// </summary>
            [JsonProperty("list")]
            public PddDdkMallUrlGenDataItem[] List { get; set; }
        }

        public class PddDdkMallUrlGenDataItem : PddUrlList
        {
            /// <summary>
            /// qq小程序信息
            /// </summary>
            [JsonProperty("qq_app_info")]
            public QqAppInfo QqAppInfo { get; set; }
        }
    }
}
