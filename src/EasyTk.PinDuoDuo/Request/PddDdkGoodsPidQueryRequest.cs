using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 查询已经生成的推广位信息
    /// </summary>
    public class PddDdkGoodsPidQueryRequest:BaseRequest<PddDdkGoodsPidQueryResponse>
    {
        public override string Type => "pdd.ddk.goods.pid.query";

        #region 

        /// <summary>
        /// 返回的页数
        /// </summary>
        [JsonProperty("page")]
        public long? Page { get; set; }

        /// <summary>
        /// 返回的每页推广位数量
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; }

        /// <summary>
        /// 推广位id列表
        /// </summary>
        [JsonProperty("pid_list")]
        public string[] PidList { get; set; }

        /// <summary>
        /// status	INTEGER	非必填	推广位状态：0-正常，1-封禁
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

        #endregion
    }
}
