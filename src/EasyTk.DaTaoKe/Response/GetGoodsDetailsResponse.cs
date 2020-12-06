using EasyTk.DaTaoKe.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetGoodsDetailsResponse : GoodItemPartial
    {
        /// <summary>
        /// isSubdivision Number 1 该商品是否有细分类目：0不是，1是 （11.3新增字段）
        /// </summary>
        [JsonProperty("isSubdivision")]
        public int? IsSubdivision { get; set; }

        /// <summary>
        /// subdivisionId Number 155 该商品所属细分类目id（11.3新增字段）
        /// </summary>
        [JsonProperty("subdivisionId")]
        public long? SubdivisionId { get; set; }

        /// <summary>
        /// subdivisionName String 洗衣液 该商品所属细分类目名称（11.3新增字段）
        /// </summary>
        [JsonProperty("subdivisionName")]
        public string SubdivisionName { get; set; }

        /// <summary>
        /// subdivisionRank Number 1 该商品所属细分类目排名（11.3新增字段）
        /// </summary>
        [JsonProperty("subdivisionRank")]
        public long? SubdivisionRank { get; set; }
    }
}
