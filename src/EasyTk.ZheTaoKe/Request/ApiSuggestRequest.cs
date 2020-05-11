using EasyTk.ZheTaoKe.Response;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiSuggestRequest : BaseRequest<ApiSuggestResponse>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_suggest.ashx"
        };

        #region ==================================

        /// <summary>
        /// content	string	是	搜索关键词。请注意，该参数需要进行Urlencode编码后传入。。
        /// <br/>重要的事情说三遍：该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        #endregion
    }
}
