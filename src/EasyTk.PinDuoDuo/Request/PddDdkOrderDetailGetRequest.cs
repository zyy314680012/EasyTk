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

        #endregion
    }
}
