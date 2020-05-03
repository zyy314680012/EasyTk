using EasyTk.Core;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class BaseResponse : IResponse
    {
        public string Body { get; set; }

        ///<summary> 
        /// 时间戳
        ///</summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        ///<summary>
        /// 0 正常
        ///-1 服务器错误	稍后尝试访问
        /// 1 参数错误 请根据msg提示信息进行修改
        /// 10007 参数错误 开始时间必须小于或等于结束时间
        ///</summary>
        [JsonProperty("code")]
        public long Code { get; set; }

        ///<summary> 
        ///信息
        ///</summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public virtual bool IsSuccess => Code == 0;
    }

    public class WrapperResponse<TResponse> : BaseResponse
    {
        /// <summary>
        /// 数据
        /// </summary>
        [JsonProperty("data")]
        public TResponse Data { get; set; }
    }

    /// <summary>
    /// 列表
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public class WrapperResponseList<TResponse> : BaseResponse
    {
        /// <summary>
        /// 数据
        /// </summary>
        [JsonProperty("data")]
        public WrapperResponseListData Data { get; set; }
        
        /// <summary>
        /// 列表
        /// </summary>
        public class WrapperResponseListData
        {
            [JsonProperty("list")]
            public TResponse[] List { get; set; }
            
            [JsonProperty("totalNum")]
            public long TotalNum { get; set; }

            [JsonProperty("pageId")]
            public string PageId { get; set; }
        }
    }
}
