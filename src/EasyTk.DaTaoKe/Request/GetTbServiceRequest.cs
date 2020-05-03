using EasyTk.DaTaoKe.Response;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class GetTbServiceRequest : BaseRequest<WrapperResponse<List<GetTbServiceResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tb-service/get-tb-service";

        public override string Version => "v2.0.0";

        #region

        /// <summary>
        /// pageNo	第几页	是	Number	默认1
        /// </summary>
        [JsonProperty("pageNo")]
        public long PageNo { get; set; } = 1;

        /// <summary>
        /// pageSize	每页条数	是	Number	页大小， 默认20，范围值1~100
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = 20;

        /// <summary>
        /// keyWords	查询词	是	String	查询词不能为空
        /// </summary>
        [JsonProperty("keyWords")]
        public string KeyWords { get; set; }

        /// <summary>
        /// sort	排序	否	String	排序指标：销量（total_sales），淘客佣金比率（tk_rate）， 累计推广量（tk_total_sales），总支出佣金（tk_total_commi），价格（price）,排序方式：排序_des（降序），排序_asc（升序）,示例：升序查询销量：total_sales_asc
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// source	是否商城商品	否	Number	设置为1表示该商品是属于淘宝商城商品，设置为非1或不设置表示不判断这个属性（和overseas字段冲突，若已请求source，请勿再请求overseas）
        /// </summary>
        [JsonProperty("source")]
        public long? Source { get; set; }

        /// <summary>
        /// overseas	是否海外商品	否	Number	是否海外商品，设置为1表示该商品是属于海外商品，设置为非1或不设置表示不判断这个属性（和source字段冲突，若已请求overseas，请勿再请求source）
        /// </summary>
        [JsonProperty("overseas")]
        public long? Overseas { get; set; }

        /// <summary>
        /// endPrice	折扣价范围上限	否	Number	单位：元
        /// </summary>
        [JsonProperty("endPrice")]
        public float? EndPrice { get; set; }

        /// <summary>
        /// startPrice	折扣价范围下限	否	Number	单位：元
        /// </summary>
        [JsonProperty("startPrice")]
        public float? StartPrice { get; set; }

        /// <summary>
        /// startTkRate	媒体淘客佣金比率下限	否	Number	如：1234表示12.34%
        /// </summary>
        [JsonProperty("startTkRate")]
        public float? StartTkRate { get; set; }

        /// <summary>
        /// endTkRate	商品筛选-淘客佣金比率上限	否	Number	如：1234表示12.34%
        /// </summary>
        [JsonProperty("endTkRate")]
        public float? EndTkRate { get; set; }

        /// <summary>
        /// hasCoupon	是否有优惠券	否	Boolean	设置为true表示该商品有优惠券，设置为false或不设置表示不判断这个属性
        /// </summary>
        [JsonProperty("hasCoupon")]
        public bool? HasCoupon { get; set; }

        #endregion
    }
}
