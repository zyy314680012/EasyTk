using System.Collections.Generic;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ApiSuggestResponse : BaseResponse
    {
        [JsonProperty("result")]
        public List<string[]> Result { get; set; }
    }
}
