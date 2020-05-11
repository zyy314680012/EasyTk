using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiDetailRequest : BaseRequest<BaseResponseContainer<ApiDetailResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            " https://api.zhetaoke.com:10002/api/api_detail.ashx",
            "http://api.zhetaoke.cn:10000/api/api_detail.ashx"
        };

        #region =======================

        ///<summary> 
        ///tao_id string	是	单个商品ID
        ///</summary>
        [JsonProperty("tao_id")]
        public string TaoId { get; set; }

        ///<summary> 
        ///code string	否	折淘客编号，输入非折淘客商品编号，此参数无作用。code值可通过其它领券API接口结果获得。code值必须与tao_id值对应。
        ///</summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        ///<summary> 
        ///num_iids string	否	多个商品ID串，用,分割，最大40个。  如果该值非空，则只返回站内商品数据，否则返回全网商品。  该参数的主要应用环境，可以循环更新站内商品数据。  该参数非空时，目前限制一秒内访问一次。该参数为空时，无任何限制。
        ///</summary>
        [JsonProperty("num_iids")]
        public string NumIids { get; set; }

        ///<summary> 
        ///type string	否	是否返回S券和G券全部数据，type=0表示返回全部两条数据，type=1表示返回S券单条数据（如无S券数据返回G券单条数据），默认type=0。
        ///</summary>
        [JsonProperty("type")]
        public string Type { get; set; }


        #endregion
    }
}
