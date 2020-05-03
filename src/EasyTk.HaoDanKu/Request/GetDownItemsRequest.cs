using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 失效商品列表API
    /// </summary>
    public class GetDownItemsRequest : BaseRequest<WrapperResponse<List<GetDownItemsResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_down_items";

        #region ==== Properties ====

        ///<summary> 
        ///integer	1	是	小时点数，如0点是0、13点是13（最小值是0，最大值是23）
        ///</summary>
        [JsonProperty("start")]
        public int Start { get; set; }

        ///<summary> 
        ///integer	8	是	小时点数，如0点是0、13点是13（最小值是0，最大值是23）
        ///</summary>
        [JsonProperty("end")]
        public int End { get; set; }

        #endregion
    }
}
