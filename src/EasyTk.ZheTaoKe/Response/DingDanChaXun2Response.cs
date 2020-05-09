using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EasyTk.Helpers;

namespace EasyTk.ZheTaoKe.Response
{
    /// <summary>
    /// 初始返回值为阿里妈妈url，请调用 GetAlimamaData
    /// </summary>
    public class DingDanChaXun2Response : BaseResponse
    {
        /// <summary>
        /// 淘宝联盟请求地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 获取阿里妈妈数据
        /// </summary>
        /// <returns></returns>
        public async Task<DingDanChaXun2TbkResponse> GetAlimamaData()
        {
            HttpResponseMessage response = null;
            using (var client = HttpHelper.HttpClientFactory.CreateClient())
            {
                response = await client.GetAsync(Url);
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    var result = JsonConvert.DeserializeObject<DingDanChaXun2TbkResponse>(content);
                    result.Body = content;
                    return result;
                }
            }

            return default;
        }

    }

    public class DingDanChaXun2TbkResponse : BaseResponse
    {
        [JsonProperty("tbk_sc_order_details_get_response")]
        public DingDanChaXun2DataResponse Response { get; set; }

        public class DingDanChaXun2DataResponse
        {
            [JsonProperty("data")]
            public DingDanChaXun2Data Data { get; set; }
        }

        public class DingDanChaXun2Data
        {
            [JsonProperty("results")]
            public DingDanChaXun2DataResults Results { get; set; }

            [JsonProperty("has_pre")]
            public bool HasPre { get; set; }

            [JsonProperty("position_index")]
            public string PositionIndex { get; set; }

            [JsonProperty("has_next")]
            public bool HasNext { get; set; }

            [JsonProperty("page_no")]
            public long PageNo { get; set; }

            [JsonProperty("page_size")]
            public long PageSize { get; set; }
        }

        public class DingDanChaXun2DataResults
        {
            [JsonProperty("publisher_order_dto")]
            public DingDanChaXun2DataResultDto[] List { get; set; }
        }

        public class DingDanChaXun2DataResultDto
        {
            ///<summary>
            /// 订单在淘宝拍下付款的时间
            ///tb_paid_time "2019-04-22 15:15:05",
            ///</summary>
            [JsonProperty("tb_paid_time")]
            public DateTime? TbPaidTime { get; set; }

            ///<summary>
            /// 订单付款的时间，该时间同步淘宝，可能会略晚于买家在淘宝的订单创建时间
            ///tk_paid_time "2019-04-22 15:15:05",
            ///</summary>
            [JsonProperty("tk_paid_time")]
            public DateTime? TkPaidTime { get; set; }

            ///<summary>
            /// 买家确认收货的付款金额（不包含运费金额）
            ///pay_price "9.11",
            ///</summary>
            [JsonProperty("pay_price")]
            public float? PayPrice { get; set; }

            ///<summary>
            /// 结算预估收入=结算金额*提成。以买家确认收货的付款金额为基数，预估您可能获得的收入。因买家退款、您违规推广等原因，可能与您最终收入不一致。最终收入以月结后您实际收到的为准
            ///pub_share_fee "0",
            ///</summary>
            [JsonProperty("pub_share_fee")]
            public float? PubShareFee { get; set; }

            ///<summary>
            /// 买家通过购物车购买的每个商品对应的订单编号，此订单编号并未在淘宝买家后台透出
            ///trade_id "294159887445064307",
            ///</summary>
            [JsonProperty("trade_id")]
            public string TradeId { get; set; }

            ///<summary>
            /// 二方：佣金收益的第一归属者； 三方：从其他淘宝客佣金中进行分成的推广者
            ///tk_order_role 2,
            ///</summary>
            [JsonProperty("tk_order_role")]
            public int? TkOrderRole { get; set; }

            ///<summary>
            /// 订单确认收货后且商家完成佣金支付的时间
            ///tk_earning_time "2019-04-22 15:15:05",
            ///</summary>
            [JsonProperty("tk_earning_time")]
            public DateTime? TkEarningTime { get; set; }

            ///<summary>
            /// 推广位管理下的推广位名称对应的ID，同时也是pid=mm_1_2_3中的“3”这段数字
            ///adzone_id 11,
            ///</summary>
            [JsonProperty("adzone_id")]
            public long? AdzoneId { get; set; }

            ///<summary>
            /// 从结算佣金中分得的收益比率
            ///pub_share_rate "100",
            ///</summary>
            [JsonProperty("pub_share_rate")]
            public float? PubShareRate { get; set; }

            ///<summary>
            /// 维权标签，0 含义为非维权 1 含义为维权订单
            ///refund_tag 0,      /*维权标签，0 含义为非维权 1 含义为维权订单，已经实现*/
            ///</summary>
            [JsonProperty("refund_tag")]
            public int? RefundTag { get; set; }

            ///<summary>
            /// 平台给与的补贴比率，如天猫、淘宝、聚划算等
            ///subsidy_rate "0",
            ///</summary>
            [JsonProperty("subsidy_rate")]
            public float? SubsidyRate { get; set; }

            ///<summary>
            /// 提成=收入比率*分成比率。指实际获得收益的比率
            ///tk_total_rate "9.99",
            ///</summary>
            [JsonProperty("tk_total_rate")]
            public float? TkTotalRate { get; set; }

            ///<summary>
            /// 商品所属的根类目，即一级类目的名称
            ///item_category_name "淘小铺",
            ///</summary>
            [JsonProperty("item_category_name")]
            public string ItemCategoryName { get; set; }

            ///<summary> 
            ///seller_nick "--",
            ///</summary>
            [JsonProperty("seller_nick")]
            public string SellerNick { get; set; }

            ///<summary>
            /// 推广者的会员id
            ///pub_id 98836808,
            ///</summary>
            [JsonProperty("pub_id")]
            public long? PubId { get; set; }

            ///<summary>
            /// 推广者赚取佣金后支付给阿里妈妈的技术服务费用的比率
            ///alimama_rate "0",
            ///</summary>
            [JsonProperty("alimama_rate")]
            public float? AlimamaRate { get; set; }

            ///<summary>
            /// 平台出资方，如天猫、淘宝、或聚划算等
            ///subsidy_type "--",
            ///</summary>
            [JsonProperty("subsidy_type")]
            public string SubsidyType { get; set; }

            ///<summary>
            /// 商品图片
            ///item_img "\/\/img.alicdn.com\/bao\/uploaded\/i1\/2200782262419\/O1CN01b5qlop1TjwarUo8fo_!!2200782262419.jpg",
            ///</summary>
            [JsonProperty("item_img")]
            public string ItemImg { get; set; }

            ///<summary>
            /// 付款预估收入=付款金额*提成。指买家付款金额为基数，预估您可能获得的收入。因买家退款等原因，可能与结算预估收入不一致
            ///pub_share_pre_fee "0",
            ///</summary>
            [JsonProperty("pub_share_pre_fee")]
            public string PubSharePreFee { get; set; }

            ///<summary>
            /// 买家拍下付款的金额（不包含运费金额）
            ///alipay_total_price "11.22",
            ///</summary>
            [JsonProperty("alipay_total_price")]
            public string AlipayTotalPrice { get; set; }

            ///<summary>
            /// 商品标题
            ///item_title "tsh_rj_测试请不要拍_阶佣11.1",
            ///</summary>
            [JsonProperty("item_title")]
            public string ItemTitle { get; set; }

            ///<summary>
            /// 媒体管理下的对应ID的自定义名称
            ///site_name "合伙人",
            ///</summary>
            [JsonProperty("site_name")]
            public string SiteName { get; set; }

            ///<summary>
            /// 商品数量
            ///item_num 2,
            ///</summary>
            [JsonProperty("item_num")]
            public long? ItemNum { get; set; }

            ///<summary>
            /// 补贴金额=结算金额*补贴比率
            ///subsidy_fee "0",
            ///</summary>
            [JsonProperty("subsidy_fee")]
            public float? SubsidyFee { get; set; }

            ///<summary>
            /// 技术服务费=结算金额*收入比率*技术服务费率。推广者赚取佣金后支付给阿里妈妈的技术服务费用
            ///alimama_share_fee "0",
            ///</summary>
            [JsonProperty("alimama_share_fee")]
            public float? AlimamaShareFee { get; set; }

            ///<summary>
            /// 买家在淘宝后台显示的订单编号
            ///trade_parent_id "294159887445064307",
            ///</summary>
            [JsonProperty("trade_parent_id")]
            public string TradeParentId { get; set; }

            ///<summary>
            /// 订单所属平台类型，包括天猫、淘宝、聚划算等
            ///order_type "如意淘",
            ///</summary>
            [JsonProperty("order_type")]
            public string OrderType { get; set; }

            ///<summary>
            /// 订单创建的时间，该时间同步淘宝，可能会略晚于买家在淘宝的订单创建时间
            ///tk_create_time "2019-04-22 15:15:05",
            ///</summary>
            [JsonProperty("tk_create_time")]
            public DateTime? TkCreateTime { get; set; }

            ///<summary>
            /// 产品类型
            ///flow_source "--",
            ///</summary>
            [JsonProperty("flow_source")]
            public string FlowSource { get; set; }

            ///<summary>
            /// 成交平台
            ///terminal_type "无线",
            ///</summary>
            [JsonProperty("terminal_type")]
            public string TerminalType { get; set; }

            ///<summary>
            /// 通过推广链接达到商品、店铺详情页的点击时间
            ///click_time "2019-04-22 15:14:55",
            ///</summary>
            [JsonProperty("click_time")]
            public DateTime? ClickTime { get; set; }

            ///<summary>
            /// 已付款：指订单已付款，但还未确认收货 已收货：指订单已确认收货，但商家佣金未支付 已结算：指订单已确认收货，且商家佣金已支付成功 已失效：指订单关闭/订单佣金小于0.01元，订单关闭主要有：1）买家超时未付款； 2）买家付款前，买家/卖家取消了订单；3）订单付款后发起售中退款成功；3：订单结算，12：订单付款， 13：订单失效，14：订单成功
            ///tk_status 13,
            ///</summary>
            [JsonProperty("tk_status")]
            public long TkStatus { get; set; }

            ///<summary>
            /// 商品单价
            ///item_price "2.1",
            ///</summary>
            [JsonProperty("item_price")]
            public float? ItemPrice { get; set; }

            ///<summary>
            /// 商品id
            ///item_id 590141576510,
            ///</summary>
            [JsonProperty("item_id")]
            public long ItemId { get; set; }

            ///<summary>
            /// 推广位管理下的自定义推广位名称
            ///adzone_name "",
            ///</summary>
            [JsonProperty("adzone_name")]
            public string AdzoneName { get; set; }

            ///<summary>
            /// 佣金比率
            ///total_commission_rate "9.99",
            ///</summary>
            [JsonProperty("total_commission_rate")]
            public float? TotalCommissionRate { get; set; }

            ///<summary>
            /// 商品链接
            ///item_link "",
            ///</summary>
            [JsonProperty("item_link")]
            public string ItemLink { get; set; }

            ///<summary>
            /// 媒体管理下的ID，同时也是pid=mm_1_2_3中的“2”这段数字
            ///site_id 45598009,
            ///</summary>
            [JsonProperty("site_id")]
            public long? SiteId { get; set; }

            ///<summary>
            /// 店铺名称
            ///seller_shop_title "--",
            ///</summary>
            [JsonProperty("seller_shop_title")]
            public string SellerShopTitle { get; set; }

            ///<summary>
            /// 订单结算的佣金比率+平台的补贴比率
            ///income_rate "9.99",
            ///</summary>
            [JsonProperty("income_rate")]
            public float? IncomeRate { get; set; }

            ///<summary>
            /// 佣金金额=结算金额*佣金比率
            ///total_commission_fee "0",
            ///</summary>
            [JsonProperty("total_commission_fee")]
            public float? TotalCommissionFee { get; set; }

            ///<summary>
            /// 预估专项服务费：内容场景专项技术服务费，内容推广者在内容场景进行推广需要支付给阿里妈妈专项的技术服务费用。专项服务费＝付款金额＊专项服务费率。
            ///tk_commission_pre_fee_for_media_platform "1.05",
            ///</summary>
            [JsonProperty("tk_commission_pre_fee_for_media_platform")]
            public float? TkCommissionPreFeeForMediaPlatform { get; set; }

            ///<summary>
            /// 结算专项服务费：内容场景专项技术服务费，内容推广者在内容场景进行推广需要支付给阿里妈妈专项的技术服务费用。专项服务费＝结算金额＊专项服务费率。
            ///tk_commission_fee_for_media_platform "1.05",
            ///</summary>
            [JsonProperty("tk_commission_fee_for_media_platform")]
            public float? TkCommissionFeeForMediaPlatform { get; set; }

            ///<summary>
            /// 专项服务费率：内容场景专项技术服务费率，内容推广者在内容场景进行推广需要按结算金额支付一定比例给阿里妈妈作为内容场景专项技术服务费，用于提供与内容平台实现产品技术对接等服务。
            ///tk_commission_rate_for_media_platform "0.01",
            ///</summary>
            [JsonProperty("tk_commission_rate_for_media_platform")]
            public float? TkCommissionRateForMediaPlatform { get; set; }

            ///<summary>
            /// 会员运营id
            ///special_id 2323,
            ///</summary>
            [JsonProperty("special_id")]
            public long? SpecialId { get; set; }

            ///<summary>
            /// 渠道关系id
            ///relation_id 2323
            ///</summary>
            [JsonProperty("relation_id")]
            public long? RelationId { get; set; }


            ///<summary> 
            ///tk_deposit_time String	2019-09-09 12:01:01	预售时期，用户对预售商品支付定金的付款时间，可能略晚于在淘宝付定金时间
            ///</summary>
            [JsonProperty("tk_deposit_time")]
            public DateTime? TkDepositTime { get; set; }

            ///<summary> 
            ///tb_deposit_time String	2019-09-09 12:01:01	预售时期，用户对预售商品支付定金的付款时间
            ///</summary>
            [JsonProperty("tb_deposit_time")]
            public DateTime? TbDepositTime { get; set; }

            ///<summary> 
            ///deposit_price String	122.22	预售时期，用户对预售商品支付的定金金额
            ///</summary>
            [JsonProperty("deposit_price")]
            public float? DepositPrice { get; set; }

            ///<summary> 
            ///app_key String	112121	开发者调用api的appkey
            ///</summary>
            [JsonProperty("app_key")]
            public string AppKey { get; set; }

            ///<summary> 
            ///alsc_id String	2332	口碑子订单号
            ///</summary>
            [JsonProperty("alsc_id")]
            public string AlscId { get; set; }

            ///<summary> 
            ///alsc_pid String	32324	口碑父订单号
            ///</summary>
            [JsonProperty("alsc_pid")]
            public string AlscPid { get; set; }
        }
    }
}
