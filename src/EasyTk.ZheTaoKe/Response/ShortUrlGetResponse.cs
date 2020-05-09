using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ShortUrlGetResponse : BaseResponse
    {
        ///<summary> 
        ///status  200,
        ///</summary>
        [JsonProperty("status")]
        public long? Status { get; set; }

        ///<summary> 
        ///shorturl  "https://s.click.taobao.com/mHO3uiv"
        ///</summary>
        [JsonProperty("shorturl")]
        public string ShortUrl { get; set; }
    }
}
