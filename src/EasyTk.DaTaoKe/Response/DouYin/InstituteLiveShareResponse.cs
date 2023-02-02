using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class InstituteLiveShareResponse
    {
        #region

        /// <summary>
        /// dyDeeplink string snssdk://live.. Deeplink，允许外部APP直接唤起抖音直播间
        /// </summary>
        [JsonProperty("dyDeeplink")]
        public string DyDeeplink { get; set; }

        /// <summary>
        /// dyPassword string 6.9 gO:/【ceshi直播间】4.8:/ ÊÊn53CIbpa1SFr8ΨΨ，按长復製此消[转圈]夕条，哒揩ϓƗӢԂƠʮ[咖啡]搜缩，看TA直播##n53CIparSFr8## 抖口令
        /// </summary>
        [JsonProperty("dyPassword")]
        public string DyPassword { get; set; }

        /// <summary>
        /// dyZlink string https://z.douyin.com/xxxxxxx Zlink，允许外部APP直接唤起抖音直播间，未安装抖音应用用户，唤起抖音下载页，有效期60天
        /// </summary>
        [JsonProperty("dyZlink")]
        public string DyZlink { get; set; }

        /// <summary>
        /// qrCode object / 转链后的直播间抖音二维码
        /// </summary>
        [JsonProperty("qrCode")]
        public QrCodeInfo QrCode { get; set; }

        #endregion
    }
}
