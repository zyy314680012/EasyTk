using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 作者文章API
    /// </summary>
    public class ManArticlesRequest : BaseRequest<WrapperResponse<List<ManArticlesResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/man_articles";

        #region 

        ///<summary> 
        ///id integer	747	是	达人文章ID
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion
    }
}
