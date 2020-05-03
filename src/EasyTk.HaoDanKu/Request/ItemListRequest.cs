using System.Collections.Generic;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 商品列表页API
    /// </summary>
    public class ItemListRequest : BaseRequest<WrapperResponse<List<ItemListResponse>>>
    {
        #region ==== Properties ====

        ///<summary> 
        ///integer	1	是	默认是全部商品1（1实时跑单商品，2爆单榜商品，3全部商品，4纯视频单，5聚淘专区）
        ///</summary>
        [JsonProperty("nav")]
        public string Nav { get; set; }

        ///<summary> 
        ///integer	0	否	商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物（支持多类目筛选，如1,2获取类目为女装、男装的商品，逗号仅限英文逗号）
        ///</summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }

        ///<summary> 
        ///integer	500	是	每页返回条数（请在1,2,10,20,50,100,120,200,500中选择一个数值返回）
        ///</summary>
        [JsonProperty("back")]
        public long? Back { get; set; }

        ///<summary> 
        ///integer	1	是	分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; }

        ///<summary> 
        ///integer	0	否	0.综合（最新），1.券后价(低到高)，2.券后价（高到低），3.券面额（高到低），4.月销量（高到低），5.佣金比例（高到低），6.券面额（低到高），7.月销量（低到高），8.佣金比例（低到高），9.全天销量（高到低），10全天销量（低到高），11.近2小时销量（高到低），12.近2小时销量（低到高），13.优惠券领取量（高到低）注意：该排序仅对nav=3，4，5有效，1，2无效
        ///</summary>
        [JsonProperty("sort")]
        public long? Sort { get; set; }

        ///<summary> 
        ///integer	100	否	券后价筛选，筛选大于等于所设置的券后价的商品
        ///</summary>
        [JsonProperty("price_min")]
        public long? PriceMin { get; set; }

        ///<summary> 
        ///integer	200	否	券后价筛选，筛选小于等于所设置的券后价的商品
        ///</summary>
        [JsonProperty("price_max")]
        public long? PriceMax { get; set; }

        ///<summary> 
        ///integer	1000	否	销量筛选，筛选大于等于所设置的销量的商品
        ///</summary>
        [JsonProperty("sale_min")]
        public long? SaleMin { get; set; }

        ///<summary> 
        ///integer	5000	否	销量筛选，筛选小于等于所设置的销量的商品
        ///</summary>
        [JsonProperty("sale_max")]
        public long? SaleMax { get; set; }

        ///<summary> 
        ///integer	10	否	券金额筛选，筛选大于等于所设置的券金额的商品
        ///</summary>
        [JsonProperty("coupon_min")]
        public long? CouponMin { get; set; }

        ///<summary> 
        ///integer	20	否	券金额筛选，筛选小于等于所设置的券金额的商品
        ///</summary>
        [JsonProperty("coupon_max")]
        public long? CouponMax { get; set; }

        ///<summary> 
        ///integer	30	否	佣金比例筛选，筛选大于等于所设置的佣金比例的商品
        ///</summary>
        [JsonProperty("tkrates_min")]
        public long? TkratesMin { get; set; }

        ///<summary> 
        ///integer	50	否	佣金比例筛选，筛选小于所设置的佣金比例的商品
        ///</summary>
        [JsonProperty("tkrates_max")]
        public long? TkRatesMax { get; set; }

        ///<summary> 
        ///integer	30	否	佣金筛选，筛选大于等于所设置的佣金的商品
        ///</summary>
        [JsonProperty("tkmoney_min")]
        public long? TkMoneyMin { get; set; }

        ///<summary> 
        ///string	0	否	是否只获取营销返利商品，1是，0否
        ///</summary>
        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        #endregion

        public override string GetApiUrl() => "http://v2.api.haodanku.com/itemlist";
    }
}
