using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 获取拼多多标准商品类目信息（请使用pdd.goods.authorization.cats接口获取商家可发布类目）
    /// </summary>
    public class PddGoodsCatsGetRequest : BaseRequest<PddGoodsCatsGetResponse>
    {
        public override string Type => "pdd.goods.cats.get";

        /// <summary>
        /// parent_cat_id	LONG	必填	值=0时为顶点cat_id,通过树顶级节点获取cat树
        /// </summary>
        [JsonProperty("parent_cat_id")]
        public long ParentCatId { get; set; }
    }
}
