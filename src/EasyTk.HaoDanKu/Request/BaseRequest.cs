using EasyTk.Core;
using EasyTk.Core.Enums;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    public abstract class BaseRequest<TResponse> : IRequest<TResponse> where TResponse : IResponse
    {
        #region ====== 公共参数 ======

        ///<summary> 
        ///string	你的apikey	是	放单后台获取的Apikey值
        ///</summary>
        [JsonProperty("apikey")]
        public string ApiKey { get; set; }

        #endregion

        public virtual HttpMethod GetMethod()
        {
            return HttpMethod.Get;
        }

        public abstract string GetApiUrl();
    }
}
