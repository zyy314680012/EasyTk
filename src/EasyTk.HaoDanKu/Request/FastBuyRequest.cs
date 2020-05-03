using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 快抢商品API
    /// </summary>
    public class FastBuyRequest : BaseRequest<WrapperResponse<List<FastBuyResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/fastbuy";

        #region 

        ///<summary> 
        ///hour_type integer	7	否	快抢时间点：1.昨天的0点，2.昨天10点，3.昨天12点，4.昨天15点，5.昨天20点，6.今天的0点，7.今天10点，8.今天12点，9.今天15点，10.今天20点，11.明天的0点，12.明天10点，13.明天12点，14.明天15点，15.明天20点
        ///</summary>
        [JsonProperty("hour_type")]
        public long? HourType { get; set; }

        ///<summary> 
        ///min_id integer	1	是	分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        #endregion
    }
}
