using EasyTk.HaoDanKu.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class FastBuyResponse : GoodItemPartial
    {
        ///<summary> 
        ///down_type integer	0	下架类型：1用户自主下架；2被拉黑下架；3被举报下架；4取消认证下架；5过期下架；6结算下架；7优惠券失效下架；8平台下架（一般7是已抢光的情况）
        ///</summary>
        [JsonProperty("down_type")]
        public long? DownType { get; set; }

        ///<summary> 
        ///material_id string	15	素材id
        ///</summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }

        ///<summary> 
        ///short_itemdesc string	让味道留住你卧龙的记忆	导购短语
        ///</summary>
        [JsonProperty("short_itemdesc")]
        public string ShortItemDesc { get; set; }

        ///<summary> 
        ///material_info string	****	素材内容，里面含image是更多实拍图，seckill_content是图文素材（图片调用方法http://img.haodanku.com/{image}-600）
        ///</summary>
        [JsonProperty("material_info")]
        public MaterialInfoData MaterialInfo { get; set; }

        ///<summary> 
        ///detial_video_cover string	10	实拍视频封面，可以通过改变链接中的w和h值分别改变宽高
        ///</summary>
        [JsonProperty("detial_video_cover")]
        public string DetialVideoCover { get; set; }

        ///<summary> 
        ///main_video_cover string	15	更多实拍视频封面，可以通过改变链接中的w和h值分别改变宽高
        ///</summary>
        [JsonProperty("main_video_cover")]
        public string MainVideoCover { get; set; }

        ///<summary> 
        ///grab_type string	3	快抢开抢状态：1快抢即将开始；2快抢商品已抢光；3快抢商品正在快抢中
        ///</summary>
        [JsonProperty("grab_type")]
        public string GrabType { get; set; }
        
        public class MaterialInfoData
        {
            ///<summary> 
            /// 更多实拍图
            ///</summary>
            [JsonProperty("image")]
            public string Image { get; set; }

            /// <summary>
            /// 图文素材
            /// </summary>
            [JsonProperty("seckill_content")]
            public string SecKillContent { get; set; }

            ///<summary> 
            ///main_video_url string	http:\/\/video.haodanku.com\/3YMFGz-lZxvmSH99SNqRz3mtU2s=\/FpU1L80LuAE1VrKUCcqPDSnMKYo0	实拍视频地址
            ///</summary>
            [JsonProperty("main_video_url")]
            public string MainVideoUrl { get; set; }

            ///<summary> 
            ///detail_video_url string	http:\/\/video.haodanku.com\/3YMFGz-lZxvmSH99SNqRz3mtU2s=\/FkKQiCloerAraG1B5hG6K0EwVwBL	更多实拍视频地址
            ///</summary>
            [JsonProperty("detail_video_url")]
            public string DetailVideoUrl { get; set; }
        }
    }
}
