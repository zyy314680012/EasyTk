using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    /// <summary>
    /// 单品详情
    /// 通过商品id或淘宝id查询单个商品的详细信息，可使用返回的数据构建单品详情页，向用户提供详情的商品信息
    /// </summary>
    public class GetGoodsDetailsRequest : BaseRequest<WrapperResponse<GetGoodsDetailsResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-goods-details";

        public override string Version => "v1.2.3";

        #region 

        ///<summary> 
        ///id 商品id	是	Number	大淘客商品id，请求时id或goodsId必填其中一个，若均填写，将优先查找当前单品id
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        ///<summary> 
        ///goodsId 淘宝商品id	否	String	id或goodsId必填其中一个，若均填写，将优先查找当前单品id
        ///</summary>
        [JsonProperty("goodsId")]
        public string GoodsId { get; set; }

        #endregion
    }
}
