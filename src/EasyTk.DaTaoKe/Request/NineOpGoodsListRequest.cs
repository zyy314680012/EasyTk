using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class NineOpGoodsListRequest : BaseRequest<WrapperResponseList<NineOpGoodsListResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/nine/op-goods-list";

        #region

        /// <summary>
        /// pageSize	每页条数	是	Number	默认为20，最大值100
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = 20;

        /// <summary>
        /// pageId	分页id	是	String	常规分页方式，请直接传入对应页码
        /// </summary>
        [JsonProperty("pageId")]
        public long PageId { get; set; } = 1;

        /// <summary>
        /// nineCid	精选类目Id	是	String	9.9精选的类目id，分类id请求详情：-1-精选，1 -居家百货，2 -美食，3 -服饰，4 -配饰，5 -美妆，6 -内衣，7 -母婴，8 -箱包，9 -数码配件，10 -文娱车品
        /// </summary>
        [JsonProperty("nineCid")]
        public long NineCid { get; set; } = -1;

        #endregion

    }
}
