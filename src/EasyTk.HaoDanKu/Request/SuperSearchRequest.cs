using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 超级搜索API
    /// </summary>
    public class SuperSearchRequest : BaseRequest<SuperSearchResponse>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/supersearch";

        #region 

        ///<summary> 
        ///keyword string	%25e5%25a5%25b3%25e8%25a3%2585	是	搜索关键词，同时也支持宝贝ID搜索即keyword=itemid（由于存在特殊符号搜索的关键词必须进行两次urlencode编码）
        ///</summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        ///<summary> 
        ///back integer	10	是	每页返回条数（请在1,2,10,20,50,100中选择一个数值返回）
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; } = 10;

        ///<summary> 
        ///min_id integer	1	是	分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        ///<summary> 
        ///tb_p integer	1	是	淘宝分页，用于实现类似分页抓取效果，来源于上次获取后的数据的tb_p值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("tb_p")]
        public long TbP { get; set; } = 1;

        ///<summary> 
        ///sort integer	0	否	0.综合，1.最新，2.销量（高到低），3.销量（低到高），4.价格(低到高)，5.价格（高到低），6.佣金比例（高到低）
        ///</summary>
        [JsonProperty("sort")]
        public long? Sort { get; set; }

        ///<summary> 
        ///is_tmall integer	0	否	是否只取天猫商品：0否；1是，默认是0
        ///</summary>
        [JsonProperty("is_tmall")]
        public long? IsTMall { get; set; }

        ///<summary> 
        ///is_coupon integer	0	否	是否只取有券商品：0否；1是，默认是0
        ///</summary>
        [JsonProperty("is_coupon")]
        public long? IsCoupon { get; set; }

        ///<summary> 
        ///limitrate integer	0	否	佣金比例过滤0~100
        ///</summary>
        [JsonProperty("limitrate")]
        public float? LimitRate { get; set; }

        ///<summary> 
        ///startprice integer	0	否	最低原价（默认为0），例如传10则只取大于等于10元的原价商品数据
        ///</summary>
        [JsonProperty("startprice")]
        public float? StartPrice { get; set; }

        #endregion
    }
}
