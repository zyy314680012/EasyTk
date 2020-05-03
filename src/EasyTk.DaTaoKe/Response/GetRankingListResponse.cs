using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.DaTaoKe.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetRankingListResponseNormal : GoodItemPartial
    {
        #region 1.实时榜 2.全天榜 3.热推榜 4.复购榜 7.综合热搜榜

        /// <summary>
        /// ranking	榜单名次	Number	1
        /// </summary>
        [JsonProperty("ranking")]
        public long? Ranking { get; set; }

        /// <summary>
        /// newRankingGoods	是否新上榜商品（12小时内入榜的商品） 0.否1.是	Number	1
        /// </summary>
        [JsonProperty("newRankingGoods")]
        public long? NewRankingGoods { get; set; }

        /// <summary>
        /// avgSales	日均销量（仅复购榜返回该字段）	Number	
        /// </summary>
        [JsonProperty("avgSales")]
        public long? AvgSales { get; set; }

        /// <summary>
        /// entryTime	入榜时间（仅复购榜返回该字段）	String	
        /// </summary>
        [JsonProperty("entryTime")]
        public string EntryTime { get; set; }

        #endregion

    }

    public class GetRankingListResponseHotWorldRise
    {
        /// <summary>
        /// top	热词榜排名	Number	1
        /// </summary>
        [JsonProperty("top")]
        public long Top { get; set; }

        /// <summary>
        /// keyWord	热搜词	String
        /// </summary>
        [JsonProperty("keyWord")]
        public string KeyWord { get; set; }

        /// <summary>
        /// hotVal	排名热度值	Number	123456
        /// </summary>
        [JsonProperty("hotVal")]
        public long HotVal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("goodsList")]
        public GoodsItem[] GoodsList { get; set; }

        public class GoodsItem : GoodItemPartial
        {
            /// <summary>
            /// ranking	榜单名次	Number	1
            /// </summary>
            [JsonProperty("ranking")]
            public long? Ranking { get; set; }

            /// <summary>
            /// newRankingGoods	是否新上榜商品（12小时内入榜的商品） 0.否1.是	Number	1
            /// </summary>
            [JsonProperty("newRankingGoods")]
            public long? NewRankingGoods { get; set; }

            /// <summary>
            /// avgSales	日均销量（仅复购榜返回该字段）	Number	
            /// </summary>
            [JsonProperty("avgSales")]
            public long? AvgSales { get; set; }

            /// <summary>
            /// entryTime	入榜时间（仅复购榜返回该字段）	String	
            /// </summary>
            [JsonProperty("entryTime")]
            public string EntryTime { get; set; }

            /// <summary>
            /// score	Number	
            /// </summary>
            [JsonProperty("score")]
            public long? Score { get; set; }

            [JsonProperty("fresh")]
            public long? Fresh { get; set; }

            [JsonProperty("lowest")]
            public long? Lowest { get; set; }

        }
    }

    public class GetRankingListResponseHotWorld
    {
        /// <summary>
        /// top	热词榜排名	Number	1
        /// </summary>
        [JsonProperty("top")]
        public long Top { get; set; }

        /// <summary>
        /// keyWord	热搜词	String
        /// </summary>
        [JsonProperty("keyWord")]
        public string KeyWord { get; set; }

        /// <summary>
        /// hotVal	排名热度值	Number	123456
        /// </summary>
        [JsonProperty("hotVal")]
        public long? HotVal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("goodsList")]
        public GoodsItem[] GoodsList { get; set; }

        public class GoodsItem : GoodItemPartial
        {
            /// <summary>
            /// ranking	榜单名次	Number	1
            /// </summary>
            [JsonProperty("ranking")]
            public long? Ranking { get; set; }

            /// <summary>
            /// newRankingGoods	是否新上榜商品（12小时内入榜的商品） 0.否1.是	Number	1
            /// </summary>
            [JsonProperty("newRankingGoods")]
            public long? NewRankingGoods { get; set; }

            /// <summary>
            /// avgSales	日均销量（仅复购榜返回该字段）	Number	
            /// </summary>
            [JsonProperty("avgSales")]
            public long? AvgSales { get; set; }

            /// <summary>
            /// entryTime	入榜时间（仅复购榜返回该字段）	String	
            /// </summary>
            [JsonProperty("entryTime")]
            public string EntryTime { get; set; }

            /// <summary>
            /// score	Number	
            /// </summary>
            [JsonProperty("score")]
            public long? Score { get; set; }

            [JsonProperty("fresh")]
            public long? Fresh { get; set; }

            [JsonProperty("lowest")]
            public long? Lowest { get; set; }

        }
    }
}
