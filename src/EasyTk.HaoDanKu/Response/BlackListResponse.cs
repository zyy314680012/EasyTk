using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class BlackListResponse
    {
        ///<summary> 
        ///sellernick string	XX旗舰店	掌柜名
        ///</summary>
        [JsonProperty("sellernick")]
        public string SellerNick { get; set; }
    }
}
