﻿using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkOrderListRangeGetResponse : BaseResponse<PddDdkOrderListRangeGetResponse.PddDdkOrderListRangeGetData>
    {
        /// <summary>
        /// order_list_get_response
        /// </summary>
        [JsonProperty("order_list_get_response")]
        public override PddDdkOrderListRangeGetData Data { get; set; }

        public class PddDdkOrderListRangeGetData : BaseResponseData
        {
            /// <summary>
            /// last_order_id
            /// </summary>
            [JsonProperty("last_order_id")]
            public string LastOrderId { get; set; }

            /// <summary>
            /// 多多进宝推广位对象列表
            /// </summary>
            [JsonProperty("order_list")]
            public PddDdkOrderListRangeGetDataItem[] OrderList { get; set; }
        }

        public class PddDdkOrderListRangeGetDataItem
        {

            /// <summary>
            /// 多多客工具id
            /// </summary>
            [JsonProperty("auth_duo_id")]
            public long? AuthDuoId { get; set; }

            /// <summary>
            /// 结算批次号
            /// </summary>
            [JsonProperty("batch_no")]
            public string BatchNo { get; set; }

            /// <summary>
            /// 商品一~四级类目ID列表
            /// </summary>
            [JsonProperty("cat_ids")]
            public long[] CatIds { get; set; }

            /// <summary>
            /// 是否是 cpa 新用户，1表示是，0表示否
            /// </summary>
            [JsonProperty("cpa_new")]
            public long? CpaNew { get; set; }

            /// <summary>
            /// 自定义参数
            /// </summary>
            [JsonProperty("custom_parameters")]
            public string CustomParameters { get; set; }

            /// <summary>
            /// 订单审核失败原因
            /// </summary>
            [JsonProperty("fail_reason")]
            public string FailReason { get; set; }

            /// <summary>
            /// 商品ID
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品标题
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 订单中sku的单件价格，单位为分
            /// </summary>
            [JsonProperty("goods_price")]
            public long? GoodsPrice { get; set; }

            /// <summary>
            /// 购买商品的数量
            /// </summary>
            [JsonProperty("goods_quantity")]
            public long? GoodsQuantity { get; set; }

            /// <summary>
            /// goods_sign	STRING		商品goodsSign
            /// </summary>
            [JsonProperty("goods_sign")]
            public string GoodsSign { get; set; }

            /// <summary>
            /// 商品缩略图
            /// </summary>
            [JsonProperty("goods_thumbnail_url")]
            public string GoodsThumbnailUrl { get; set; }

            /// <summary>
            /// 成团编号
            /// </summary>
            [JsonProperty("group_id")]
            public long? GroupId { get; set; }

            /// <summary>
            /// is_direct	INTEGER		是否直推 ，1表示是，0表示否
            /// </summary>
            [JsonProperty("is_direct")]
            public int? IsDirect { get; set; }

            /// <summary>
            /// 实际支付金额，单位为分
            /// </summary>
            [JsonProperty("order_amount")]
            public long? OrderAmount { get; set; }

            /// <summary>
            /// 订单生成时间，UNIX时间戳
            /// </summary>
            [JsonProperty("order_create_time")]
            public long? OrderCreateTime { get; set; }

            /// <summary>
            /// 成团时间
            /// </summary>
            [JsonProperty("order_group_success_time")]
            public long? OrderGroupSuccessTime { get; set; }

            /// <summary>
            /// 最后更新时间
            /// </summary>
            [JsonProperty("order_modify_at")]
            public long? OrderModifyAt { get; set; }

            /// <summary>
            /// 支付时间
            /// </summary>
            [JsonProperty("order_pay_time")]
            public long? OrderPayTime { get; set; }

            /// <summary>
            /// 推广订单编号
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 订单状态： -1 未支付; 0-已支付；1-已成团；2-确认收货；3-审核成功；4-审核失败（不可提现）；5-已经结算；8-非多多进宝商品（无佣金订单）
            /// </summary>
            [JsonProperty("order_status")]
            public long? OrderStatus { get; set; }

            /// <summary>
            /// 订单状态描述
            /// </summary>
            [JsonProperty("order_status_desc")]
            public string OrderStatusDesc { get; set; }

            /// <summary>
            /// 审核时间
            /// </summary>
            [JsonProperty("order_verify_time")]
            public long? OrderVerifyTime { get; set; }

            /// <summary>
            /// 佣金金额，单位为分
            /// </summary>
            [JsonProperty("promotion_amount")]
            public long? PromotionAmount { get; set; }

            /// <summary>
            /// 佣金比例，千分比
            /// </summary>
            [JsonProperty("promotion_rate")]
            public long? PromotionRate { get; set; }

            /// <summary>
            /// 推广位ID
            /// </summary>
            [JsonProperty("p_id")]
            public string PId { get; set; }

            /// <summary>
            /// sep_duo_id	LONG		直播间订单推广duoId
            /// </summary>
            [JsonProperty("sep_duo_id")]
            public long? SepDuoId { get; set; }

            /// <summary>
            /// sep_market_fee	INTEGER		直播间推广佣金
            /// </summary>
            [JsonProperty("sep_market_fee")]
            public long? SepMarketFee { get; set; }

            /// <summary>
            /// sep_parameters	STRING		直播间推广自定义参数
            /// </summary>
            [JsonProperty("sep_parameters")]
            public string SepParameters { get; set; }

            /// <summary>
            /// sep_pid	STRING		直播间订单推广位
            /// </summary>
            [JsonProperty("sep_pid")]
            public string SepPid { get; set; }

            /// <summary>
            /// sep_rate	 INTEGER		直播间推广佣金比例
            /// </summary>
            [JsonProperty("sep_rate")]
            public string SepRate { get; set; }

            /// <summary>
            /// 订单类型：0：领券页面， 1： 红包页， 2：领券页， 3： 题页
            /// </summary>
            [JsonProperty("type")]
            public long? Type { get; set; }

            /// <summary>
            /// 招商多多客id
            /// </summary>
            [JsonProperty("zs_duo_id")]
            public long? ZsDuoId { get; set; }
        }
    }
}
