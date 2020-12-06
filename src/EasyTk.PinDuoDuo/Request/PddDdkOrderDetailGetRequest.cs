using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    public class PddDdkOrderDetailGetRequest : BaseRequest<PddDdkOrderDetailGetResponse>
    {
        public override string Type => "pdd.ddk.order.detail.get";

        #region 

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// query_order_type	 INTEGER	非必填	订单类型：1-推广订单；2-直播间订单
        /// </summary>
        [JsonProperty("query_order_type")]
        public int? QueryOrderType { get; set; }

        #endregion
    }
}
