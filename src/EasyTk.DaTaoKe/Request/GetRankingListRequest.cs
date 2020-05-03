using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EasyTk.Core;
using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class GetRankingListRequest
    {
    }

    public class GetRankingListRequestNormal : BaseRequest<WrapperResponse<List<GetRankingListResponseNormal>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-ranking-list";

        private long _rankType;

        /// <summary>
        /// rankType	榜单类型	是	Number	1.实时榜 2.全天榜 3.热推榜 4.复购榜 5.热词飙升榜 6.热词排行榜 7.综合热搜榜
        /// </summary>
        [JsonProperty("rankType")]
        public long RankType
        {
            get
            {
                if (!new long[] { 1, 2, 3, 4, 7 }.Contains(_rankType))
                {
                    throw new ArgumentException("RankType：1,2,3,4,7");
                }

                return _rankType;
            }
            set => _rankType = value;
        }

        /// <summary>
        /// cid	大淘客一级类目id	否	Number	仅对实时榜单、全天榜单有效
        /// </summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }
    }

    /// <summary>
    /// 热刺飙升
    /// </summary>
    public class GetRankingListRequestHotWorldRise : BaseRequest<WrapperResponse<List<GetRankingListResponseHotWorldRise>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-ranking-list";

        /// <summary>
        /// rankType	榜单类型	是	Number	1.实时榜 2.全天榜 3.热推榜 4.复购榜 5.热词飙升榜 6.热词排行榜 7.综合热搜榜
        /// </summary>
        [JsonProperty("rankType")]
        public long RankType => 5;

        /// <summary>
        /// cid	大淘客一级类目id	否	Number	仅对实时榜单、全天榜单有效
        /// </summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }
    }


    public class GetRankingListRequestHotWorld : BaseRequest<WrapperResponse<List<GetRankingListResponseHotWorld>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-ranking-list";

        /// <summary>
        /// rankType	榜单类型	是	Number	1.实时榜 2.全天榜 3.热推榜 4.复购榜 5.热词飙升榜 6.热词排行榜 7.综合热搜榜
        /// </summary>
        [JsonProperty("rankType")]
        public long RankType => 6;

        /// <summary>
        /// cid	大淘客一级类目id	否	Number	仅对实时榜单、全天榜单有效
        /// </summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }
    }
}
