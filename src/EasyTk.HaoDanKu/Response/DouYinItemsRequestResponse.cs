using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class DouYinItemsRequestResponse
    {
        ///<summary> 
        ///integer	553757100845	宝贝ID
        ///</summary>
        [JsonProperty("itemid")]
        public string ItemId { get; set; }

        ///<summary> 
        ///integer	http://video.haodanku.com/c436bbb2104e048915a523f1f44cb90d.mp4	视频地址
        ///</summary>
        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        ///<summary> 
        ///integer		抖音主播粉丝数
        ///</summary>
        [JsonProperty("douyin_emcee_fans")]
        public long? DouYinEmceeFans { get; set; }

        ///<summary> 
        ///integer	12	视频喜欢点赞数
        ///</summary>
        [JsonProperty("video_like_count")]
        public long? VideoLikeCount { get; set; }

        ///<summary> 
        ///integer	59	视频评论数
        ///</summary>
        [JsonProperty("video_comment_count")]
        public long? VideoCommentCount { get; set; }

        ///<summary> 
        ///integer	8	视频转发数
        ///</summary>
        [JsonProperty("video_forward_count")]
        public long? VideoForwardCount { get; set; }

        ///<summary> 
        ///string	https://p9-dy.byteimg.com/img/tos-cn-p-0015/5452b967dcf1409a961ac7a97b573d9e~c5_300x400.jpeg	视频第一帧图片地址（视频缩略图）
        ///</summary>
        [JsonProperty("first_frame")]
        public string FirstFrame { get; set; }

        ///<summary> 
        ///string	http://video.haodanku.com/ea9268f3e889608bbc6c978e6781fff2.gif	视频第一动态图
        ///</summary>
        [JsonProperty("dynamic_image")]
        public string DynamicImage { get; set; }

        ///<summary> 
        ///integer	2	视频分享量
        ///</summary>
        [JsonProperty("video_share_count")]
        public long? VideoShareCount { get; set; }

    }
}
