using EasyTk.HaoDanKu.Response;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 猜你喜欢API
    /// </summary>
    public class GetSimilarInfoRequest : BaseRequest<WrapperResponse<List<GetSimilarInfoResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_similar_info";

        #region 

        ///<summary> 
        ///itemid string	564856111764	是	获取猜你喜欢的类型商品的宝贝ID，可以优先获取相同二级类目下的商品
        ///</summary>
        [JsonProperty("itemid")]
        public string ItemId { get; set; }

        #endregion
    }
}
