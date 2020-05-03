using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public abstract class BaseResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

    }
}
