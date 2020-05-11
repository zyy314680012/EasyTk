using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ActivityLinkGetRequest : BaseRequest<ActivityLinkGetResponse>
    {
        #region ===========================

        ///<summary> 
        ///adzone_id string	是	推广位id，mm_xx_xx_xx pid三段式中的第三段
        ///</summary>
        [JsonProperty("adzone_id")]
        public string AdZoneId { get; set; }

        ///<summary> 
        ///site_id int	是	推广位id，mm_xx_xx_xx pid三段式中的第二段
        ///</summary>
        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        ///<summary> 
        ///promotion_scene_id string	是	官方活动ID，从官方活动页获取。点击查看官方活动 https://pub.alimama.com/myunion.htm?spm=a219t.7900221/1.1998910419.dd403b0ca.2a8f75a5zXjUVR#!/promo/self/activity
        /// 饿了么活动ID：1571715733668，正式上线时间：2019年12月4日
        /// 口碑主会场活动ID：1583739244161，正式上线时间：2020年3月17日
        /// 生活服务分会场活动ID：1583739244162，正式上线时间：2020年3月17日
        /// 注意：口碑主会场活动和生活服务分会场，是调用的另外一个官方接口，调用接口后，返回的json格式和字段不同，请大家自行匹配。
        ///</summary>
        [JsonProperty("promotion_scene_id")]
        public string PromotionSceneId { get; set; }

        ///<summary> 
        ///platform string	否	1：PC，2：无线，默认：１
        ///</summary>
        [JsonProperty("platform")]
        public long? Platform { get; set; } = 1L;

        ///<summary> 
        ///union_id string	否	自定义输入串，英文和数字组成，长度不能大于12个字符，区分不同的推广渠道
        ///</summary>
        [JsonProperty("union_id")]
        public string UnionId { get; set; }

        ///<summary> 
        ///relation_id string	否	渠道关系ID，仅适用于渠道推广场景
        ///</summary>
        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        ///<summary> 
        ///type string	否	0：返回推广长链接，1：返回微信小程序地址（仅限饿了么、口碑两个活动），默认0
        ///</summary>
        [JsonProperty("type")]
        public int? Type { get; set; } = 0;


        #endregion

        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_activitylink_get.ashx"
        };
    }
}
