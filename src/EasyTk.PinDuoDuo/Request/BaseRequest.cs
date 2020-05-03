using EasyTk.Core;
using EasyTk.Core.Enums;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    public abstract class BaseRequest<TResponse> : IRequest<TResponse> where TResponse : IResponse
    {
        public HttpMethod GetMethod() => HttpMethod.Post;

        public string GetApiUrl()
        {
            return Gateway;
        }

        [JsonIgnore]
        public virtual string ClientSecret { get; set; }

        [JsonIgnore]
        public virtual string Gateway { get; set; }

        #region 公共参数

        /// <summary>
        /// type 	String	必填	API接口名称
        /// </summary>
        [JsonProperty("type")]
        public abstract string Type { get; }

        /// <summary>
        /// client_id	String	必填	POP分配给应用的client_id
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// access_token	String	非必填	通过code获取的access_token(无需授权的接口，该字段不参与sign签名运算)
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// timestamp	String	必填	UNIX时间戳，单位秒，需要与拼多多服务器时间差值在10分钟内
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// data_type	String	非必填	响应格式，即返回数据的格式，JSON或者XML（二选一），默认JSON，注意是大写
        /// </summary>
        [JsonProperty("data_type")]
        public string DataType { get; set; } = "JSON";

        /// <summary>
        /// version	String	非必填	API协议版本号，默认为V1，可不填
        /// </summary>
        [JsonProperty("version")]
        public virtual string Version { get; set; } = "V1";

        ///// <summary>
        ///// sign	String	必填	API输入参数签名结果，签名算法参考开放平台接入指南第三部分底部。
        ///// </summary>
        //[JsonProperty("sign")]
        //public string Sign { get; set; }

        #endregion
    }
}
