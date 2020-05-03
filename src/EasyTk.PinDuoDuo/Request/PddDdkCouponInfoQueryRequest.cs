using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 查询优惠券信息
    /// </summary>
    public class PddDdkCouponInfoQueryRequest : BaseRequest<PddDdkCouponInfoQueryResponse>
    {
        public override string Type => "pdd.ddk.coupon.info.query";

        #region 

        /// <summary>
        /// 优惠券id
        /// </summary>
        [JsonProperty("coupon_ids")]
        public string[] CouponIds { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("mall_ids")]
        public long[] MallIds { get; set; }

        #endregion
    }
}
