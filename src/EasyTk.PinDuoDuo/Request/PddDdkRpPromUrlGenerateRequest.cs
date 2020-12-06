﻿using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 生成营销工具推广链接
    /// </summary>
    public class PddDdkRpPromUrlGenerateRequest : BaseRequest<PddDdkRpPromUrlGenerateResponse>
    {
        public override string Type => "pdd.ddk.rp.prom.url.generate";

        #region 

        /// <summary>
        /// amount	LONG	非必填	初始金额（单位分），有效金额枚举值：300、500、700、1100和1600，默认300
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// -1-活动列表，0-默认红包，2–新人红包，3-刮刮卡，5-员工内购，6-购物车，7-大促会场，8-直播间列表集合页，10-生成绑定备案链接，11-生成超级红包（仅支持微信小程序），12-砸金蛋
        /// </summary>
        [JsonProperty("channel_type")]
        public long? ChannelType { get; set; }

        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }

        /// <summary>
        /// 转盘自定义参数
        /// </summary>
        [JsonProperty("diy_lottery_param")]
        public DiyLotteryParamData DiyLotteryParam { get; set; }

        /// <summary>
        /// 红包自定义参数
        /// </summary>
        [JsonProperty("diy_red_packet_param")]
        public DiyRedPacketParamData DiyRedPacketParam { get; set; }

        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        [JsonProperty("generate_qq_app")]
        public bool? GenerateQqApp { get; set; }

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        [JsonProperty("generate_schema_url")]
        public bool? GenerateSchemaUrl { get; set; }

        /// <summary>
        /// 是否生成短链接。true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }

        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        [JsonProperty("generate_we_app")]
        public bool? GenerateWeApp { get; set; }

        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        [JsonProperty("p_id_list")]
        public string[] PIdList { get; set; }

        /// <summary>
        /// scratch_card_amount	LONG	非必填	刮刮卡指定金额（单位分），可指定2-100元间数值，即有效区间为：[200,10000]
        /// </summary>
        [JsonProperty("scratch_card_amount")]
        public long? ScratchCardAmount { get; set; }

        public class DiyLotteryParamData
        {
            /// <summary>
            /// 优先展示类目
            /// </summary>
            [JsonProperty("opt_id")]
            public long? OptId { get; set; }

            /// <summary>
            /// 自定义价格和商品佣金区间
            /// </summary>
            [JsonProperty("range_items")]
            public RangeItem[] RangeItems { get; set; }
        }

        public class DiyRedPacketParamData
        {
            /// <summary>
            /// 红包金额列表，200、300、500、1000、2000，单位分。红包金额和红包抵后价设置只能二选一，默认设置了红包金额会忽略红包抵后价设置
            /// </summary>
            [JsonProperty("amount_probability")]
            public long[] AmountProbability { get; set; }

            /// <summary>
            /// 设置玩法，false-现金红包, true-现金券
            /// </summary>
            [JsonProperty("dis_text")]
            public bool? DisText { get; set; }

            /// <summary>
            /// 推广页设置，false-红包开启页, true-红包领取页
            /// </summary>
            [JsonProperty("not_show_background")]
            public bool? NotShowBackground { get; set; }

            /// <summary>
            /// 优先展示类目
            /// </summary>
            [JsonProperty("opt_id")]
            public long? OptId { get; set; }

            /// <summary>
            /// 自定义红包抵后价和商品佣金区间对象数组
            /// </summary>
            [JsonProperty("range_items")]
            public RangeItem[] RangeItems { get; set; }
        }

        public class RangeItem
        {
            /// <summary>
            /// 区间的开始值
            /// </summary>
            [JsonProperty("range_from")]
            public long? RangeFrom { get; set; }

            /// <summary>
            /// range_id为1表示价格（单位分）， range_id为2表示商品佣金（单位千分之几)
            /// </summary>
            [JsonProperty("range_id")]
            public long? RangeId { get; set; }

            /// <summary>
            /// 区间的结束值
            /// </summary>
            [JsonProperty("range_to")]
            public long? RangeTo { get; set; }
        }

        #endregion
    }
}
