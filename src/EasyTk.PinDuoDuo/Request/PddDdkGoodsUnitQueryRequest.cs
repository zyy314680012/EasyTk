using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 查询商品的推广计划
    /// </summary>
    public class PddDdkGoodsUnitQueryRequest : BaseRequest<PddDdkGoodsUnitQueryResponse>
    {
        public override string Type => "pdd.ddk.goods.unit.query";

        #region 

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// 招商duoId
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public long? ZsDuoId { get; set; }

        #endregion
    }
}
