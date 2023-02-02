using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    /// <summary>
    /// 抖音销量榜单
    /// https://www.dataoke.com/kfpt/api-d.html?id=90
    /// </summary>
    public class RankRequest : BaseRequest<WrapperResponse<RankResponse[]>>
    {
        public override string GetApiUrl() => "https://openapiv2.dataoke.com/rank/tiktok-rank";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// cid Number 是 大淘客分类id 100综合 1女装 2母婴 3美妆 4居家日用 5鞋品 6美食 7文娱车品 8数码家电 9男装 10内衣 11箱包 12配饰 13户外运动 14家装家纺
        /// </summary>
        [JsonProperty("cid")]
        public int Cid { get; set; }

        /// <summary>
        /// listType String 是 榜单类型 实时:2h 全天:24h 不传为必购榜
        /// </summary>
        [JsonProperty("listType")]
        public string ListType { get; set; }

        #endregion
    }
}
