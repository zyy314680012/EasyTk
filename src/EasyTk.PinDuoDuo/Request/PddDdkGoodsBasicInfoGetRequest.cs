using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 获取商品基本信息接口
    /// </summary>
    public class PddDdkGoodsBasicInfoGetRequest : BaseRequest<PddDdkGoodsBasicInfoGetResponse>
    {
        public override string Type => "pdd.ddk.goods.basic.info.get";

        #region 

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id_list")]
        public long[] GoodsIdList { get; set; }

        #endregion
    }
}
