using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    /// <summary>
    /// 抖音直播间列表
    /// https://www.dataoke.com/kfpt/api-d.html?id=109
    /// </summary>
    public class LiveShareMaterialRequest : BaseRequest<WrapperResponseDouYinTotal<LiveShareMaterialResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tiktok/tiktok-live-share-material";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// author_info String 否 达人昵称或账号
        /// </summary>
        [JsonProperty("author_info")]
        public string AuthorInfo { get; set; }

        /// <summary>
        /// page Int64 否 分页，1开始
        /// </summary>
        [JsonProperty("page")]
        public long Page { get; set; } = 1L;

        /// <summary>
        /// page_size Int64 否 每页数据条数(请在1,2,5,10,20,50中选择一个数值)
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; } = 20L;

        /// <summary>
        /// sort_by Int32 否 排序字段: 1-综合；2-销量；3-佣金率；4-粉丝数
        /// </summary>
        [JsonProperty("sort_by")]
        public long SortBy { get; set; } = 1L;

        /// <summary>
        /// sort_type Int32 否 排序顺序（0升序1降序）
        /// </summary>
        [JsonProperty("sort_type")]
        public long SortType { get; set; } = 0L;

        #endregion
    }
}
