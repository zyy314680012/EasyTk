using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiLunBoRequest : BaseRequest<BaseResponseContainer<ApiLunBoResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_lunbo.ashx"
        };

        #region =================================

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

        #endregion
    }
}
