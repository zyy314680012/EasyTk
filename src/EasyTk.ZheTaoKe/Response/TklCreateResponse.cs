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

        public async Task<TklCreateResponse> GetTklCreateResponse()
        {
            if (!string.IsNullOrEmpty(Model))
            {
                return this;
            }

            if (string.IsNullOrEmpty(Model) && !string.IsNullOrEmpty(Url))
            {
                return await ZheTaoKeClient.RequestAsync<TklCreateResponse>(Url);
            }
            return null;
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
