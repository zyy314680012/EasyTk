using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    public class SearchRequest : BaseRequest<WrapperResponseDouYinTotal<SearchResponse>>
    {
        public override string GetApiUrl() => "https://openapiv2.dataoke.com/tiktok/tiktok-materials-products-search";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// searchType Number 是 召回结果排序条件，0默认排序1历史销量排序2价格排序3佣金金额排序4佣金比例排序；
        /// </summary>
        [JsonProperty("searchType")]
        public int SearchType { get; set; }

        /// <summary>
        /// sortType Number 是 排序顺序（0升序1降序）
        /// </summary>
        [JsonProperty("sortType")]
        public int SortType { get; set; }

        /// <summary>
        /// page Number 是 分页（从1开始）
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// pageSize Number 是 每页的数量（小于等于20）
        /// </summary>
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// title String 否 商品标题，返回标题中包含某个关键词的商品，留空则返回所有商品。
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// firstCids String 否 筛选商品一级类目
        /// </summary>
        [JsonProperty("firstCids")]
        public string FirstCids { get; set; }

        /// <summary>
        /// secondCids String 否 筛选商品二级类目
        /// </summary>
        [JsonProperty("secondCids")]
        public string SecondCids { get; set; }

        /// <summary>
        /// thirdCids String 否 筛选商品三级类目
        /// </summary>
        [JsonProperty("thirdCids")]
        public string ThirdCids { get; set; }

        /// <summary>
        /// priceMin Number 否 筛选价格区间-最小值（单位为元）
        /// </summary>
        [JsonProperty("priceMin")]
        public double? PriceMin { get; set; }

        /// <summary>
        /// priceMax Number 否 筛选价格区间-最大值（单位为元）
        /// </summary>
        [JsonProperty("priceMax")]
        public double? PriceMax { get; set; }

        /// <summary>
        /// sellNumMin Number 否 筛选历史销量区间-最小值
        /// </summary>
        [JsonProperty("sellNumMin")]
        public long? SellNumMin { get; set; }

        /// <summary>
        /// sellNumMax Number 否 筛选历史销量区间-最大值
        /// </summary>
        [JsonProperty("sellNumMax")]
        public long? SellNumMax { get; set; }

        /// <summary>
        /// cosFeeMin Number 否 筛选普通佣金区间-最小值（单位为元）
        /// </summary>
        [JsonProperty("cosFeeMin")]
        public double? CosFeeMin { get; set; }

        /// <summary>
        /// cosFeeMax Number 否 筛选普通佣金区间-最大值（单位为元）
        /// </summary>
        [JsonProperty("cosFeeMax")]
        public double? CosFeeMax { get; set; }

        /// <summary>
        /// cosRatioMin Number 否 筛选普通佣金率区间-最小值 （乘100，例如10%为10）
        /// </summary>
        [JsonProperty("cosRatioMin")]
        public int? CosRatioMin { get; set; }

        /// <summary>
        /// cosRatioMax Number 否 筛选普通佣金率区间-最大值（乘100，例如10%为10
        /// </summary>
        [JsonProperty("cosRatioMax")]
        public int? CosRatioMax { get; set; }

        #endregion
    }
}
