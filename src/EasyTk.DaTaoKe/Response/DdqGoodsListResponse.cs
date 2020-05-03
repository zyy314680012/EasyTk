using EasyTk.DaTaoKe.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class DdqGoodsListResponse : RoundsListItem
    {
        /// <summary>
        /// 	
        /// </summary>
        [JsonProperty("goodsList")]
        public GoodItemPartial[] GoodsList { get; set; }

        /// <summary>
        /// roundsList	场次列表	List	
        /// </summary>
        [JsonProperty("roundsList")]
        public RoundsListItem[] RoundsList { get; set; }
    }

    public class RoundsListItem
    {
        /// <summary>
        /// ddqTime	场次时间	String	2019-12-10 08:00:00
        /// </summary>
        [JsonProperty("ddqTime")]
        public string DdqTime { get; set; }

        /// <summary>
        /// status	场次状态,0-已开始，1-当前场次，2-未开始	Number	0
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
