using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 定时拉取API
    /// </summary>
    public class TimingItemsRequest : BaseRequest<WrapperResponse<List<TimingItemsResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/timing_items";

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

        ///<summary> 
        ///integer	1	是	分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("min_id")]
        public long? MinId { get; set; } = 1;

        ///<summary> 
        ///Integer	500	是	每页返回条数（请在1,2,10,20,50,100,120,200,500,1000中选择一个数值返回）
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; }

        ///<summary> 
        ///string	0	否	是否只获取营销返利商品，1是，0否
        ///</summary>
        [JsonProperty("item_type")]
        public int? ItemType { get; set; }

        #endregion
    }
}