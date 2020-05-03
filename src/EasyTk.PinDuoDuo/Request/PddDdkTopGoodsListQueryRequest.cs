using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 多多客获取爆款排行商品接口
    /// </summary>
    public class PddDdkTopGoodsListQueryRequest : BaseRequest<PddDdkTopGoodsListQueryResponse>
    {
        public override string Type => "pdd.ddk.top.goods.list.query";

        #region 

        /// <summary>
        /// 请求数量；默认值 ： 400
        /// </summary>
        [JsonProperty("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// 翻页时建议填写前页返回的list_id值
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// 从多少位置开始请求；默认值 ： 0
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }

        /// <summary>
        /// 1-实时热销榜；2-实时收益榜
        /// </summary>
        [JsonProperty("sort_type")]
        public long? SortType { get; set; }



        #endregion
    }
}
