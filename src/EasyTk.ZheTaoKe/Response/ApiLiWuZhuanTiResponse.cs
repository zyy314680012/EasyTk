using System;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ApiLiWuZhuanTiResponse
    {
        /// <summary>
        /// code":"27",
        /// </summary>
        [JsonProperty("code")]
        public long? Code { get; set; }

        /// <summary>
        /// type_id":"1",
        /// </summary>
        [JsonProperty("type_id")]
        public long? TypeId { get; set; }

        /// <summary>
        /// type_name":"综合",
        /// </summary>
        [JsonProperty("type_name")]
        public string TypeName { get; set; }

        /// <summary>
        /// title":"卡通花束礼物",
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// keywords":"卡通花束",
        /// </summary>
        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// jianjie":"小编为您提供大量精美的卡通花束礼物，包括各种优质的卡通花束礼物、珍贵的卡通花束礼物、特别的卡通花束礼物、实用的卡通花束礼物，以及各种让人感动的卡通花束礼物。希望您会喜欢并持续关注小编为您带来的各种精美的卡通花束礼物。",
        /// </summary>
        [JsonProperty("jianjie")]
        public string JianJie { get; set; }

        /// <summary>
        /// sucai_pic":"https://img.alicdn.com/bao/uploaded/i1/713945573/O1CN015TnUIW1r2TmJE72ei_!!0-item_pic.jpg_300x300.jpg",
        /// </summary>
        [JsonProperty("sucai_pic")]
        public string SuCaiPic { get; set; }

        /// <summary>
        /// get_url":"https://api.zhetaoke.com:10001/api/api_all.ashx?appkey={替换appkey}&page=1&page_size=20&sort=sale_num_desc&cid=0&q=卡通花束",
        /// </summary>
        [JsonProperty("get_url")]
        public string GetUrl { get; set; }

        /// <summary>
        /// publish_time":"2019/05/17 20:51:27"
        /// </summary>
        [JsonProperty("publish_time")]
        public DateTime? PublishTime { get; set; }

    }
}
