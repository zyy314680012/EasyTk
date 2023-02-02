using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class LiveShareMaterialResponse
    {
        #region

        /// <summary>
        /// authorOpenid string fdfwe 达人open_id
        /// </summary>
        [JsonProperty("authorOpenid")]
        public string AuthorOpenid { get; set; }

        /// <summary>
        /// authorName string 我是kol 达人昵称
        /// </summary>
        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        /// <summary>
        /// authorPic string http://fake.png 直播头像
        /// </summary>
        [JsonProperty("authorPic")]
        public string AuthorPic { get; set; }

        /// <summary>
        /// authorLevel integer 1 达人等级
        /// </summary>
        [JsonProperty("authorLevel")]
        public int? AuthorLevel { get; set; }

        /// <summary>
        /// productCategory string 测试类目 商品类别
        /// </summary>
        [JsonProperty("productCategory")]
        public string[] ProductCategory { get; set; }

        /// <summary>
        /// city string 广州 作者城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// averageGmv string 1111111 场均gmv
        /// </summary>
        [JsonProperty("averageGmv")]
        public string AverageGmv { get; set; }

        /// <summary>
        /// fansNum number 222 粉丝数量
        /// </summary>
        [JsonProperty("fansNum")]
        public long? FansNum { get; set; }

        /// <summary>
        /// averageCommissionRate string 30 平均佣金率
        /// </summary>
        [JsonProperty("averageCommissionRate")]
        public double? AverageCommissionRate { get; set; }

        /// <summary>
        /// roomId string 1234567890 直播间id
        /// </summary>
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        /// <summary>
        /// isLive boolean true 正在直播
        /// </summary>
        [JsonProperty("isLive")]
        public bool? IsLive { get; set; }

        /// <summary>
        /// isEcom boolean true 正在带货直播
        /// </summary>
        [JsonProperty("isEcom")]
        public bool? IsEcom { get; set; }

        /// <summary>
        /// gender string male 性别 male/ female/ 未知
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// buyinId string 6523908954358943 主播百应ID
        /// </summary>
        [JsonProperty("buyinId")]
        public string BuyinId { get; set; }

        #endregion
    }
}
