using System.Collections.Generic;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 单品详情API
    /// </summary>
    public class ItemDetailRequest : BaseRequest<WrapperResponse<ItemDetailResponse>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/item_detail";

        #region 

        ///<summary> 
        ///itemid string	557787124271	是	获取详情的宝贝ID（目前仅支持好单库站内商品获取详情）
        ///</summary>
        [JsonProperty("itemid")]
        public string ItemId { get; set; }

        #endregion
    }
}
