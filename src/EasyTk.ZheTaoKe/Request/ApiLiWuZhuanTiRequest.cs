using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiLiWuZhuanTiRequest : BaseRequest<BaseResponseContainer<ApiLiWuZhuanTiResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_liwu_zhuanti.ashx"
        };

        #region ===========================

        /// <summary>
        /// page	int	否	分页获取数据,第几页
        /// </summary>
        [JsonProperty("page")]
        public long? Page { get; set; } = 1L;

        /// <summary>
        /// page_size	int	否	每页数据条数（默认每页20条），可自定义1-50之间
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; } = 20L;

        /// <summary>
        /// type_id	int	否	分类id，0表示全部，1表示综合类，以后会不断扩充分类
        /// </summary>
        [JsonProperty("type_id")]
        public long? TypeId { get; set; } = 0L;

        /// <summary>
        /// sort	string	否	排序方式，code_asc：表示按照code从小到大排序，code_desc：表示按照code从大到小排序，random：表示随机排序
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        #endregion
    }
}
