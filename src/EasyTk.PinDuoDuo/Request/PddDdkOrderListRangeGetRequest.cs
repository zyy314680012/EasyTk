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
        /// end_time	 STRING	必填	支付结束时间，格式: "yyyy-MM-dd HH:mm:ss" ，比如 "2020-12-01 00:00:00"
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
        /// query_order_type	INTEGER	非必填	订单类型：1-推广订单；2-直播间订单
        /// </summary>
        [JsonProperty("query_order_type")]
        public int? QueryOrderType { get; set; }

        /// <summary>
        /// start_time	STRING	必填	支付起始时间，格式: "yyyy-MM-dd HH:mm:ss" ，比如 "2020-12-01 00:00:00"
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        #endregion
    }
}
