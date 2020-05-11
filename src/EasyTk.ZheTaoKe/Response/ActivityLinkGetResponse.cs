using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ActivityLinkGetResponse : BaseResponse
    {
        [JsonProperty("tbk_sc_activitylink_toolget_response")]
        public TbkScActivityLinkToolGetResponse LinkToolGetResponse { get; set; }

        [JsonProperty("tbk_sc_activity_info_get_response")]
        public TbkScActivityInfoGetResponse InfoGetResponse { get; set; }

        public class TbkScActivityLinkToolGetResponse
        {
            ///<summary> 
            ///biz_error_code  0,
            ///</summary>
            [JsonProperty("biz_error_code")]
            public string BizErrorCode { get; set; }

            ///<summary> 
            ///data  "https:\/\/s.click.taobao.com\/t?e=m%3D2%26s%3Dged6jv9KNeBw4vFB6t2Z2iperVdZeJviU%2F9%2F0taeK29yINtkUhsv0EizdVr5gWE34Aad2wG5tPthAUEg3GA1uOlAmCX%2FrsdI4Mdh0cx0yJDwxZi19%2BIMzBM5oIgVQOdDQ%2BNeRhkrKyfCg%2Fx6BHtN2eIKl4JSR4lzy0DxCSzwFgFd1le1%2FF%2FLHZlaxqYYbv2RQxm%2F0%2Bwzw6%2FO54LQ%2FVw1L7rNOE9i8SvOEkEWzX%2FIvFU%2FF7Lz6F3ynK9NbmXcMIPfdYe117SOeFbp6SpZtUOKEQnfCJ26Jj8VSNJ6YzG9%2FpRsDvbh8Qt7h%2FzMWUx6tZLV%2BatRwG41zSavnajGJhfNNqJn5AyUbPoV&union_lens=lensId%3AOPT%401589181433%400b579757_0f17_1720298480d_48ae%4001",
            ///</summary>
            [JsonProperty("data")]
            public string Data { get; set; }

            ///<summary> 
            ///result_code  200,
            ///</summary>
            [JsonProperty("result_code")]
            public string ResultCode { get; set; }

            ///<summary> 
            ///request_id  "oylzriplt6cc"
            ///</summary>
            [JsonProperty("request_id")]
            public string RequestId { get; set; }
        }

        public class TbkScActivityInfoGetResponse
        {
            ///<summary>
            /// 
            ///</summary>
            [JsonProperty("data")]
            public TbkScActivityInfoGetData Data { get; set; }


            ///<summary> 
            ///request_id  "oylzriplt6cc"
            ///</summary>
            [JsonProperty("request_id")]
            public string RequestId { get; set; }
        }

        public class TbkScActivityInfoGetData
        {
            [JsonProperty("click_url")]
            public string ClickUrl { get; set; }
        }
    }
}
