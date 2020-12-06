using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkGoodsPidQueryResponse : BaseResponse<PddDdkGoodsPidQueryResponse.PddDdkGoodsPidQueryData>
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("p_id_query_response")]
        public override PddDdkGoodsPidQueryData Data { get; set; }

        public class PddDdkGoodsPidQueryData : BaseResponseData
        {
            /// <summary>
            /// 多多进宝推广位对象列表
            /// </summary>
            [JsonProperty("p_id_list")]
            public PddDdkGoodsPidQueryDataItem[] PIdList { get; set; }

            /// <summary>
            /// 返回推广位总数
            /// </summary>
            [JsonProperty("total_count")]
            public long? TotalCount { get; set; }
        }

        public class PddDdkGoodsPidQueryDataItem
        {
            /// <summary>
            /// 推广位生成时间
            /// </summary>
            [JsonProperty("create_time")]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 推广位名称
            /// </summary>
            [JsonProperty("pid_name")]
            public string PidName { get; set; }

            /// <summary>
            /// 推广位ID
            /// </summary>
            [JsonProperty("p_id")]
            public string PId { get; set; }

            /// <summary>
            /// status	INTEGER		推广位状态：0-正常，1-封禁
            /// </summary>
            [JsonProperty("status")]
            public int Status { get; set; }

            /// <summary>
            /// media_id	 LONG		媒体id
            /// </summary>
            [JsonProperty("media_id")]
            public long MediaId { get; set; }
        }
    }
}
