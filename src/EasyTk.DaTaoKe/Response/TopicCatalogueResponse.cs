using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class TopicCatalogueResponse
    {
        /// <summary>
        /// topicId	活动ID	Number	32549
        /// </summary>
        [JsonProperty("topicId")]
        public long TopicId { get; set; }

        /// <summary>
        /// topicName	活动名称	String	“双11定金预售”
        /// </summary>
        [JsonProperty("topicName")]
        public string TopicName { get; set; }

        /// <summary>
        /// startTime	活动开始时间	Date	2019-10-22 11:00:00
        /// </summary>
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// endTime	活动结束时间	Date	2019-10-25 11:00:00
        /// </summary>
        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// banner	专辑活动banner（部分活动提供banner，可能提供多张）	list	“banner”: [“https://img.alicdn.com/imgextra/i3/2053469401/O1CN017nk61o2JJhynllMEo_!!2053469401.jpg","https://img.alicdn.com/imgextra/i2/2053469401/O1CN01RkMLNs2JJhyiN8RNo_!!2053469401.jpg“ ]
        /// </summary>
        [JsonProperty("banner")]
        public string[] Banner { get; set; }

    }
}
