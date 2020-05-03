using EasyTk.HaoDanKu.Response.Partial;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Response
{
    public class GetDeserveItemResponse : BaseResponse
    {
        [Newtonsoft.Json.JsonProperty("item_info")]
        public List<GetDeserveItemResponseData> ItemInfo { get; set; }

        public class GetDeserveItemResponseData : GoodItemPartial
        {
        }
    }
}
