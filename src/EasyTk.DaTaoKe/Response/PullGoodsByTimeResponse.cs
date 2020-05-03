using EasyTk.DaTaoKe.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class PullGoodsByTimeResponse
    {
        [JsonProperty("list")]
        public PullGoodsByTimeListItem[] List { get; set; }

        public class PullGoodsByTimeListItem : GoodItemPartial
        {

        }
    }
}
