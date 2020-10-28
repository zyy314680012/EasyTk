using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 获得拼多多商品标签列表（非商品类目cat，当前仅开放给多多客使用）
    /// </summary>
    public class PddGoodsOptGetRequest : BaseRequest<PddGoodsOptGetResponse>
    {
        public override string Type => "pdd.goods.opt.get";

        /// <summary>
        /// parent_opt_id	INTEGER	必填	值=0时为顶点opt_id,通过树顶级节点获取opt树
        /// </summary>
        [JsonProperty("parent_opt_id")]
        public long ParentOptId { get; set; }
    }
}
