using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    public class CheckSellerNickRequest : BaseRequest<WrapperResponse<CheckSellerNickResponse>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/check_sellernick";

        #region 

        ///<summary> 
        ///sellernick string	XX旗舰店	是	掌柜名
        ///</summary>
        [JsonProperty("sellernick")]
        public string SellerNick { get; set; }

        #endregion
    }
}
