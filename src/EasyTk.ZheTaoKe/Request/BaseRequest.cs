using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.Core;
using EasyTk.Core.Enums;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public abstract class BaseRequest<TResponse> : IRequest<TResponse> where TResponse : IResponse
    {
        #region ====== 公共参数 ======
        /// <summary>
        /// 对应的淘客账号授权ID
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }

        ///<summary> 
        ///string   折淘客的对接秘钥appkey
        ///</summary>
        [JsonProperty("appkey")]
        public string AppKey { get; set; }
        #endregion

        public virtual HttpMethod GetMethod()
        {
            return HttpMethod.Get;
        }

        public virtual string GetApiUrl()
        {
            return GatewayArray[0];
        }

        protected abstract string[] GatewayArray { get;}
    }
}
