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
    /// <summary>
    /// 
    /// </summary>
    public sealed class ZheTaoKeClient : IClient
    {
        private readonly string _appKey;
        private readonly string _sid;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appKey"></param>
        /// <param name="sid"></param>
        public ZheTaoKeClient(string appKey, string sid)
        {
            _appKey = appKey;
            _sid = sid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
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

            return await ExecuteZheTaoKeAsync(baseRequest, 1);
        }

        private async Task<TResponse> ExecuteZheTaoKeAsync<TResponse>(BaseRequest<TResponse> baseRequest, int round, string requestData = null) where TResponse : IResponse
        {
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
                // client.Timeout = TimeSpan.FromSeconds(5);
                if (method == HttpMethod.Post)
                {
                    if (requestData == null)
                    {
                        requestData = string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}"));
                    }
                    var post = new StringContent(requestData, Encoding.UTF8);
                    response = await client.PostAsync(baseRequest.GetApiUrl(), post);

                }
                else if (method == HttpMethod.Get)
                {
                    if (requestData == null)
                    {
                        requestData = string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}"));
                    }
                    // var query = requestData;
                    response = await client.GetAsync(baseRequest.GetApiUrl() + "?" + requestData);
                }
            }

            if (response == null)
            {
                throw new HttpRequestException("接口请求异常");
            }

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    var result = Newtonsoft.Json.JsonConvert.DeserializeObject<TResponse>(content);
                    result.Body = content;
                    return result;
                }
            }
            else
            {
                var newApiUrl = baseRequest.GetNextApiUrl(out var total);
                if (round > total)
                {
                    throw new ArgumentException("接口全部请求异常");
                }

                return await ExecuteZheTaoKeAsync(baseRequest, round + 1, requestData);
            }
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        internal static async Task<TResponse> RequestAsync<TResponse>(string url, HttpMethod method = HttpMethod.Get) where TResponse : IResponse
        {
            HttpResponseMessage response = null;
            using (var client = HttpHelper.HttpClientFactory.CreateClient())
            {
                if (method == HttpMethod.Post)
                {
                    var post = new StringContent(string.Empty);
                    response = await client.PostAsync(url, post);

                }
                else if (method == HttpMethod.Get)
                {
                    response = await client.GetAsync(url);
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
