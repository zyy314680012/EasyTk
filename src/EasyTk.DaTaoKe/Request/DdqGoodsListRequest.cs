using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class DdqGoodsListRequest : BaseRequest<WrapperResponse<DdqGoodsListResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/category/ddq-goods-list";

        public override string Version => "v1.2.0";

        #region 

        /// <summary>
        /// roundTime	场次时间	否	String	默认为当前场次，场次时间输入方式：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("roundTime")]
        public string RoundTime { get; set; }

        #endregion
    }
}
