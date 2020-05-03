using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using EasyTk.Core;
using System.Threading.Tasks;
using System.Web;
using EasyTk.Core.Extensions;
using EasyTk.HaoDanKu.Request;
using EasyTk.Helpers;
using HttpMethod = EasyTk.Core.Enums.HttpMethod;

namespace EasyTk.HaoDanKu
{
    public sealed class HaoDanKuClient : IClient
    {
        #region 属性

        /// <summary>
        /// apikey	string	你的apikey	是	放单后台获取的Apikey值
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apikey")]
        public string ApiKey { get; set; }

        #endregion

        public HaoDanKuClient(string apiKey)
        {
            ApiKey = apiKey;
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : IResponse
        {
            var baseRequest = request as BaseRequest<TResponse>;
            if (baseRequest == null)
            {
                throw new ArgumentException("参数错误");
            }

            if (string.IsNullOrEmpty(baseRequest.ApiKey))
            {
                baseRequest.ApiKey = this.ApiKey;
            }

            var method = baseRequest.GetMethod();
            var oldParameters = baseRequest.GetParametersNameAndValue();

            var parameters = new Dictionary<string, string>();

            foreach (var key in oldParameters.Keys)
            {
                parameters[key] = HttpUtility.UrlEncode(HttpUtility.UrlEncode(oldParameters[key]));
            }

            HttpResponseMessage response = null;
            using (var client = HttpHelper.HttpClientFactory.CreateClient())
            {
                if (method == HttpMethod.Post)
                {
                    var post = new StringContent(string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}")), Encoding.UTF8);
                    response = await client.PostAsync(baseRequest.GetApiUrl(), post);

                }
                else if (method == HttpMethod.Get)
                {
                    var query = string.Join("/", parameters.Select(p => $"{p.Key}/{p.Value}"));
                    response = await client.GetAsync(baseRequest.GetApiUrl() + "/" + query);
                }
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    var result = Newtonsoft.Json.JsonConvert.DeserializeObject<TResponse>(content);
                    result.Body = content;
                    return result;
                }
            }
            return default;
        }
    }
}
