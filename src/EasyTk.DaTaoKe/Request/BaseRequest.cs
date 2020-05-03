using EasyTk.Core;
using EasyTk.Core.Enums;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public abstract class BaseRequest<TResponse> : IRequest<TResponse> where TResponse : IResponse
    {
        public HttpMethod GetMethod() => HttpMethod.Get;

        public abstract string GetApiUrl();

        #region 公共参数

        ///<summary> 
        ///appKey 唯一验证	是	String	
        ///</summary>
        [JsonProperty("appKey")]
        public virtual string AppKey { get; set; }

        ///<summary> 
        ///version API接口版本号	是	String	当前版本： v1.2.2
        ///</summary>
        [JsonProperty("version")]
        public virtual string Version => "v1.2.2";

        #endregion
    }
}
