using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    public class PddDdkFinanceCpaQueryRequest : BaseRequest<PddDdkFinanceCpaQueryResponse>
    {
        public override string Type => "pdd.ddk.finance.cpa.query";

        #region

        /// <summary>
        /// 查询日期，格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty("date_query")]
        public string DateQuery { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        #endregion
    }
}
