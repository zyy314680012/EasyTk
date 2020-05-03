﻿using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class GetOwnerGoodsRequest : BaseRequest<WrapperResponseList<GetOwnerGoodsResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-owner-goods";

        public override string Version => "v1.0.1";

        #region

        /// <summary>
        /// pageSize	每页条数	是	Number	默认为100，最大值200，若小于10，则按10条处理，每页条数仅支持输入10,50,100,200
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = 100;

        /// <summary>
        /// pageId	分页id	是	String	默认为1，支持传统的页码分页方式和scroll_id分页方式，根据用户自身需求传入值。示例1：商品入库，则首次传入1，后续传入接口返回的pageid，接口将持续返回符合条件的完整商品列表，该方式可以避免入口商品重复；示例2：根据pagesize和totalNum计算出总页数，按照需求返回指定页的商品（该方式可能在临近页取到重复商品）
        /// </summary>
        [JsonProperty("pageId")]
        public string PageId { get; set; } = "1";

        /// <summary>
        /// online	是否下架	否	Number	默认为1，1-未下架商品，0-已下架商品
        /// </summary>
        [JsonProperty("online")]
        public long? Online { get; set; }

        /// <summary>
        /// startTime	商品提交开始时间	否	Date	请求格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// endTime	商品上架结束时间	否	Date	请求格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// sort	排序字段	否	String	默认为0，0-综合排序，1-商品上架时间从新到旧，2-销量从高到低，3-领券量从高到低，4-佣金比例从高到低，5-价格（券后价）从高到低，6-价格（券后价）从低到高
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        #endregion
    }

}
