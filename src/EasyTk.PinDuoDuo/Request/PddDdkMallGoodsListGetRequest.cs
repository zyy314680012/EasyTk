using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 查询店铺商品
    /// </summary>
    public class PddDdkMallGoodsListGetRequest : BaseRequest<PddDdkMallGoodsListGetResponse>
    {
        public override string Type => "pdd.ddk.mall.goods.list.get";

        #region 

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("mall_id")]
        public long MallId { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页商品数量
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        #endregion
    }
}
