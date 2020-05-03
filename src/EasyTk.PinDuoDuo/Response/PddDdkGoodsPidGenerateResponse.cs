using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkGoodsPidGenerateResponse : BaseResponse
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("p_id_generate_response")]
        public PddDdkGoodsPidGenerateData PIdGenerateResponse { get; set; }

        public class PddDdkGoodsPidGenerateData : BaseResponseData
        {
            /// <summary>
            /// 多多进宝推广位对象列表
            /// </summary>
            [JsonProperty("p_id_list")]
            public PddDdkGoodsPidGenerateDataItem[] PIdList { get; set; }

            /// <summary>
            /// PID剩余数量
            /// </summary>
            [JsonProperty("remain_pid_count")]
            public long? RemainPidCount { get; set; }
        }

        public class PddDdkGoodsPidGenerateDataItem
        {
            /// <summary>
            /// 推广位创建时间
            /// </summary>
            [JsonProperty("create_time")]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 推广位名称
            /// </summary>
            [JsonProperty("pid_name")]
            public string PidName { get; set; }

            /// <summary>
            /// 调用方推广位ID
            /// </summary>
            [JsonProperty("p_id")]
            public string PId { get; set; }
        }
    }
}
