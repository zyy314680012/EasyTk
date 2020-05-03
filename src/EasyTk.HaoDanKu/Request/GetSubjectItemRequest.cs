using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 精选专题商品API
    /// </summary>
    public class GetSubjectItemRequest : BaseRequest<WrapperResponse<List<GetSubjectItemResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_subject_item";

        #region

        ///<summary> 
        ///id integer	178	专题id
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion
    }
}
