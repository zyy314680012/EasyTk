using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkPidMediaidBindResponse : BaseResponse<PddDdkPidMediaidBindResponse.PddDdkPidMediaidBindResponseData>
    {
        /// <summary>
        /// p_id_bind_response	OBJECT		response
        /// </summary>
        [JsonProperty("p_id_bind_response")]
        public override PddDdkPidMediaidBindResponseData Data { get; set; }

        public class PddDdkPidMediaidBindResponseData
        {
            /// <summary>
            /// result	OBJECT		绑定结果
            /// </summary>
            [JsonProperty("result")]
            public PddDdkPidMediaidBindResponseResult Result { get; set; }
        }

        public class PddDdkPidMediaidBindResponseResult
        {
            /// <summary>
            /// msg	STRING		绑定结果文本提示
            /// </summary>
            [JsonProperty("msg")]
            public string Msg { get; set; }

            /// <summary>
            /// result	BOOLEAN		绑定结果
            /// </summary>
            [JsonProperty("result")]
            public bool Result { get; set; }
        }
    }
}
