using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class ListSuperGoodsRequest : BaseRequest<WrapperResponseList<ListSuperGoodsResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/list-super-goods";

        public override string Version => "v1.2.1";

        #region 

        /// <summary>
        /// type	搜索类型	是	Number	0-综合结果，1-大淘客商品，2-联盟商品
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; }

        /// <summary>
        /// pageId	页码	是	Number	请求的页码，默认参数1
        /// </summary>
        [JsonProperty("pageId")]
        public long PageId { get; set; } = 1;

        /// <summary>
        /// pageSize	每页条数	是	Number	默认为20，最大值100
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = 20;

        /// <summary>
        /// keyWords	关键词搜索	是	String	
        /// </summary>
        [JsonProperty("keyWords")]
        public string KeyWords { get; set; }

        /// <summary>
        /// tmall	是否天猫商品	否	Number	1-天猫商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("tmall")]
        public long? TMall { get; set; }

        /// <summary>
        /// haitao	是否海淘商品	否	Number	1-海淘商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("haitao")]
        public long? HaiTao { get; set; }

        /// <summary>
        /// sort	排序字段	否	String	排序字段信息 销量（total_sales） 价格（price），排序_des（降序），排序_asc（升序）
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        #endregion
    }
}
