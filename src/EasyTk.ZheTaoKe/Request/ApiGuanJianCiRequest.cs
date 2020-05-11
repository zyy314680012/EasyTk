using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiGuanJianCiRequest : BaseRequest<BaseResponseContainer<ApiGuanJianCiResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_guanjianci.ashx"
        };

        #region ========================

        /// <summary>
        /// page	int	否	分页获取数据,第几页
        /// </summary>
        [JsonProperty("page")]
        public long? Page { get; set; } = 1;

        /// <summary>
        /// page_size	int	否	每页数据条数（默认每页1000条）,可自定义。
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; } = 1000;

        /// <summary>
        /// type	string	否	类型，0：PC端，1：移动端
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        #endregion
    }
}
