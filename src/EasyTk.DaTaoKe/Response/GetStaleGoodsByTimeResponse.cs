using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetStaleGoodsByTimeResponse
    {
        ///<summary> 
        ///id 商品id	Number	18926311
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        ///<summary> 
        ///goodsId 淘宝商品id	String	“589284195570”
        ///</summary>
        [JsonProperty("goodsId")]
        public string GoodsId { get; set; }
    }
}
