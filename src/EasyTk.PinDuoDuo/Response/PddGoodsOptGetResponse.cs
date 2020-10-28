using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddGoodsOptGetResponse : BaseResponse<PddGoodsOptGetResponse.PddGoodsOptGetResponseData>
    {
        [JsonProperty("goods_opt_get_response")]
        public override PddGoodsOptGetResponseData Data { get; set; }

        public class PddGoodsOptGetResponseData : BaseResponseData
        {
            [JsonProperty("goods_opt_list")]
            public PddGoodsOptGetResponseItem[] List { get; set; }
        }

        public class PddGoodsOptGetResponseItem
        {
            /// <summary>
            /// level	INTEGER		层级，1-一级，2-二级，3-三级，4-四级
            /// </summary>
            [JsonProperty("level")]
            public int Level { get; set; }

            /// <summary>
            /// opt_id	LONG		商品标签ID
            /// </summary>
            [JsonProperty("opt_id")]
            public long OptId { get; set; }

            /// <summary>
            /// opt_name	STRING		商品标签名
            /// </summary>
            [JsonProperty("opt_name")]
            public string OptName { get; set; }

            /// <summary>
            /// parent_opt_id	LONG		id所属父ID，其中，parent_id=0时为顶级节点
            /// </summary>
            [JsonProperty("parent_opt_id")]
            public long ParentOptId { get; set; }
        }
    }
}
