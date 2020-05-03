using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class GetDownItemsResponse
    {
        ///<summary> 
        ///string	558624933563	宝贝ID
        ///</summary>
        [JsonProperty("itemid")]
        public long ItemId { get; set; }

        ///<summary> 
        ///string	b432c1260e9c4f7a824f3e85cfd7135e	优惠券ID
        ///</summary>
        [JsonProperty("activityid")]
        public string ActivityId { get; set; }

        ///<summary> 
        ///string	1	下架原因（1失效，2过期，3价格改变（券条件不符），4低佣，5自主下架,6用户删除，7拉黑下架，8举报下架，9刷榜下架，10.更高优惠券替换下架，11.自主换券下架）
        ///</summary>
        [JsonProperty("down_type")]
        public int DownType { get; set; }

        ///<summary> 
        ///string	1511974807	下架时间（时间戳）
        ///</summary>
        [JsonProperty("down_time")]
        public long? DownTime { get; set; }
    }
}
