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
            return GatewayArray[GetCurrentGatewayIndex()];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="total">总数</param>
        /// <returns></returns>
        public virtual string GetNextApiUrl(out int total)
        {
            total = GatewayArray.Length;
            if (total < 1)
            {
                throw new ArgumentException("未配置接口网关");
            }
            if (total == 1)
            {
                return GatewayArray[0];
            }
            var index = GetCurrentGatewayIndex();
            var newIndex = (index + 1) % total;
            var name = GetType().Name;
            RequestGatewayCurrentIndexCache[name] = new RequestGatewayIndex
            {
                AddTime = DateTime.Now,
                ExpiredTime = DateTime.Now.AddSeconds(120),
                Index = newIndex
            };

            return GatewayArray[newIndex];
        }

        private int GetCurrentGatewayIndex()
        {
            var name = GetType().Name;

            if (RequestGatewayCurrentIndexCache.ContainsKey(name))
            {
                if (RequestGatewayCurrentIndexCache[name].ExpiredTime < DateTime.Now)
                {
                    return RequestGatewayCurrentIndexCache[name].Index;
                }

                RequestGatewayCurrentIndexCache.Remove(name);
            }
            return 0;
        }

        /// <summary>
        /// 本地缓存
        /// </summary>
        private static readonly Dictionary<string, RequestGatewayIndex> RequestGatewayCurrentIndexCache =
            new Dictionary<string, BaseRequest<TResponse>.RequestGatewayIndex>();

        protected abstract string[] GatewayArray { get; }

        public class RequestGatewayIndex
        {
            public DateTime AddTime { get; set; }

            public DateTime ExpiredTime { get; set; }

            public int Index { get; set; }
        }
    }
}
