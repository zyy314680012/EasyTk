using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class SearchSuggestionRequest : BaseRequest<WrapperResponse<List<SearchSuggestionResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/search-suggestion";

        public override string Version => "v1.0.2";

        #region 

        /// <summary>
        /// keyWords	关键词	是	String	
        /// </summary>
        [JsonProperty("keyWords")]
        public string KeyWords { get; set; }

        /// <summary>
        /// type	当前搜索API类型：1.大淘客搜索 2.联盟搜索 3.超级搜索	是	Number
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; } = 1;

        #endregion
    }
}
