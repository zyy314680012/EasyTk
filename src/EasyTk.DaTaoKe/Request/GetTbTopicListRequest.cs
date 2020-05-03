using EasyTk.DaTaoKe.Response;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class GetTbTopicListRequest : BaseRequest<WrapperResponse<List<GetTbTopicListResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/category/get-tb-topic-list";

        public override string Version => "v1.2.0";

        #region 

        /// <summary>
        /// pageId	分页id	是	String	支持传统的页码分页方式
        /// </summary>
        [JsonProperty("pageId")]
        public string PageId { get; set; }

        /// <summary>
        /// pageSize	每页条数	否	Number	默认为20
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize { get; set; } = 20;

        /// <summary>
        /// type	端口类型	否	Number	输出的端口类型：0.全部（默认），1.PC，2.无线
        /// </summary>
        [JsonProperty("type")]
        public long? Type { get; set; }

        /// <summary>
        /// channelID	渠道ID	否	Number	阿里妈妈上申请的渠道id
        /// </summary>
        [JsonProperty("channelID")]
        public long? ChannelId { get; set; }

        #endregion
    }
}
