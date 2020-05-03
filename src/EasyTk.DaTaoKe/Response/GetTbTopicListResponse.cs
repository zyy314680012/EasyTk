using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetTbTopicListResponse
    {
        /// <summary>
        /// id	活动id	Number	1
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// activityName	活动名称	String	“聚划算-日常-品牌清仓”
        /// </summary>
        [JsonProperty("activityName")]
        public string ActivityName { get; set; }

        /// <summary>
        /// activityStartTime	活动开始时间	String	“2020-03-02 00:00:00”
        /// </summary>
        [JsonProperty("activityStartTime")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// activityEndTime	活动结束时间	String	“2020-03-31 23:59:59”
        /// </summary>
        [JsonProperty("activityEndTime")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// activityInfo	活动信息	String	清仓info
        /// </summary>
        [JsonProperty("activityInfo")]
        public string ActivityInfo { get; set; }

        /// <summary>
        /// type	端口类型	Number	1
        /// </summary>
        [JsonProperty("type")]
        public long? Type { get; set; }

        /// <summary>
        /// activityLink	活动链接	String	https://pages.tmall.com/wow/a/act/ju/dailygroup/1241/wupr?spm=a219t.7664554.1998457203.137.1d2f35d9ylRex1&wh_pid=daily-183363&v=a223fb01fdc37f1dbced73f647eae5fd&wh_random_str=1?pid=mm_133066686_552000056_109002100173
        /// </summary>
        [JsonProperty("activityLink")]
        public string ActivityLink { get; set; }

        /// <summary>
        /// materialLink	素材链接	String	“https://gw.alicdn.com/tfs/TB1iUMatQP2gK0jSZPxXXacQpXa-440-180.jpg“
        /// </summary>
        [JsonProperty("materialLink")]
        public string MaterialLink { get; set; }

    }
}
