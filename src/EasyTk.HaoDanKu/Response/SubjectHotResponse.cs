using EasyTk.HaoDanKu.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class SubjectHotResponse : GoodItemPartial
    {
        ///<summary> 
        ///subject_id string	464	专场id
        ///</summary>
        [JsonProperty("subject_id")]
        public long SubjectId { get; set; }

        ///<summary> 
        ///name string	小小T恤	专场短标题
        ///</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        ///<summary> 
        ///content string	夏季孩童必备T恤$emoji表情[6]$\n清凉舒适，简单大方\n让小宝萌萌哒酷酷哒$emoji表情[43]$\n轻松凉爽一夏$emoji表情[50]$	专场导购内容show_text	string	夏季孩童必备T恤<img src='http:\/\/img.haodanku.com\/1_bqfh7.png'>清凉舒适，简单大方让小宝萌萌哒酷酷哒<img src='http:\/\/img.haodanku.com\/1_bqfh91.png'>轻松凉爽一夏<img src='http:\/\/img.haodanku.com\/1_bqfh96.png'>导购文案展示内容，含表情
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        ///<summary> 
        ///copy_text string	夏季孩童必备T恤😘清凉舒适，简单大方让小宝萌萌哒酷酷哒✨轻松凉爽一夏💦	导购文案复制内容，含表情
        ///</summary>
        [JsonProperty("copy_text")]
        public string CopyText { get; set; }

        ///<summary> 
        ///share_times string	1505	专场商品被分享次数
        ///</summary>
        [JsonProperty("share_times")]
        public long? ShareTimes { get; set; }

        ///<summary> 
        ///activity_start_time string	1532250000	专场开始时间戳
        ///</summary>
        [JsonProperty("activity_start_time")]
        public long? ActivityStartTime { get; set; }

        ///<summary> 
        ///activity_end_time string	1532509200	专场结束时间戳
        ///</summary>
        [JsonProperty("activity_end_time")]
        public long? ActivityEndTime { get; set; }

    }
}
