using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class SearchSuggestionResponse
    {
        /// <summary>
        /// kw	联想词	String	裙子夏2019新款
        /// </summary>
        [JsonProperty("kw")]
        public string Kw { get; set; }

        /// <summary>
        /// total	对应联想词的商品数量（仅大淘客搜索返回该参数，当使用接口参数为2和3时，不会返回该字段）	Number	165
        /// </summary>
        [JsonProperty("total")]
        public long? Total { get; set; }

    }
}
