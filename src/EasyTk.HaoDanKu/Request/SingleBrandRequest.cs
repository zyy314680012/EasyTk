using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    public class SingleBrandRequest : BaseRequest<WrapperResponse<SingleBrandResponse>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/singlebrand";

        #region 

        ///<summary> 
        ///id integer	integer	是	品牌ID
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        ///<summary> 
        ///back integer	integer	是	返回个数，默认返回20条数据
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; } = 20;

        ///<summary> 
        ///min_id integer	1	是	根据上一次请求作为下一次请求的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        ///<summary> 
        ///order integer	integer	是	自定义排序【1.最新，2.销量（高到低），3.销量（低到高），4.价格(低到高)，5.价格（高到低），6.佣金比例（高到低）】
        ///</summary>
        [JsonProperty("order")]
        public long Order { get; set; } = 1;

        #endregion
    }
}
