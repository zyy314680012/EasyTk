using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using EasyTk.Core;
using System.Threading.Tasks;
using System.Web;
using EasyTk.Core.Extensions;
using EasyTk.ZheTaoKe.Request;
using EasyTk.Helpers;
using HttpMethod = EasyTk.Core.Enums.HttpMethod;

namespace EasyTk.ZheTaoKe
{
    public sealed class ZheTaoKeClient : IClient
    {
        private readonly string _appKey;
        private readonly string _sid;

        public ZheTaoKeClient(string appKey, string sid)
        {
            _appKey = appKey;
            _sid = sid;
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
                baseRequest.AppKey = _appKey;
            }

            if (string.IsNullOrEmpty(baseRequest.Sid))
            {
                baseRequest.Sid = _sid;
            }

            var method = baseRequest.GetMethod();
            var oldParameters = baseRequest.GetParametersNameAndValue();

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
    }
}
