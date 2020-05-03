using System.Collections.Generic;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    public class LowPricePinkAgeDataRequest : BaseRequest<WrapperResponse<List<LowPricePinkAgeDataResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/low_price_Pinkage_data";

        #region 

        ///<summary> 
        ///integer	1	否	作为请求地址中获取下一页的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; }

        ///<summary> 
        ///integer	10	否	自定义排序 1.综合；2.券后价从高到低；3.券后价从低到高；4.销量从高到低；5.销量价从低到高；（默认是1）
        ///</summary>
        [JsonProperty("order")]
        public long? Order { get; set; }

        ///<summary> 
        ///integer	10	否	状态，每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        ///</summary>
        [JsonProperty("back")]
        public long? Back { get; set; }

        ///<summary> 
        ///integer	1	否	状态，1.精选专区；2. 9.9专区；3. 6.9专区；4. 3.9专区（默认1）
        ///</summary>
        [JsonProperty("type")]
        public long? Type { get; set; }

        #endregion
    }
}