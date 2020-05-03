using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    /// <summary>
    /// 失效商品
    /// 根据指定时间段返回该时间段内（开始时间和结束时间须为当日）因任何原因在大淘客下架商品，建议您每10分钟更新一次
    /// </summary>
    public class GetStaleGoodsByTimeRequest : BaseRequest<WrapperResponseList<GetStaleGoodsByTimeResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-stale-goods-by-time";

        public override string Version => "v1.0.1";

        #region 

        ///<summary> 
        ///pageSize 每页条数	否	Number	默认为100，最大值200，若小于10，则按10条处理，每页条数仅支持输入10,50,100,200
        ///</summary>
        [JsonProperty("pageSize")]
        public long? PageSize { get; set; }

        ///<summary> 
        ///pageId 分页id	是	String	默认为1，支持传统的页码分页方式和scroll_id分页方式，根据用户自身需求传入值。示例1：商品入库，则首次传入1，后续传入接口返回的pageid，接口将持续返回符合条件的完整商品列表，该方式可以避免入口商品重复；示例2：根据pagesize和totalNum计算出总页数，按照需求返回指定页的商品（该方式可能在临近页取到重复商品）
        ///</summary>
        [JsonProperty("pageId")]
        public string PageId { get; set; } = "1";

        ///<summary> 
        ///startTime 开始时间	否	String	默认为yyyy-mm-dd hh:mm:ss，商品下架的时间大于等于开始时间，开始时间需要在当日
        ///</summary>
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        ///<summary> 
        ///endTime 结束时间	否	String	默认为请求的时间，商品下架的时间小于等于结束时间，结束时间需要在当日
        ///</summary>
        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        #endregion
    }
}
