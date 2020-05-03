using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 用时间段查询推广订单接口
    /// </summary>
    public class PddDdkOrderListRangeGetRequest : BaseRequest<PddDdkOrderListRangeGetResponse>
    {
        public override string Type => "pdd.ddk.order.list.range.get";

        #region 

        /// <summary>
        /// 支付结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 上一次的迭代器id(第一次不填)
        /// </summary>
        [JsonProperty("last_order_id")]
        public string LastOrderId { get; set; }

        /// <summary>
        /// 每次请求多少条，建议300
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; }

        /// <summary>
        /// 支付起始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        #endregion
    }
}
