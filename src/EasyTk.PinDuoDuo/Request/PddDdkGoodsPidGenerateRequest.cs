using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 创建多多进宝推广位
    /// </summary>
    public class PddDdkGoodsPidGenerateRequest:BaseRequest<PddDdkGoodsPidGenerateResponse>
    {
        public override string Type => "pdd.ddk.goods.pid.generate";

        #region 

        /// <summary>
        /// 要生成的推广位数量，默认为10，范围为：1~100
        /// </summary>
        [JsonProperty("number")]
        public long Number { get; set; }

        /// <summary>
        /// 推广位名称，例如["1","2"]
        /// </summary>
        [JsonProperty("p_id_name_list")]
        public string[] PIdNameList { get; set; }

        #endregion
    }
}
