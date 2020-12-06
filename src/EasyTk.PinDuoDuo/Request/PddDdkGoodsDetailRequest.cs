using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 多多进宝商品详情查询
    /// </summary>
    public class PddDdkGoodsDetailRequest : BaseRequest<PddDdkGoodsDetailResponse>
    {
        public override string Type => "pdd.ddk.goods.detail";

        #region 

        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }

        /// <summary>
        /// 商品ID，仅支持单个查询。例如：[123456]
        /// </summary>
        [JsonProperty("goods_id_list")]
        public long[] GoodsIdList { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 佣金优惠券对应推广类型，3：专属 4：招商
        /// </summary>
        [JsonProperty("plan_type")]
        public long? PlanType { get; set; }

        /// <summary>
        /// 搜索id，建议填写，提高收益。来自pdd.ddk.goods.recommend.get、pdd.ddk.goods.search、pdd.ddk.top.goods.list.query等接口
        /// </summary>
        [JsonProperty("search_id")]
        public string SearchId { get; set; }

        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public long? ZsDuoId { get; set; }

        /// <summary>
        /// goods_sign	STRING	非必填	商品goodsSign，支持通过goods_sign查询商品。优先使用此字段进行查询
        /// </summary>
        [JsonProperty("goods_sign")]
        public string GoodsSign { get; set; }
        #endregion
    }
}
