using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class MaterialsProductsDetailResponse
    {
        #region

        /// <summary>
        /// categoryId number 13 专属团长功能活动对应的限制类目名称id
        /// </summary>
        [JsonProperty("categoryId")]
        public long? CategoryId { get; set; }

        /// <summary>
        /// categoryName string 食品饮料 专属团长功能活动对应的限制类目名称
        /// </summary>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// commentNum number 120863 商品评价数目
        /// </summary>
        [JsonProperty("commentNum")]
        public long? CommentNum { get; set; }

        /// <summary>
        /// commentScore number 4.6 商品评分（5分制，保留一位）
        /// </summary>
        [JsonProperty("commentScore")]
        public double? CommentScore { get; set; }

        /// <summary>
        /// cosFee number 2.12 普通佣金金额（单位为元）
        /// </summary>
        [JsonProperty("cosFee")]
        public double? CosFee { get; set; }

        /// <summary>
        /// cosRatio number 20 普通佣金比例（乘100，例如10%为10）
        /// </summary>
        [JsonProperty("cosRatio")]
        public int? CosRatio { get; set; }

        /// <summary>
        /// couponPrice number 0 券后价
        /// </summary>
        [JsonProperty("couponPrice")]
        public double? CouponPrice { get; set; }

        /// <summary>
        /// cover string https://p9-aio.ecombdimg.com/obj/temai/b9c3feca0c3fb5fdee5c6b9c8a0ceb1dwww800-800 商品主图
        /// </summary>
        [JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// detailUrl string https://haohuo.jinritemai.com/views/product/item2?id=3455060999458154669\u0026pick_source=NArJnBf 商品链接（普通计划链接）
        /// </summary>
        [JsonProperty("detailUrl")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// firstCid number 20018 商品一级类目
        /// </summary>
        [JsonProperty("firstCid")]
        public long? FirstCid { get; set; }

        /// <summary>
        /// hasSxt boolean true 是否具有短视频随心推资质
        /// </summary>
        [JsonProperty("hasSxt")]
        public bool? HasSxt { get; set; }

        /// <summary>
        /// imgs string [] https://p6-aio.ecombdimg.com/obj/temai/b9c3feca0c3fb5fdee5c6b9c8a0ceb1dwww800-800 商品轮播图
        /// </summary>
        [JsonProperty("imgs")]
        public string[] Imgs { get; set; }

        /// <summary>
        /// inStock boolean true 是否有库存
        /// </summary>
        [JsonProperty("inStock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// kolCosFee number 0 达人佣金金额（单位为元）
        /// </summary>
        [JsonProperty("kolCosFee")]
        public double? KolCosFee { get; set; }

        /// <summary>
        /// kolCosRatio number 0 达人佣金比例
        /// </summary>
        [JsonProperty("kolCosRatio")]
        public int? KolCosRatio { get; set; }

        /// <summary>
        /// kolNum number 2625 近30天推广总达人数
        /// </summary>
        [JsonProperty("kolNum")]
        public long? KolNum { get; set; }

        /// <summary>
        /// logisticsInfo string 最晚48小时内从河北省发货，包邮 商品物流说明
        /// </summary>
        [JsonProperty("logisticsInfo")]
        public string LogisticsInfo { get; set; }

        /// <summary>
        /// orderNum number 34077 近30天商品总订单量
        /// </summary>
        [JsonProperty("orderNum")]
        public long? OrderNum { get; set; }

        /// <summary>
        /// price number 10.6 商品售价（单位为元）
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// productId string 3455060999458154669 商品id
        /// </summary>
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// reason string / 活动审核原因
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// sales number 871946 销量
        /// </summary>
        [JsonProperty("sales")]
        public long? Sales { get; set; }

        /// <summary>
        /// secondCid number 20332 商品二级类目
        /// </summary>
        [JsonProperty("secondCid")]
        public long? SecondCid { get; set; }

        /// <summary>
        /// sharable boolean true 是否可分销
        /// </summary>
        [JsonProperty("sharable")]
        public bool? Sharable { get; set; }

        /// <summary>
        /// shopId number 4929605 店铺ID
        /// </summary>
        [JsonProperty("shopId")]
        public long? ShopId { get; set; }

        /// <summary>
        /// shopName string 淘味熊零食 店铺名称
        /// </summary>
        [JsonProperty("shopName")]
        public string ShopName { get; set; }

        /// <summary>
        /// shopTotalScore object / 商家得分
        /// </summary>
        [JsonProperty("shopTotalScore")]
        public ShopScoreInfo ShopTotalScore { get; set; }

        /// <summary>
        /// status number 0 商品活动审核状态
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// thirdCid number 23201 商品三级类目
        /// </summary>
        [JsonProperty("thirdCid")]
        public long? ThirdCid { get; set; }

        /// <summary>
        /// title string {主播推荐} 淘味熊 拌饭海苔 海苔碎 （原味）70g/箱 商品标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// viewNum number 106556 近30天商品总浏览量
        /// </summary>
        [JsonProperty("viewNum")]
        public long? ViewNum { get; set; }

        /// <summary>
        /// brand object - 品牌信息 2023.1.31新增字段
        /// </summary>
        [JsonProperty("brand")]
        public BrandInfo Brand { get; set; }

        /// <summary>
        /// tags object - 标签 2023.1.31新增字段
        /// </summary>
        [JsonProperty("tags")]
        public TagsInfo Tags { get; set; }

        /// <summary>
        /// </summary>
        public class ShopScoreInfo
        {
            /// <summary>
            /// logisticsScore object / 物流体验分
            /// </summary>
            [JsonProperty("logisticsScore")]
            public ScoreInfo LogisticsScore { get; set; }

            /// <summary>
            /// productScore object / 商品体验分
            /// </summary>
            [JsonProperty("productScore")]
            public ScoreInfo ProductScore { get; set; }

            /// <summary>
            /// serviceScore object / 商家服务分
            /// </summary>
            [JsonProperty("serviceScore")]
            public ScoreInfo ServiceScore { get; set; }

            /// <summary>
            /// shopScore object / 商家体验分
            /// </summary>
            [JsonProperty("shopScore")]
            public ScoreInfo ShopScore { get; set; }
        }

        public class ScoreInfo
        {
            /// <summary>
            /// level number 1 等级
            /// </summary>
            [JsonProperty("level")]
            public int? Level { get; set; }

            /// <summary>
            /// score string 4.93 得分
            /// </summary>
            [JsonProperty("score")]
            public double? Score { get; set; }

            /// <summary>
            /// text string 物流体验分 文本
            /// </summary>
            [JsonProperty("text")]
            public string Text { get; set; }
        }

        public class BrandInfo
        {
            /// <summary>
            /// brand_id string 333 品牌ID
            /// </summary>
            [JsonProperty("brand_id")]
            public long? BrandId { get; set; }

            /// <summary>
            /// brand_name_cn string 三只松鼠 品牌名称
            /// </summary>
            [JsonProperty("brand_name_cn")]
            public string BrandNameCn { get; set; }

            /// <summary>
            /// brand_name_en string - 品牌英文名称
            /// </summary>
            [JsonProperty("brand_name_en")]
            public string BrandNameEn { get; set; }
        }

        public class TagsInfo
        {
            /// <summary>
            /// has_shop_brand_tag string flase 是否有品牌旗舰店标签（[品牌]黑标）
            /// </summary>
            [JsonProperty("has_shop_brand_tag")]
            public string HasShopBrandTag { get; set; }
        }

        #endregion
    }
}
