using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class OneYuanGoodsListResponse
    {
        #region

        /// <summary>
        /// cosFee number 19 普通佣金金额（单位为分）
        /// </summary>
        [JsonProperty("cosFee")]
        public double? CosFee { get; set; }

        /// <summary>
        /// cosRatio number 50 普通佣金比例（乘100，例如10%为10）
        /// </summary>
        [JsonProperty("cosRatio")]
        public double? CosRatio { get; set; }

        /// <summary>
        /// discountDesc string 券金额 满20减1
        /// </summary>
        [JsonProperty("discountDesc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// couponPrice number 1 券后价（单位：元）
        /// </summary>
        [JsonProperty("couponPrice")]
        public double? CouponPrice { get; set; }

        /// <summary>
        /// cover string https://p9-aio.ecombdimg.com/obj/temai/08d583018ed3e9e6fbac13b937cd9ab66de024f8www800-800 商品主图
        /// </summary>
        [JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// detailUrl string https://haohuo.jinritemai.com/views/product/item2?id=3531455712288976723\u0026pick_source=NAr9W5y 商品链接（普通计划链接）
        /// </summary>
        [JsonProperty("detailUrl")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// firstCid number 20073 商品一级类目
        /// </summary>
        [JsonProperty("firstCid")]
        public long? FirstCid { get; set; }

        /// <summary>
        /// inStock boolean true 是否有库存
        /// </summary>
        [JsonProperty("inStock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// price number 39.9 商品售价（单位为元）
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// productId number 3531455712288976723 商品id
        /// </summary>
        [JsonProperty("productId")]
        public long? ProductId { get; set; }

        /// <summary>
        /// sales number 0 历史总销量
        /// </summary>
        [JsonProperty("sales")]
        public long? Sales { get; set; }

        /// <summary>
        /// secondCid number 20972 商品二级类目
        /// </summary>
        [JsonProperty("secondCid")]
        public long? SecondCid { get; set; }

        /// <summary>
        /// shopId number 37550815 店铺ID
        /// </summary>
        [JsonProperty("shopId")]
        public long? ShopId { get; set; }

        /// <summary>
        /// shopName string 华慧百货个体店 店铺名称
        /// </summary>
        [JsonProperty("shopName")]
        public string ShopName { get; set; }

        /// <summary>
        /// thirdCid number 0 商品三级类目
        /// </summary>
        [JsonProperty("thirdCid")]
        public long? ThirdCid { get; set; }

        /// <summary>
        /// title string 防风防寒呼吸阀口罩针织帽 加厚护耳毛线帽 商品标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        #endregion
    }
}
