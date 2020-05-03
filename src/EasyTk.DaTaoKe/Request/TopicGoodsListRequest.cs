﻿using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class TopicGoodsListRequest : BaseRequest<WrapperResponseList<TopicGoodsListResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/topic/goods-list";

        #region

        /// <summary>
        /// pageId	分页id	是	String	默认为1，支持传统的页码分页方式和scroll_id分页方式，根据用户自身需求传入值。示例1：商品入库，则首次传入1，后续传入接口第一次返回的pageid，接口将持续返回符合条件的完整商品列表，该方式可以避免入库商品重复；示例2：根据pagesize和totalNum计算出总页数，按照需求返回指定页的商品（该方式可能在临近页取到重复商品）
        /// </summary>
        [JsonProperty("pageId")]
        public string PageId { get; set; } = "1";

        /// <summary>
        /// pageSize	每页条数	否	Number	默认为100，大于100按100处理
        /// </summary>
        [JsonProperty("pageSize")]
        public long? PageSize { get; set; }

        /// <summary>
        /// topicId	专辑id	是	Number	通过精选专辑API获取的活动id
        /// </summary>
        [JsonProperty("topicId")]
        public long TopicId { get; set; }

        #endregion
    }
}
