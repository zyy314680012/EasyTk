using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    /// <summary>
    /// 商品列表
    /// 构建商品库，数据入库，建议您首次获取全量商品时调用该接口，若您需要更新商品库中的商品数据（如销量、领券量等）请使用商品更新接口，若您需要获取更多增量商品请通过定时拉取接口获取新的商品信息，若您需要在库中删除失效商品，请使用失效商品接口进行查询后删除
    /// </summary>
    public class GetGoodsListRequest : BaseRequest<WrapperResponseList<GetGoodsListResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/get-goods-list";

        #region 

        ///<summary> 
        ///pageSize 每页条数	否	Number	默认为100，最大值200，若小于10，则按10条处理，每页条数仅支持输入10,50,100,200
        ///</summary>
        [JsonProperty("pageSize")]
        public long? PageSize { get; set; }

        ///<summary> 
        ///pageId 分页id	是	String	默认为1，支持传统的页码分页方式和scroll_id分页方式，根据用户自身需求传入值。示例1：商品入库，则首次传入1，后续传入接口返回的pageid，接口将持续返回符合条件的完整商品列表，该方式可以避免入口商品重复；示例2：根据pagesize和totalNum计算出总页数，按照需求返回指定页的商品（该方式可能在临近页取到重复商品）
        ///</summary>
        [JsonProperty("pageId")]
        public string PageId { get; set; } = "1";

        ///<summary> 
        ///sort 排序方式	否	String	默认为0，0-综合排序，1-商品上架时间从高到低，2-销量从高到低，3-领券量从高到低，4-佣金比例从高到低，5-价格（券后价）从高到低，6-价格（券后价）从低到高
        ///</summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        ///<summary> 
        ///cids 一级类目id	否	String	大淘客的一级分类id，如果需要传多个，以英文逗号相隔，如：”1,2,3”。当一级类目id和二级类目id同时传入时，会自动忽略二级类目id
        ///</summary>
        [JsonProperty("cids")]
        public string Cids { get; set; }

        ///<summary> 
        ///subcid 二级类目id	否	Number	大淘客的二级类目id，通过超级分类API获取。仅允许传一个二级id，当一级类目id和二级类目id同时传入时，会自动忽略二级类目id
        ///</summary>
        [JsonProperty("subcid")]
        public string SubCid { get; set; }

        ///<summary> 
        ///specialId 商品卖点	否	Number	1.拍多件活动；2.多买多送；3.限量抢购；4.额外满减；6.买商品礼赠
        ///</summary>
        [JsonProperty("specialId")]
        public long? SpecialId { get; set; }

        ///<summary> 
        ///juHuaSuan 是否聚划算	否	Number	1-聚划算商品，0-所有商品，不填默认为0
        ///</summary>
        [JsonProperty("juHuaSuan")]
        public long? JuHuaSuan { get; set; }

        ///<summary> 
        ///taoQiangGou 是否淘抢购	否	Number	1-淘抢购商品，0-所有商品，不填默认为0
        ///</summary>
        [JsonProperty("taoQiangGou")]
        public long? TaoQiangGou { get; set; }

        ///<summary> 
        ///tmall 是否天猫商品	否	Number	1-天猫商品，0-所有商品，不填默认为0
        ///</summary>
        [JsonProperty("tmall")]
        public long? TMall { get; set; }

        ///<summary> 
        ///tchaoshi 是否天猫超市商品	否	Number	1-天猫超市商品，0-所有商品，不填默认为0
        ///</summary>
        [JsonProperty("tchaoshi")]
        public long? TChaoShi { get; set; }

        ///<summary> 
        ///goldSeller 是否金牌卖家	否	Number	1-金牌卖家，0-所有商品，不填默认为0
        ///</summary>
        [JsonProperty("goldSeller")]
        public long? GoldSeller { get; set; }

        ///<summary> 
        ///haitao 是否海淘商品	否	Number	1-海淘商品，0-所有商品，不填默认为0
        ///</summary>
        [JsonProperty("haitao")]
        public long? HaiTao { get; set; }

        ///<summary> 
        ///pre 是否预告商品	否	Number	1-预告商品，0-非预告商品
        ///</summary>
        [JsonProperty("pre")]
        public long? Pre { get; set; }

        ///<summary> 
        ///brand 是否品牌商品	否	Number	1-品牌商品，0-所有商品，不填默认为0
        ///</summary>
        [JsonProperty("brand")]
        public long? Brand { get; set; }

        ///<summary> 
        ///brandIds 品牌id	否	String	当brand传入0时，再传入brandIds将获取不到结果。品牌id可以传多个，以英文逗号隔开，如：”345,321,323”
        ///</summary>
        [JsonProperty("brandIds")]
        public string BrandIds { get; set; }

        ///<summary> 
        ///priceLowerLimit 价格（券后价）下限	否	Number	
        ///</summary>
        [JsonProperty("priceLowerLimit")]
        public decimal? PriceLowerLimit { get; set; }

        ///<summary> 
        ///priceUpperLimit 价格（券后价）上限	否	Number	
        ///</summary>
        [JsonProperty("priceUpperLimit")]
        public decimal? PriceUpperLimit { get; set; }

        ///<summary> 
        ///couponPriceLowerLimit 最低优惠券面额	否	Number	
        ///</summary>
        [JsonProperty("couponPriceLowerLimit")]
        public decimal? CouponPriceLowerLimit { get; set; }

        ///<summary> 
        ///commissionRateLowerLimit 最低佣金比率	否	Number	
        ///</summary>
        [JsonProperty("commissionRateLowerLimit")]
        public decimal? CommissionRateLowerLimit { get; set; }

        ///<summary> 
        ///monthSalesLowerLimit 最低月销量	否	Number	
        ///</summary>
        [JsonProperty("monthSalesLowerLimit")]
        public long? MonthSalesLowerLimit { get; set; }

        ///<summary> 
        ///freeshipRemoteDistrict 偏远地区包邮	否	Number	1.是，0.否
        ///</summary>
        [JsonProperty("freeshipRemoteDistrict")]
        public long? FreeShipRemoteDistrict { get; set; }

        #endregion
    }
}
