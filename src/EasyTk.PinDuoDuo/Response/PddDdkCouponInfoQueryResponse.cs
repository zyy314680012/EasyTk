using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkCouponInfoQueryResponse : BaseResponse
    {
        /// <summary>
        /// ddk_coupon_info_query
        /// </summary>
        [JsonProperty("ddk_coupon_info_query_response")]
        public PddDdkCouponInfoQueryData DdkCouponInfoQueryResponse { get; set; }


        public class PddDdkCouponInfoQueryData : BaseResponseData
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("list")]
            public PddDdkCouponInfoQueryDataItem[] List { get; set; }


        }

        public class PddDdkCouponInfoQueryDataItem
        {
            /// <summary>
            /// 优惠券结束时间
            /// </summary>
            [JsonProperty("coupon_end_time")]
            public long? CouponEndTime { get; set; }

            /// <summary>
            /// 优惠券id
            /// </summary>
            [JsonProperty("coupon_id")]
            public string CouponId { get; set; }

            /// <summary>
            /// 优惠券开始时间
            /// </summary>
            [JsonProperty("coupon_start_time")]
            public long? CouponStartTime { get; set; }

            /// <summary>
            /// 优惠券类型
            /// </summary>
            [JsonProperty("coupon_type")]
            public long? CouponType { get; set; }

            /// <summary>
            /// 优惠券面额 单位：厘
            /// </summary>
            [JsonProperty("discount")]
            public long? Discount { get; set; }

            /// <summary>
            /// 优惠券总量
            /// </summary>
            [JsonProperty("init_quantity")]
            public long? InitQuantity { get; set; }

            /// <summary>
            /// 优惠券剩余数量
            /// </summary>
            [JsonProperty("remain_quantity")]
            public long? RemainQuantity { get; set; }
        }
    }
}
