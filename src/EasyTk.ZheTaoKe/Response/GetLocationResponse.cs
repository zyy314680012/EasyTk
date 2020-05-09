using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class GetLocationResponse : BaseResponse
    {
        #region =================

        ///<summary> 
        ///status  200,
        ///</summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        ///<summary> 
        ///content  "https://item.taobao.com/item.htm?id=610638877760",
        ///</summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        ///<summary> 
        ///url_type  "1",
        ///</summary>
        [JsonProperty("url_type")]
        public string UrlType { get; set; }

        ///<summary> 
        ///url_id  "610638877760"
        ///</summary>
        [JsonProperty("url_id")]
        public string url_id { get; set; }


        #endregion
    }
}
