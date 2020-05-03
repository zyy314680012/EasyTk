using EasyTk.Core;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public abstract class BaseResponse : IResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        public string Body { get; set; }

        ///<summary> 
        ///Integer	1	状态码（1成功，0失败或没有数据返回）
        ///</summary>
        [JsonProperty("code")]
        public long Code { get; set; }

        ///<summary> 
        ///Integer	2	作为请求地址中获取下一页的参数值
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; }

        ///<summary> 
        ///string	SUCCESS	返回信息说明，SUCCESS代表成功获取，失败则有具体原因
        ///</summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public virtual bool IsSuccess => Code == 1;

    }

    public class WrapperResponse<TResponse> : BaseResponse
    {
        /// <summary>
        /// 数据
        /// </summary>
        [JsonProperty("data")]
        public TResponse Data { get; set; }
    }
}
