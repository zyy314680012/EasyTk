using EasyTk.HaoDanKu.Response;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 商品筛选API
    /// </summary>
    public class ColumnRequest : BaseRequest<WrapperResponse<List<ColumnResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/column";

        #region

        ///<summary> 
        ///type integer	1	是	商品筛选类型：type=1是今日上新（当天新券商品），type=2是9.9包邮，type=3是30元封顶，type=4是聚划算，type=5是淘抢购，type=6是0点过夜单，type=7是预告单，type=8是品牌单，type=9是天猫商品，type=10是视频单，type=11是天猫超市单，type=12是偏远地区包邮单，type=13是淘宝商品
        ///</summary>
        [JsonProperty("type")]
        public long Type { get; set; } = 1;

        ///<summary> 
        ///back integer	500	是	每页返回条数（请在1,2,10,20,50,100,120,200,500,1000中选择一个数值返回）
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; } = 500;

        ///<summary> 
        ///min_id integer	1	是	分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        ///<summary> 
        ///sort integer	0	否	0.综合（最新），1.券后价(低到高)，2.券后价（高到低），3.券面额（高到低），4.月销量（高到低），5.佣金比例（高到低），6.券面额（低到高），7.月销量（低到高），8.佣金比例（低到高），9.全天销量（高到低），10全天销量（低到高），11.近2小时销量（高到低），12.近2小时销量（低到高），13.优惠券领取量（高到低），14.好单库指数（高到低）
        ///</summary>
        [JsonProperty("sort")]
        public long? Sort { get; set; }

        ///<summary> 
        ///cid integer	0	否	商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        ///</summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }

        ///<summary> 
        ///price_min integer	100	否	券后价筛选，筛选大于等于所设置的券后价的商品
        ///</summary>
        [JsonProperty("price_min")]
        public float? PriceMin { get; set; }

        ///<summary> 
        ///price_max integer	200	否	券后价筛选，筛选小于等于所设置的券后价的商品
        ///</summary>
        [JsonProperty("price_max")]
        public float? PriceMax { get; set; }

        ///<summary> 
        ///sale_min integer	1000	否	销量筛选，筛选大于等于所设置的销量的商品
        ///</summary>
        [JsonProperty("sale_min")]
        public long? SaleMin { get; set; }

        ///<summary> 
        ///sale_max integer	5000	否	销量筛选，筛选小于等于所设置的销量的商品
        ///</summary>
        [JsonProperty("sale_max")]
        public long? SaleMax { get; set; }

        ///<summary> 
        ///coupon_min integer	10	否	券金额筛选，筛选大于等于所设置的券金额的商品
        ///</summary>
        [JsonProperty("coupon_min")]
        public float? CouponMin { get; set; }

        ///<summary> 
        ///coupon_max integer	20	否	券金额筛选，筛选小于等于所设置的券金额的商品
        ///</summary>
        [JsonProperty("coupon_max")]
        public float? CouponMax { get; set; }

        ///<summary> 
        ///item_type string	0	否	是否只获取营销返利商品，1是，0否
        ///</summary>
        [JsonProperty("item_type")]
        public long? ItemType { get; set; }

        #endregion
    }
}
