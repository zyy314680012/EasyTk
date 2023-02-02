using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    /// <summary>
    /// 抖音一元购商品
    /// https://www.dataoke.com/kfpt/api-d.html?id=112
    /// </summary>
    public class OneYuanGoodsListRequest : BaseRequest<WrapperResponseDouYinTotal<OneYuanGoodsListResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tiktok/tiktok-one-yuan-goods-list";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// page Int64 是 分页（从1开始）
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// page_size Int64 是 每页的数量
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; } = 20;

        /// <summary>
        /// title string 否 商品标题，从一元购商品中返回标题中包含某个关键词的商品
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// first_cids string 否 筛选商品一级类目(多个用英文逗号隔开)
        /// </summary>
        [JsonProperty("first_cids")]
        public string FirstCids { get; set; }

        /// <summary>
        /// second_cids string 否 筛选商品二级类目(多个用英文逗号隔开)
        /// </summary>
        [JsonProperty("second_cids")]
        public string SecondCids { get; set; }

        /// <summary>
        /// third_cids string 否 筛选商品三级类目(多个用英文逗号隔开)
        /// </summary>
        [JsonProperty("third_cids")]
        public string ThirdCids { get; set; }

        /// <summary>
        /// search_type string 是 结果排序条件，0默认排序1历史销量排序2价格排序3佣金金额排序4佣金比例排序；
        /// </summary>
        [JsonProperty("search_type")]
        public int SearchType { get; set; }

        /// <summary>
        /// sort_type string 是 排序顺序（0升序1降序）
        /// </summary>
        [JsonProperty("sort_type")]
        public int SortType { get; set; }

        #endregion
    }
}
