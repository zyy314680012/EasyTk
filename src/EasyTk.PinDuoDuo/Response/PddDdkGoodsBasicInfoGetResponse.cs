using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkGoodsBasicInfoGetResponse : BaseResponse<PddDdkGoodsBasicInfoGetResponse.PddDdkGoodsBasicInfoGetData>
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_basic_detail_response")]
        public override PddDdkGoodsBasicInfoGetData Data { get; set; }

        public class PddDdkGoodsBasicInfoGetData : BaseResponseData
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("goods_list")]
            public PddDdkGoodsBasicInfoGetDataItem[] GoodsList { get; set; }
        }

        public class PddDdkGoodsBasicInfoGetDataItem
        {
            /// <summary>
            /// 商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品标题
            /// </summary>
            [JsonProperty("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品缩略图
            /// </summary>
            [JsonProperty("goods_pic")]
            public string GoodsPic { get; set; }

            /// <summary>
            /// 最小成团价格，单位分
            /// </summary>
            [JsonProperty("min_group_price")]
            public long? MinGroupPrice { get; set; }

            /// <summary>
            /// 最小单买价格，单位分
            /// </summary>
            [JsonProperty("min_normal_price")]
            public long? MinNormalPrice { get; set; }
        }
    }
}
