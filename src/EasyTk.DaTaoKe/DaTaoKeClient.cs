using EasyTk.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EasyTk.Core.Extensions;
using EasyTk.DaTaoKe.Request;
using EasyTk.Helpers;
using HttpMethod = EasyTk.Core.Enums.HttpMethod;

namespace EasyTk.DaTaoKe
{
    public class DaTaoKeClient : IClient
    {
        public string AppKey { get; private set; }
        public string Secret { get; private set; }
        public string Pid { get; private set; }

        public DaTaoKeClient(string appKey, string secret, string pid)
        {
            AppKey = appKey;
            Secret = secret;
            Pid = pid;
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : IResponse
        {
            var baseRequest = request as BaseRequest<TResponse>;
            if (baseRequest == null)
            {
                throw new ArgumentException("参数错误");
            }

            if (string.IsNullOrEmpty(baseRequest.AppKey))
            {
                baseRequest.AppKey = this.AppKey;
            }

            var method = baseRequest.GetMethod();
            var oldParameters = baseRequest.GetParametersNameAndValue();
            // 添加签名
            oldParameters.Add("sign", MakeSign(oldParameters));

            var parameters = new Dictionary<string, string>();
            foreach (var key in oldParameters.Keys)
            {
                parameters[key] = HttpUtility.UrlEncode(oldParameters[key]);
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
                    var query = string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}"));
                    response = await client.GetAsync(baseRequest.GetApiUrl() + "?" + query);
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

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private string MakeSign(Dictionary<string, string> parameters)
        {
            var sortedParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);

            var query = new StringBuilder();

            foreach (var sortedParam in sortedParams)
            {
                query.Append(sortedParam.Key).Append("=").Append(sortedParam.Value).Append("&");
            }
            query.Append("key=").Append(this.Secret);
            return Md5Helper.Md5(query.ToString());
        }
    }
}
