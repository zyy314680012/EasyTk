using System.Net.Http;
using System.Threading.Tasks;
using EasyTk.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyTk.ZheTaoKe.Response
{
    public class TklCreateResponse : BaseResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        ///<summary> 
        ///status  200,
        ///</summary>
        [JsonProperty("status")]
        public long Status { get; set; }

        ///<summary> 
        ///model  "￥mlo11oMAIFD￥"
        ///</summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        public async Task<TbkTpwdCreateResponse> GetTklCreateResponse()
        {
            if (!string.IsNullOrEmpty(Model))
            {
                return new TbkTpwdCreateResponse
                {
                    Body = string.Empty,
                    Response = new TbkTpwdCreateResponseData
                    {
                        RequestId = string.Empty,
                        Data = new TbkTpwdCreateResponseResult
                        {
                            Model = Model
                        }
                    }
                };
            }

            HttpResponseMessage response = null;
            using (var client = HttpHelper.HttpClientFactory.CreateClient())
            {
                response = await client.GetAsync(Url);
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    var result = JsonConvert.DeserializeObject<TbkTpwdCreateResponse>(content);
                    result.Body = content;
                    return result;
                }
            }

            return default;
        }

        public class TbkTpwdCreateResponse : BaseResponse
        {
            [JsonProperty("tbk_tpwd_create_response")]
            public TbkTpwdCreateResponseData Response { get; set; }
        }

        public class TbkTpwdCreateResponseData
        {
            [JsonProperty("data")]
            public TbkTpwdCreateResponseResult Data { get; set; }

            [JsonProperty("request_id")]
            public string RequestId { get; set; }
        }

        public class TbkTpwdCreateResponseResult
        {
            [JsonProperty("model")]
            public string Model { get; set; }
        }
    }
}
