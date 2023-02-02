using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class RankResponse
    {
        #region

        /// <summary>
        /// id number 1 主键id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// productId string 3455938529937469044 抖音商品id
        /// </summary>
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// num number 15018672 对应榜单销量
        /// </summary>
        [JsonProperty("num")]
        public long? Num { get; set; }

        /// <summary>
        /// title string 10袋起拍-重庆特色佳仙老火锅底料50g手工全型麻辣烫底料懒人小袋 商品标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// price number 1.5 商品售价
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// cosRatio number 16 普通佣金比例
        /// </summary>
        [JsonProperty("cosRatio")]
        public double? CosRatio { get; set; }

        /// <summary>
        /// cosFee number 0.24 普通佣金金额
        /// </summary>
        [JsonProperty("cosFee")]
        public double? CosFee { get; set; }

        /// <summary>
        /// firstCid number 20104 商品一级类目
        /// </summary>
        [JsonProperty("firstCid")]
        public long? FirstCid { get; set; }

        /// <summary>
        /// secondCid number 21665 商品二级类目
        /// </summary>
        [JsonProperty("secondCid")]
        public long? SecondCid { get; set; }

        /// <summary>
        /// thirdCid number 28215 商品三级类目
        /// </summary>
        [JsonProperty("thirdCid")]
        public long? ThirdCid { get; set; }

        /// <summary>
        /// inStock number 1 是否有库存 0=没有 1=有
        /// </summary>
        [JsonProperty("inStock")]
        public int? InStock { get; set; }

        /// <summary>
        /// sales number 15018672 销量
        /// </summary>
        [JsonProperty("sales")]
        public long? Sales { get; set; }

        /// <summary>
        /// cover string https://p3-aio.ecombdimg.com/obj/temai/88ea815589ebb6ee0a137a0cad3fc686www800-800 商品主图
        /// </summary>
        [JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// imgs array,null https://p9-aio.ecombdimg.com/obj/temai/88ea815589ebb6ee0a137a0cad3fc686www800-800 轮播图
        /// </summary>
        [JsonProperty("imgs")]
        public string[] Imgs { get; set; }

        /// <summary>
        /// detailUrl string https://haohuo.jinritemai.com/views/product/item2?id=3455938529937469044\u0026pick_source=NAM76nc 商品链接
        /// </summary>
        [JsonProperty("detailUrl")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// shopId number 2283165 店铺ID
        /// </summary>
        [JsonProperty("shopId")]
        public long? ShopId { get; set; }

        /// <summary>
        /// shopName string 佳仙食品 店铺名称
        /// </summary>
        [JsonProperty("shopName")]
        public string ShopName { get; set; }

        /// <summary>
        /// kolCosRatio number 0 达人佣金比例
        /// </summary>
        [JsonProperty("kolCosRatio")]
        public double? KolCosRatio { get; set; }

        /// <summary>
        /// kolCosFee number 0 达人佣金金额
        /// </summary>
        [JsonProperty("kolCosFee")]
        public double? KolCosFee { get; set; }

        /// <summary>
        /// commentScore number 4.5 商品评分
        /// </summary>
        [JsonProperty("commentScore")]
        public double? CommentScore { get; set; }

        /// <summary>
        /// commentNum number 182004 商品评价数目
        /// </summary>
        [JsonProperty("commentNum")]
        public long? CommentNum { get; set; }

        /// <summary>
        /// orderNum number 114265 近30天商品总订单量
        /// </summary>
        [JsonProperty("orderNum")]
        public long? OrderNum { get; set; }

        /// <summary>
        /// viewNum number 522554 近30天商品总浏览量
        /// </summary>
        [JsonProperty("viewNum")]
        public long? ViewNum { get; set; }

        /// <summary>
        /// kolNum number 17793 近30天推广总达人数
        /// </summary>
        [JsonProperty("kolNum")]
        public long? KolNum { get; set; }

        /// <summary>
        /// categoryName string 食品饮料 专属团长功能活动对应的限制类目名称
        /// </summary>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// categoryId number 13 专属团长功能活动对应的限制类目名称id
        /// </summary>
        [JsonProperty("categoryId")]
        public long? CategoryId { get; set; }

        /// <summary>
        /// cid number 6 大淘客分类id
        /// </summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }

        /// <summary>
        /// logisticsInfo string 48小时内从重庆市发货，运费0元起 商品物流说明
        /// </summary>
        [JsonProperty("logisticsInfo")]
        public string LogisticsInfo { get; set; }

        /// <summary>
        /// shopScore number 4.84 商家体验分
        /// </summary>
        [JsonProperty("shopScore")]
        public double? ShopScore { get; set; }

        /// <summary>
        /// shopLevel number 1 商家等级
        /// </summary>
        [JsonProperty("shopLevel")]
        public long? ShopLevel { get; set; }

        /// <summary>
        /// productScore number 4.75 商品体验分
        /// </summary>
        [JsonProperty("productScore")]
        public double? ProductScore { get; set; }

        /// <summary>
        /// productLevel number 1 商品等级
        /// </summary>
        [JsonProperty("productLevel")]
        public long? ProductLevel { get; set; }

        /// <summary>
        /// logisticsScore number 4.99 物流体验分
        /// </summary>
        [JsonProperty("logisticsScore")]
        public double? LogisticsScore { get; set; }

        /// <summary>
        /// logisticsLevel number 1 物流等级
        /// </summary>
        [JsonProperty("logisticsLevel")]
        public long? LogisticsLevel { get; set; }

        /// <summary>
        /// serviceScore number 4.83 商家服务分
        /// </summary>
        [JsonProperty("serviceScore")]
        public double? ServiceScore { get; set; }

        /// <summary>
        /// serviceLevel number 1 商家服务等级
        /// </summary>
        [JsonProperty("serviceLevel")]
        public long? ServiceLevel { get; set; }

        /// <summary>
        /// couponPrice number 0 券后价
        /// </summary>
        [JsonProperty("couponPrice")]
        public double? CouponPrice { get; set; }

        /// <summary>
        /// coupon number 0 券金额
        /// </summary>
        [JsonProperty("coupon")]
        public double? Coupon { get; set; }

        /// <summary>
        /// sharable number 1 是否可分销 0=否 1=是
        /// </summary>
        [JsonProperty("sharable")]
        public int? Sharable { get; set; }

        /// <summary>
        /// isShow number 1 是否显示 0=否 1=是
        /// </summary>
        [JsonProperty("isShow")]
        public int? IsShow { get; set; }

        /// <summary>
        /// isTurn number 1 是否支持转链 0=否 1=是
        /// </summary>
        [JsonProperty("isTurn")]
        public int? IsTurn { get; set; }

        #endregion
    }
}
