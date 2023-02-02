using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public  class GetOrderResponse
    {
        /// <summary>
        /// ads_estimated_commission	Number	0	Live：直播间分销渠道预估佣金收入，单位分 2. Activity&Mix：预估推广费收入
        /// </summary>
        [JsonProperty("ads_estimated_commission")]
        public long AdsEstimatedCommission { get; set; }

        /// <summary>
        /// ads_real_commission	Number	0	Live：直播间分销渠道实际佣金收入，单位分 2. Activity&Mix：结算推广费收入
        /// </summary>
        [JsonProperty("ads_real_commission")]
        public long AdsRealCommission { get; set; }

        /// <summary>
        /// commission_rate	Number	36.8	达人佣金率
        /// </summary>
        [JsonProperty("commission_rate")]
        public double CommissionRate { get; set; }

        /// <summary>
        /// estimated_total_commission	Number	3.64	总佣金（预估），对应百应订单明细中的总佣金
        /// </summary>
        [JsonProperty("estimated_total_commission")]
        public double EstimatedTotalCommission { get; set; }

        /// <summary>
        /// external_info	String	_12345_0200	外部参数（转链时传入的自定义参数）
        /// </summary>
        [JsonProperty("external_info")]
        public string ExternalInfo { get; set; }

        /// <summary>
        /// flow_point	String	REFUND	订单状态(PAY_SUCC:支付完成 REFUND:退款 SETTLE:结算 CONFIRM: 确认收货)
        /// </summary>
        [JsonProperty("flow_point")]
        public string FlowPoint { get; set; }

        /// <summary>
        /// item_num	Number	1	商品数目
        /// </summary>
        [JsonProperty("item_num")]
        public long ItemNum { get; set; }

        /// <summary>
        /// media_type_name	String	ProductDetail	Live-直播间，ProductDetail-商品详情，Activity-活动（百亿补贴/秒杀）Mix-H5自建活动页
        /// </summary>
        [JsonProperty("media_type_name")]
        public string MediaTypeName { get; set; }

        /// <summary>
        /// order_id	String	4914979806968080000	订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// pay_goods_amount	Number	9.9	预估参与结算金额
        /// </summary>
        [JsonProperty("pay_goods_amount")]
        public double PayGoodsAmount { get; set; }

        /// <summary>
        /// pay_success_time	String	44648.6527430556	付款时间
        /// </summary>
        [JsonProperty("pay_success_time")]
        public string PaySuccessTime { get; set; }

        /// <summary>
        /// product_id	String	3467721180142820000	商品id
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// product_img	String	https://p3-aio.ecombdimg.com/obj/temai/c79c3356382e1c044db37e652f7128b2www800-800	商品图片URL
        /// </summary>
        [JsonProperty("product_img")]
        public string ProductImg { get; set; }

        /// <summary>
        /// real_commission	Number	0	达人实际佣金收入
        /// </summary>
        [JsonProperty("real_commission")]
        public double RealCommission { get; set; }

        /// <summary>
        /// product_name	String	9.9三卷包邮 抽绳式垃圾袋 家用手提式垃圾袋 加厚自动收口垃圾袋	商品名称
        /// </summary>
        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// refund_time	String	44648.6734143519	退款订单退款时间
        /// </summary>
        [JsonProperty("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// settle_time	String	2022-11-10 00:00:00	结算时间，结算前为空字符串
        /// </summary>
        [JsonProperty("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// settled_goods_amount	Number	0	实际参与结算金额
        /// </summary>
        [JsonProperty("settled_goods_amount")]
        public double SettledGoodsAmount { get; set; }

        /// <summary>
        /// shop_name	String	大鸣爆品供应链	商家名称
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// total_pay_amount	Number	9.8	订单支付金额
        /// </summary>
        [JsonProperty("total_pay_amount")]
        public double TotalPayAmount { get; set; }

        /// <summary>
        /// update_time	String	2022-11-10 00:00:00	订单更新时间
        /// </summary>
        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }
    }
}
