using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EasyTk.Core;
using EasyTk.Core.Extensions;
using EasyTk.Helpers;
using EasyTk.PinDuoDuo.Request;
using HttpMethod = EasyTk.Core.Enums.HttpMethod;

namespace EasyTk.PinDuoDuo
{
    public class PinDuoDuoClient : IClient
    {
        public string ClientId { get; private set; }

        public string ClientSecret { get; private set; }

        public string Gateway { get; set; }

        public PinDuoDuoClient(string clientId, string clientSecret, string gateway)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Gateway = gateway;
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : IResponse
        {
            var baseRequest = request as BaseRequest<TResponse>;
            if (baseRequest == null)
            {
                throw new ArgumentException("参数错误");
            }

            FillDataFromClient(baseRequest);

            var method = baseRequest.GetMethod();
            var oldParameters = baseRequest.GetParametersNameAndJsonValue();
            oldParameters.Add("sign", MakeSign(oldParameters));

            var parameters = new Dictionary<string, string>();
            foreach (var key in oldParameters.Keys)
            {
                parameters[key] = HttpUtility.UrlEncode(oldParameters[key]);
            }

            HttpResponseMessage response = null;
            using (var client = HttpHelper.HttpClientFactory.CreateClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                if (method == HttpMethod.Post)
                {
                    var query = string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}"));
                    response = await client.PostAsync(baseRequest.GetApiUrl() + "?" + query, new StringContent(""));

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

        private void FillDataFromClient<TResponse>(BaseRequest<TResponse> request) where TResponse : IResponse
        {
            if (string.IsNullOrEmpty(request.ClientId))
            {
                request.ClientId = this.ClientId;
            }
            if (string.IsNullOrEmpty(request.ClientSecret))
            {
                request.ClientSecret = this.ClientSecret;
            }
            if (string.IsNullOrEmpty(request.Gateway))
            {
                request.Gateway = this.Gateway;
            }

            request.Timestamp = TimeHelper.GetTimestamp().ToString();
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

            query.Append(ClientSecret);
            foreach (var sortedParam in sortedParams)
            {
                query.Append(sortedParam.Key).Append(sortedParam.Value);
            }
            query.Append(ClientSecret);
            return Md5Helper.Md5(query.ToString()).ToUpper();
        }
    }
}
