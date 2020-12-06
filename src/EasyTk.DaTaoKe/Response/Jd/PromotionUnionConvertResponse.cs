using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response.Jd
{
    public class PromotionUnionConvertResponse
    {
        /// <summary>
        /// shortUrl String https://u.jd.com/tpi8t9B 推广链接短链地址
        /// </summary>
        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// longUrl String 推广链接长链地址
        /// </summary>
        [JsonProperty("longUrl")]
        public string LongUrl { get; set; }
    }
}
