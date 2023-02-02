using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class DistributionLiveProductListResponse
    {
        #region

        /// <summary>
        /// createTime integer 1649841070 直播间创建时间
        /// </summary>
        [JsonProperty("createTime")]
        public long? CreateTime { get; set; }

        /// <summary>
        /// roomId number 1292893292189385392859439 直播间ID
        /// </summary>
        [JsonProperty("roomId")]
        public long? RoomId { get; set; }

        /// <summary>
        /// onlineNum number 21231 在线人数
        /// </summary>
        [JsonProperty("onlineNum")]
        public long? OnlineNum { get; set; }

        /// <summary>
        /// isRestAssured boolean false 是否支持安心购
        /// </summary>
        [JsonProperty("isRestAssured")]
        public bool? IsRestAssured { get; set; }

        /// <summary>
        /// isFlashLiveRoom boolean false 是否闪购直播间
        /// </summary>
        [JsonProperty("isFlashLiveRoom")]
        public bool? IsFlashLiveRoom { get; set; }

        /// <summary>
        /// productCount number 100 商品总数（不含闪购），最多100
        /// </summary>
        [JsonProperty("productCount")]
        public long? ProductCount { get; set; }

        /// <summary>
        /// products object / 商品列表（不含闪购）
        /// </summary>
        [JsonProperty("products")]
        public ProductInfo[] Products { get; set; }

        /// <summary>
        /// flashProductsCount number 1 闪购商品总数
        /// </summary>
        [JsonProperty("flashProductsCount")]
        public long? FlashProductsCount { get; set; }

        /// <summary>
        /// flashProducts null / 闪购商品列表
        /// </summary>
        [JsonProperty("flashProducts")]
        public ProductInfo[] FlashProducts { get; set; }

        public class ProductInfo
        {
            /// <summary>
            /// listNum number 1 商品在列表序号
            /// </summary>
            [JsonProperty("listNum")]
            public long? ListNum { get; set; }

            /// <summary>
            /// productId number 3094093204930502 商品ID
            /// </summary>
            [JsonProperty("productId")]
            public long? ProductId { get; set; }

            /// <summary>
            /// title string 测试商品岩烧芝士脆饼干 商品名称
            /// </summary>
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// price number 1000 商品原价
            /// </summary>
            [JsonProperty("price")]
            public double? Price { get; set; }

            /// <summary>
            /// liveRoomPrice number 900 直播间价格
            /// </summary>
            [JsonProperty("liveRoomPrice")]
            public double? LiveRoomPrice { get; set; }

            /// <summary>
            /// cover string https://p6-aio.ecombdimg.com/obj/temai/6ef6ccb6699c9865be7e68c325bf22e7w 商品主图
            /// </summary>
            [JsonProperty("cover")]
            public string Cover { get; set; }

            /// <summary>
            /// firstCid number 20018 一级类目ID
            /// </summary>
            [JsonProperty("firstCid")]
            public long? FirstCid { get; set; }

            /// <summary>
            /// firstCname string 零食/坚果/特产 一级类目名称
            /// </summary>
            [JsonProperty("firstCname")]
            public string FirstCname { get; set; }

            /// <summary>
            /// secondCid number 20313 二级类目ID
            /// </summary>
            [JsonProperty("secondCid")]
            public long? SecondCid { get; set; }

            /// <summary>
            /// secondCname string 饼干/膨化 二级类目名称
            /// </summary>
            [JsonProperty("secondCname")]
            public string SecondCname { get; set; }

            /// <summary>
            /// thirdCid number 22977 三级类目ID
            /// </summary>
            [JsonProperty("thirdCid")]
            public long? ThirdCid { get; set; }

            /// <summary>
            /// thirdCname string 饼干 三级类目名称
            /// </summary>
            [JsonProperty("thirdCname")]
            public string ThirdCname { get; set; }

            /// <summary>
            /// categoryId number 29187 行业类目ID
            /// </summary>
            [JsonProperty("categoryId")]
            public long? CategoryId { get; set; }

            /// <summary>
            /// isExplaining boolean true 是否在讲解中
            /// </summary>
            [JsonProperty("isExplaining")]
            public bool? IsExplaining { get; set; }

            /// <summary>
            /// adsPromotionRatio object / 渠道推广费率（X10000）
            /// </summary>
            [JsonProperty("adsPromotionRatio")]
            public AdsPromotionRatioInfo AdsPromotionRatio { get; set; }
        }

        public class AdsPromotionRatioInfo
        {
            /// <summary>
            /// shareRatio number 1000 新客推广费率
            /// </summary>
            [JsonProperty("shareRatio")]
            public double? ShareRatio { get; set; }

            /// <summary>
            /// oldFansRatio number 500 老客推广费率
            /// </summary>
            [JsonProperty("oldFansRatio")]
            public double? OldFansRatio { get; set; }
        }

        #endregion
    }
}
