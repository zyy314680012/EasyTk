using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    /// <summary>
    /// 商品更新
    /// 商品的部分信息会在商品售卖及推广过程中有所变更，您可以通过该接口对销量、领券量等数据进行实时更新
    /// </summary>
    public class GetNewestGoodsRequest : BaseRequest<WrapperResponseList<GetNewestGoodsResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-newest-goods";

        public override string Version => "v1.1.0";

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
        /// startTime	商品上架开始时间	否	Date	请求格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// endTime	商品上架结束时间	否	Date	请求格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// cids	一级类目Id	否	String	大淘客的一级分类id，如果需要传多个，以英文逗号相隔，如：”1,2,3”。当一级类目id和二级类目id同时传入时，会自动忽略二级类目id，1 -女装，2 -母婴，3 -美妆，4 -居家日用，5 -鞋品，6 -美食，7 -文娱车品，8 -数码家电，9 -男装，10 -内衣，11 -箱包，12 -配饰，13 -户外运动，14 -家装家纺
        /// </summary>
        [JsonProperty("cids")]
        public string Cids { get; set; }

        /// <summary>
        /// subcid	二级类目Id	否	Number	大淘客的二级类目id，通过超级分类API获取。仅允许传一个二级id，当一级类目id和二级类目id同时传入时，会自动忽略二级类目id
        /// </summary>
        [JsonProperty("subcid")]
        public long? SubCid { get; set; }

        /// <summary>
        /// juHuaSuan	是否聚划算	否	Number	1-聚划算商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("juHuaSuan")]
        public long? JuHuaSuan { get; set; }

        /// <summary>
        /// taoQiangGou	是否淘抢购	否	Number	1-淘抢购商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("taoQiangGou")]
        public long? TaoQiangGou { get; set; }

        /// <summary>
        /// tmall	是否天猫商品	否	Number	1-天猫商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("tmall")]
        public long? TMall { get; set; }

        /// <summary>
        /// tchaoshi	是否天猫超市商品	否	Number	1-天猫超市商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("tchaoshi")]
        public long? TChaoShi { get; set; }

        /// <summary>
        /// goldSeller	是否金牌卖家	否	Number	1-金牌卖家，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("goldSeller")]
        public long? GoldSeller { get; set; }

        /// <summary>
        /// haitao	是否海淘商品	否	Number	1-海淘商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("haitao")]
        public long? HaiTao { get; set; }

        /// <summary>
        /// brand	是否品牌商品	否	Number	1-品牌商品，0-所有商品，不填默认为0
        /// </summary>
        [JsonProperty("brand")]
        public long? Brand { get; set; }

        /// <summary>
        /// brandIds	品牌id	否	String	当brand传入0时，再传入brandIds将获取不到结果。品牌id可以传多个，以英文逗号隔开，如：”345,321,323”
        /// </summary>
        [JsonProperty("brandIds")]
        public string BrandIds { get; set; }

        /// <summary>
        /// priceLowerLimit	价格（券后价）下限	否	Number	
        /// </summary>
        [JsonProperty("priceLowerLimit")]
        public float? PriceLowerLimit { get; set; }

        /// <summary>
        /// priceUpperLimit	价格（券后价）上限	否	Number	
        /// </summary>
        [JsonProperty("priceUpperLimit")]
        public float? PriceUpperLimit { get; set; }

        /// <summary>
        /// couponPriceLowerLimit	最低优惠券面额	否	Number	
        /// </summary>
        [JsonProperty("couponPriceLowerLimit")]
        public float? CouponPriceLowerLimit { get; set; }

        /// <summary>
        /// commissionRateLowerLimit	最低佣金比率	否	Number	
        /// </summary>
        [JsonProperty("commissionRateLowerLimit")]
        public float? CommissionRateLowerLimit { get; set; }

        /// <summary>
        /// monthSalesLowerLimit	最低月销量	否	Number	
        /// </summary>
        [JsonProperty("monthSalesLowerLimit")]
        public long? MonthSalesLowerLimit { get; set; }

        /// <summary>
        /// sort	排序字段	否	String	默认为0，0-综合排序，1-商品上架时间从新到旧，2-销量从高到低，3-领券量从高到低，4-佣金比例从高到低，5-价格（券后价）从高到低，6-价格（券后价）从低到高
        /// </summary>
        [JsonProperty("sort")]
        public long? Sort { get; set; }

        #endregion
    }
}
