using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class CheckSellerNickResponse
    {
        ///<summary> 
        ///sellernick string	XX旗舰店	掌柜名
        ///</summary>
        [JsonProperty("sellernick")]
        public string SellerNick { get; set; }

        ///<summary> 
        ///report_reason string 加入黑名单理由
        ///</summary>
        [JsonProperty("report_reason")]
        public string ReportReason { get; set; }
    }
}
