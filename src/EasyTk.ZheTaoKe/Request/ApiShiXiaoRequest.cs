using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiShiXiaoRequest : BaseRequest<BaseResponseContainer<ApiShiXiaoResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_shixiao.ashx"
        };

        #region =====================

        /// <summary>
        /// page	int	否	分页获取数据,第几页
        /// </summary>
        [JsonProperty("page")]
        public long? Page { get; set; } = 1L;

        /// <summary>
        /// page_size	int	否	每页数据条数（默认每页20条）,可自定义,最大100。
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; } = 20L;

        /// <summary>
        /// start_time	string	否	失效开始时间，如：2019-07-01 00:00:00
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// end_time	string	否	失效结束时间，如：2019-07-01 23:59:59
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        #endregion
    }
}
