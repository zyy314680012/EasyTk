using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkWeAppQrCodeUrlGenResponse : BaseResponse<PddDdkWeAppQrCodeUrlGenResponse.WeAppQrCodeGenerateData>
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("weapp_qrcode_generate_response")]
        public override WeAppQrCodeGenerateData Data { get; set; }

        public class WeAppQrCodeGenerateData : BaseResponseData
        {
            /// <summary>
            /// 单品推广小程序二维码url
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }
        }
    }
}
