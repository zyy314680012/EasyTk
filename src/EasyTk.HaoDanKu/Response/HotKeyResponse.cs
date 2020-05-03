using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class HotKeyResponse
    {
        ///<summary> 
        ///keyword string	袜子	热搜关键词（每天返回昨天的关键词）
        ///</summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }
    }
}
