using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class PddGoodsCatsGetResponse : BaseResponse<PddGoodsCatsGetResponse.PddGoodsCatsGetResponseData>
    {
        [JsonProperty("goods_cats_get_response")]
        public override PddGoodsCatsGetResponseData Data { get; set; }

        public class PddGoodsCatsGetResponseData : BaseResponseData
        {
            [JsonProperty("goods_cats_list")]
            public PddGoodsCatsGetResponseItem[] List { get; set; }
        }

        public class PddGoodsCatsGetResponseItem
        {
            /// <summary>
            /// cat_id	LONG		商品类目ID
            /// </summary>
            [JsonProperty("cat_id")]
            public long CateId { get; set; }

            /// <summary>
            /// parent_cat_id	LONG		id所属父类目ID，其中，parent_id=0时为顶级节点
            /// </summary>
            [JsonProperty("parent_cat_id")]
            public long ParentCatId { get; set; }

            /// <summary>
            /// level	INTEGER		类目层级，1-一级类目，2-二级类目，3-三级类目，4-四级类目
            /// </summary>
            [JsonProperty("level")]
            public int Level { get; set; }

            /// <summary>
            /// cat_name	STRING		商品类目名称
            /// </summary>
            [JsonProperty("cat_name")]
            public string CatName { get; set; }
        }
    }
}
