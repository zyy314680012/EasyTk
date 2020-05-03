using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class GetTrillDataResponse : GoodItemPartial
    {
        ///<summary> 
        ///integer	38774	抖音商品ID
        ///</summary>
        [JsonProperty("dy_trill_id")]
        public long? DyTrillId { get; set; }

        ///<summary> 
        ///string	http://video.haodanku.com/0a391d5a3b1d9bc24a977d63ea0d30d1.mp4	抖音视频地址
        ///</summary>
        [JsonProperty("dy_video_url")]
        public string DyVideoUrl { get; set; }

        ///<summary> 
        ///integer	5986	抖音视频点赞数
        ///</summary>
        [JsonProperty("dy_video_like_count")]
        public long? DyVideoLikeCount { get; set; }

        ///<summary> 
        ///integer	1216	抖音视频分享量
        ///</summary>
        [JsonProperty("dy_video_share_count")]
        public long? DyVideoShareCount { get; set; }

        ///<summary> 
        ///string	https://p1-dy.byteimg.com/aweme/300x400/17bc80003b4aa89c5823b.jpeg	视频第一帧图片地址
        ///</summary>
        [JsonProperty("first_frame")]
        public string FirstFrame { get; set; }

        ///<summary> 
        ///string	http://video.haodanku.com/0db2bc0673ff2670508163cf9c8820fa.gif	视频缩略图（动态）
        ///</summary>
        [JsonProperty("dynamic_image")]
        public string DynamicImage { get; set; }

        ///<summary> 
        ///string	#是时候放大招了 穿它开空调需要盖被子????#好物推荐 @电商小助手	抖音视频标题
        ///</summary>
        [JsonProperty("dy_video_title")]
        public string DyVideoTitle { get; set; }

    }
}
