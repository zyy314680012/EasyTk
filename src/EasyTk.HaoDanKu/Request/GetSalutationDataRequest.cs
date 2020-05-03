using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 早晚安问候语API
    /// </summary>
    public class GetSalutationDataRequest : BaseRequest<WrapperResponse<List<GetSalutationDataResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_salutation_data";

        #region

        ///<summary> 
        ///integer	1	否	作为请求地址中获取下一页的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        ///<summary> 
        ///integer	1	否	分类：1.早安问候；2.用餐问候；3.晚安问候；4.群内公告；5.节日问候；6.爆笑段子；7.其他
        ///</summary>
        [JsonProperty("category")]
        public long? Category { get; set; }

        ///<summary> 
        ///integer	10	否	状态，每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; } = 10;

        #endregion
    }
}
