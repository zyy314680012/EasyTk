using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetCollectionListResponse
    {
        /// <summary>
        /// id	商品id	Number	18926311
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// goodsId	淘宝商品id	String	“589284195570”
        /// </summary>
        [JsonProperty("goodsId")]
        public string GoodsId { get; set; }

        /// <summary>
        /// trailerGoods	是否预告商品，0- 一般商品，1- 预告商品	Number	0
        /// </summary>
        [JsonProperty("trailerGoods")]
        public long? TrailerGoods { get; set; }

    }
}
