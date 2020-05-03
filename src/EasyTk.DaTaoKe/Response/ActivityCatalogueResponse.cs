using System;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class ActivityCatalogueResponse
    {
        /// <summary>
        /// activityId	活动ID	Number	32549
        /// </summary>
        [JsonProperty("activityId")]
        public long ActivityId { get; set; }

        /// <summary>
        /// activityName	活动名称	String	“双11定金预售”
        /// </summary>
        [JsonProperty("activityName")]
        public string ActivityName { get; set; }

        /// <summary>
        /// startTime	活动开始时间	Date	2019-10-22 11:00:00
        /// </summary>
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// endTime	活动结束时间	Date	2019-10-25 11:00:00
        /// </summary>
        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// goodsLabel	单品标签图片	String	
        /// </summary>
        [JsonProperty("goodsLabel")]
        public string GoodsLabel { get; set; }

        /// <summary>
        /// detailLabel	商详页标签图片	String	
        /// </summary>
        [JsonProperty("detailLabel")]
        public string DetailLabel { get; set; }

        /// <summary>
        /// goodsType	活动商品类型 1.非定金商品 2.定金商品 3.付付定返红包	Number
        /// </summary>
        [JsonProperty("goodsType")]
        public long? GoodsType { get; set; }

    }
}
