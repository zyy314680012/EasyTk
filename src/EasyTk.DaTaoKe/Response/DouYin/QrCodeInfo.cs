using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.DouYin
{
    public class QrCodeInfo
    {
        /// <summary>
        /// height number 360 高度
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// url string https://p3.douyinpic.com/img/aweme-qrcode/qiQmKs7076374500983588648~c5_360x360.webp?from=1723184758 地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// width number 360 宽度
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}
