using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 达人说API
    /// </summary>
    public class TaLenTInfoRequest : BaseRequest<WrapperResponse<TaLenTInfoResponse>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/talent_info";

        #region 

        ///<summary> 
        ///talentcat int	1	是	大家都在逛类目，文章类别（0.全部，1.好物,2.潮流,3.美食,4.生活）
        ///</summary>
        [JsonProperty("talentcat")]
        public long TalentCat { get; set; }

        #endregion
    }
}
