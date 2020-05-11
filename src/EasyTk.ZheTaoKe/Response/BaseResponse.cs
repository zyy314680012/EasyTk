using EasyTk.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyTk.ZheTaoKe.Response
{
    public abstract class BaseResponse : IResponse
    {
        public string Body { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public virtual bool IsSuccess => true;
    }

    public class BaseResponseContainer<T> : BaseResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("content")]
        public T Content { get; set; }

        public override bool IsSuccess => Status == 200;
    }
}
