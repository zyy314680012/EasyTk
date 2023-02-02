using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class GetGaoYongJingXuanRankResponse
    {
        #region

        /// <summary>
        /// id string 3531455712288976723 商品抖音ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// title string 防风防寒呼吸阀口罩针织帽 加厚护耳毛线帽 商品标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// rankNo string 1 商品在榜排名
        /// </summary>
        [JsonProperty("rankNo")]
        public int? RankNo { get; set; }

        /// <summary>
        /// cover string https://p9-aio.ecombdimg.com/obj/temai/08d583018ed3e9e6fbac13b937cd9ab66de024f8www800-800 商品主图地址
        /// </summary>
        [JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// price number 19.9 商品原价（元）
        /// </summary>
        [JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// sxPrice number 15.5 到手价（元）
        /// </summary>
        [JsonProperty("sxPrice")]
        public double? SxPrice { get; set; }

        /// <summary>
        /// kolCosFee number 3.50 达人佣金金额（元）
        /// </summary>
        [JsonProperty("kolCosFee")]
        public double? KolCosFee { get; set; }

        /// <summary>
        /// kolCosRatio number 20 达人佣金比例（x100%，如10即100%）
        /// </summary>
        [JsonProperty("kolCosRatio")]
        public int? KolCosRatio { get; set; }

        /// <summary>
        /// firstCid number 23112 一级类目ID
        /// </summary>
        [JsonProperty("firstCid")]
        public long? FirstCid { get; set; }

        /// <summary>
        /// firstCname string 食品饮料 一级类目名称
        /// </summary>
        [JsonProperty("firstCname")]
        public string FirstCname { get; set; }

        /// <summary>
        /// sales30day number 213131 月销量
        /// </summary>
        [JsonProperty("sales30day")]
        public long? Sales30day { get; set; }

        /// <summary>
        /// sales2h number - 2小时销量
        /// </summary>
        [JsonProperty("sales2h")]
        public long? Sales2h { get; set; }

        /// <summary>
        /// sales24h number - 24销量
        /// </summary>
        [JsonProperty("sales24h")]
        public long? Sales24h { get; set; }

        /// <summary>
        /// sales7day number - 7日销量
        /// </summary>
        [JsonProperty("sales7day")]
        public long? Sales7day { get; set; }

        /// <summary>
        /// sales number - 总销量
        /// </summary>
        [JsonProperty("sales")]
        public long? Sales { get; set; }

        /// <summary>
        /// scoreRatio string 5421 所筛选的对应榜单指数，引流指数、利润指数、品质指数
        /// </summary>
        [JsonProperty("scoreRatio")]
        public long? ScoreRatio { get; set; }

        /// <summary>
        /// detailUrl string https://haohuo.jinritemai.com/views/product/item2?id=3531455712288976723\u0026pick_source=NAr9W5y 商品链接地址
        /// </summary>
        [JsonProperty("detailUrl")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// shopId number - 店铺ID
        /// </summary>
        [JsonProperty("shopId")]
        public long? ShopId { get; set; }

        /// <summary>
        /// shopName string - 店铺名称
        /// </summary>
        [JsonProperty("shopName")]
        public string ShopName { get; set; }

        /// <summary>
        /// hasShopBrandTag number - 是否黑标旗舰店，1是
        /// </summary>
        [JsonProperty("hasShopBrandTag")]
        public int? HasShopBrandTag { get; set; }

        /// <summary>
        /// flagshipStore number - 是否旗舰店，1是
        /// </summary>
        [JsonProperty("flagshipStore")]
        public int? FlagshipStore { get; set; }

        /// <summary>
        /// shopScore number - 商家体验分
        /// </summary>
        [JsonProperty("shopScore")]
        public double? ShopScore { get; set; }

        /// <summary>
        /// productScore number - 商品体验分
        /// </summary>
        [JsonProperty("productScore")]
        public double? ProductScore { get; set; }

        /// <summary>
        /// serviceScore number - 服务体验分
        /// </summary>
        [JsonProperty("serviceScore")]
        public double? ServiceScore { get; set; }

        /// <summary>
        /// logisticsScore number - 物流体验分
        /// </summary>
        [JsonProperty("logisticsScore")]
        public double? LogisticsScore { get; set; }

        /// <summary>
        /// shopLevel number - 商家分高于同行（1高 2中 3低）
        /// </summary>
        [JsonProperty("shopLevel")]
        public int? ShopLevel { get; set; }

        /// <summary>
        /// productLevel number - 商品分高于同行（1高 2中 3低）
        /// </summary>
        [JsonProperty("productLevel")]
        public int? ProductLevel { get; set; }

        /// <summary>
        /// serviceLevel number - 服务分高于同行（1高 2中 3低）
        /// </summary>
        [JsonProperty("serviceLevel")]
        public int? ServiceLevel { get; set; }

        /// <summary>
        /// logisticsLevel number - 物流分高于同行（1高 2中 3低）
        /// </summary>
        [JsonProperty("logisticsLevel")]
        public int? LogisticsLevel { get; set; }

        /// <summary>
        /// sharable string - 商品是否可分销。true-是 flase-否
        /// </summary>
        [JsonProperty("sharable")]
        public bool? Sharable { get; set; }

        #endregion
    }
}
