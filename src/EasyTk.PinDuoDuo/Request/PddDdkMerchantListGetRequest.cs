using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    public class PddDdkMerchantListGetRequest : BaseRequest<PddDdkMerchantListGetResponse>
    {
        public override string Type => "pdd.ddk.merchant.list.get";

        #region 

        /// <summary>
        /// 商品类目ID，使用pdd.goods.cats.get接口获取
        /// </summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }

        /// <summary>
        /// 是否有店铺收藏券 （true 所有；false 必须有券）
        /// </summary>
        [JsonProperty("has_clt_cpn")]
        public bool? HasCltCpn { get; set; }

        /// <summary>
        /// 是否有优惠券 （0 所有；1 必须有券）
        /// </summary>
        [JsonProperty("has_coupon")]
        public long? HasCoupon { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("mall_id_list")]
        public long[] MallIdList { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [JsonProperty("merchant_type_list")]
        public long[] MerchantTypeList { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page_number")]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; }

        /// <summary>
        /// 查询范围0----商品拼团价格区间；1----商品券后价价格区间；2----佣金比例区间；3----优惠券金额区间；4----加入多多进宝时间区间；5----销量区间；6----佣金金额区间
        /// </summary>
        [JsonProperty("query_range_str")]
        public long? QueryRangeStr { get; set; }

        /// <summary>
        /// 筛选范围
        /// </summary>
        [JsonProperty("range_vo_list")]
        public RangeVo[] RangeVoList { get; set; }

        public class RangeVo
        {
            /// <summary>
            /// 范围起始值
            /// </summary>
            [JsonProperty("range_from")]
            public string RangeFrom { get; set; }

            /// <summary>
            /// 0，最小成团价 1，券后价 2，佣金比例 3，优惠券价格 4，广告创建时间 5，销量 6，佣金金额 7，店铺描述分 8，店铺物流分 9，店铺服务分 10， 店铺描述分击败同行业百分比 11， 店铺物流分击败同行业百分比 12，店铺服务分击败同行业百分比 13，商品分 17 ，优惠券/最小团购价 18，过去两小时pv 19，过去两小时销量
            /// </summary>
            [JsonProperty("range_id")]
            public string RangeId { get; set; }

            /// <summary>
            /// 范围结束值
            /// </summary>
            [JsonProperty("range_to")]
            public string RangeTo { get; set; }
        }

        #endregion
    }
}
