using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.DaTaoKe.Request
{
    public class GetBrandListRequest : BaseRequest<WrapperResponse<List<GetBrandListResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tb-service/get-brand-list";

        public override string Version => "v1.1.1";

        #region

        /// <summary>
        /// pageId	页码	是	String	
        /// </summary>
        [JsonProperty("pageId")]
        public long PageId { get; set; } = 1;

        /// <summary>
        /// pageSize	每页条数	否	Number	默认为20，最大值100
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = 20;

        #endregion
    }
}
