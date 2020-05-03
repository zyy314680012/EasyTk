using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public class PddDdkThemeListGetResponse : BaseResponse<PddDdkThemeListGetResponse.PddDdkThemeListGetData>
    {
        /// <summary>
        /// 主题列表返回对象
        /// </summary>
        [JsonProperty("theme_list_get_response")]
        public override PddDdkThemeListGetData Data { get; set; }

        public class PddDdkThemeListGetData : BaseResponseData
        {
            /// <summary>
            /// 返回的主题列表
            /// </summary>
            [JsonProperty("theme_list")]
            public ThemeItem[] ThemeList { get; set; }

            /// <summary>
            /// 返回的元素数量
            /// </summary>
            [JsonProperty("total")]
            public long? Total { get; set; }
        }

        public class ThemeItem
        {
            /// <summary>
            /// 主题包含的商品数量
            /// </summary>
            [JsonProperty("goods_num")]
            public long? GoodsNum { get; set; }

            /// <summary>
            /// 主题ID
            /// </summary>
            [JsonProperty("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 主题图片
            /// </summary>
            [JsonProperty("image_url")]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 主题名称
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
