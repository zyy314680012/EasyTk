using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class GetSubjectResponse
    {
        ///<summary> 
        ///id integer	178	专题id，用于在下一个接口获取专题的商品
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        ///<summary> 
        ///name string	手机配件狂欢季	专题的标题
        ///</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        ///<summary> 
        ///image string	FlfXRXa3NK68Qy8Kvj_QscpMp3xw	专题banner（正方形图）,图片拼接地址如：http://img.haodanku.com/FlfXRXa3NK68Qy8Kvj_QscpMp3xw-600
        ///</summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        ///<summary> 
        ///app_image string	FosY6Szk5scmidEkK6tzIqMRM4kR	专题banner（长方形有弧度图）,图片拼接地址如：http://img.haodanku.com/FosY6Szk5scmidEkK6tzIqMRM4kR-600
        ///</summary>
        [JsonProperty("app_image")]
        public string AppImage { get; set; }

        ///<summary> 
        ///cms_image string	FhqJGdrTkCzI56350Ews0zEkMwBT	专题banner（长方形无弧度图）,图片拼接地址如：http://img.haodanku.com/FhqJGdrTkCzI56350Ews0zEkMwBT-600
        ///</summary>
        [JsonProperty("cms_image")]
        public string CmsImage { get; set; }

        ///<summary> 
        ///content string	【精致女人，浓妆淡抹总相宜】\n【你的妆容还要添加一点点小心机】\n妆抹得好，男神跑不了~\n快来看看小仙女的美妆秘籍~打造撩人彩妆！	专题的介绍文案题
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        ///<summary> 
        ///activity_start_time string	1531756800	专题活动开始时间戳
        ///</summary>
        [JsonProperty("activity_start_time")]
        public long? ActivityStartTime { get; set; }

        ///<summary> 
        ///activity_end_time string	1532361599	专题活动结束时间戳
        ///</summary>
        [JsonProperty("activity_end_time")]
        public long? ActivityEndTime { get; set; }
    }
}
