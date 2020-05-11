using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ApiGuanJianCiResponse
    {
        /// <summary>
        /// keywords":"连衣裙"
        /// </summary>
        [JsonProperty("keywords")]
        public string Keywords { get; set; }
    }
}
