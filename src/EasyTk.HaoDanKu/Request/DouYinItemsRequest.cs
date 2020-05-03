using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    public class DouYinItemsRequest : BaseRequest<WrapperResponse<List<DouYinItemsRequestResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/douyin_items";

        #region 

        ///<summary> 
        ///integer	596668952682	是	商品ID
        ///</summary>
        [JsonProperty("itemid")]
        public long ItemId { get; set; }

        ///<summary> 
        ///integer	1	否	作为请求地址中获取下一页的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        #endregion
    }
}
