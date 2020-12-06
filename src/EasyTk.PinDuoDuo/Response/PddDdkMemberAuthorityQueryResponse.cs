using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkMemberAuthorityQueryResponse : BaseResponse<PddDdkMemberAuthorityQueryResponse.PddDdkMemberAuthorityQueryResponseData>
    {
        /// <summary>
        /// authority_query_response	OBJECT		查询结果
        /// </summary>
        [JsonProperty("authority_query_response")]
        public override PddDdkMemberAuthorityQueryResponseData Data { get; set; }

        public class PddDdkMemberAuthorityQueryResponseData
        {
            /// <summary>
            /// bind	 INTEGER		1-已绑定；0-未绑定
            /// </summary>
            [JsonProperty("bind")]
            public int Bind { get; set; }
        }
    }
}
