using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    /// <summary>
    /// 抖客订单
    /// https://www.dataoke.com/kfpt/api-d.html?id=106
    /// </summary>
    public class GetOrderRequest : BaseRequest<WrapperResponseDouYinOrderList<GetOrderResponse>>
    {
        public override string GetApiUrl() => "https://openapiv2.dataoke.com/open-api/tiktok/order-list";

        public override string Version => "v1.0.0";

        #region
        /// <summary>
        ///   order_ids String  否   订单id，多个以,连接
        /// </summary>
        [JsonProperty("order_ids")]
        public string OrderIds { get; set; }

        /// <summary>
        ///  start_time String  否   订单开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// external_info	String	否	自定义参数（通过转链接口传入的自定义参数，可用于区分不同用户的订单）
        /// </summary>
        [JsonProperty("external_info")]
        public string ExternalInfo { get; set; }

        /// <summary>
        /// end_time	String	否	订单结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// page	String	否	页码
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// size	String	否	每页数量
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// date_type	String	否	1付款时间（默认）2结算时间 3退款时间
        /// </summary>
        [JsonProperty("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// order_type	String	是	【11.25新增字段】订单渠道类型：1、商品分销订单；2、直播间分销订单（直播间转链产生的订单，不含直播间商品列表转链产生的）
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }
        #endregion
    }
}
