using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class ErrorResponse
    {

        [JsonProperty("error_response")]
        public ErrorResponseData Data { get; set; }


        public class ErrorResponseData : BaseResponseData
        {
            [JsonProperty("error_msg")]
            public string ErrorMsg { get; set; }

            [JsonProperty("sub_msg")]
            public string SubMsg { get; set; }

            [JsonProperty("sub_code")]
            public string SubCode { get; set; }

            [JsonProperty("error_code")]
            public string ErrorCode { get; set; }
        }
    }
}
