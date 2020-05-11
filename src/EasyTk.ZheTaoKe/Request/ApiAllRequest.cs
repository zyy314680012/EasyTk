using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiAllRequest : BaseRequest<BaseResponseContainer<ApiAllResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_all.ashx",
            "http://api.zhetaoke.cn:10000/api/api_all.ashx"
        };

        #region ===========================

        ///<summary> 
        ///page int	否	分页获取数据,第几页
        ///</summary>
        [JsonProperty("page")]
        public long? Page { get; set; } = 1;

        ///<summary> 
        ///page_size int	否	每页数据条数（默认每页20条），可自定义1-50之间
        ///</summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; } = 20;

        ///<summary> 
        ///sort string	否	商品排序方式，new：按照综合排序，total_sale_num_asc：按照总销量从小到大排序，total_sale_num_desc：按照总销量从大到小排序，sale_num_asc：按照月销量从小到大排序，sale_num_desc：按照月销量从大到小排序，commission_rate_asc：按照佣金比例从小到大排序，commission_rate_desc：按照佣金比例从大到小排序，price_asc：按照价格从小到大排序，price_desc：按照价格从大到小排序，coupon_info_money_asc：按照优惠券金额从小到大排序，coupon_info_money_desc：按照优惠券金额从大到小排序，shop_level_asc：按照店铺等级从低到高排序，shop_level_desc：按照店铺等级从高到低排序，tkfee_asc：按照返佣金额从低到高排序，tkfee_desc：按照返佣金额从高到低排序，code：按照code值从大到小排序，date_time：按照更新时间排序，random：按照随机排序
        ///</summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        ///<summary> 
        ///cid int	否	一级商品分类，值为空：全部商品，1：女装，2：母婴，3：美妆，4：居家日用，5：鞋品，6：美食，7：文娱车品，8：数码家电，9：男装，10：内衣，11：箱包，12：配饰，13：户外运动，14：家装家纺
        ///</summary>
        [JsonProperty("cid")]
        public string Cid { get; set; }

        ///<summary> 
        ///tj string	否	是否天猫商品，值为空：全部商品，tmall：天猫商品，gold_seller：金牌卖家
        ///</summary>
        [JsonProperty("tj")]
        public string Tj { get; set; }

        ///<summary> 
        ///jt string	否	淘抢购或者聚划算，值为空：全部商品，taoqianggou：淘抢购商品，juhuasuan：聚划算商品
        ///</summary>
        [JsonProperty("jt")]
        public string Jt { get; set; }

        ///<summary> 
        ///jh string	否	海淘或者极有家，值为空：全部商品，haitao：海淘商品，jiyoujia：极有家商品
        ///</summary>
        [JsonProperty("jh")]
        public string Jh { get; set; }

        ///<summary> 
        ///today string	否	今日商品，值为空：全部商品，1：今日商品
        ///</summary>
        [JsonProperty("today")]
        public long? Today { get; set; }

        ///<summary> 
        ///yunfeixian string	否	运费险，值为空：全部商品，1：有运费险商品
        ///</summary>
        [JsonProperty("yunfeixian")]
        public long? YunFeiXian { get; set; }

        ///<summary> 
        ///pinpai string	否	精选品牌，值为空：全部商品，1：精选品牌商品
        ///</summary>
        [JsonProperty("pinpai")]
        public long? PinPai { get; set; }

        ///<summary> 
        ///tianmaochaoshi string	否	天猫超市，值为空：全部商品，1：天猫超市商品
        ///</summary>
        [JsonProperty("tianmaochaoshi")]
        public long? TianMaoChaoShi { get; set; }

        ///<summary> 
        ///price string	否	价格区间，值为空：全部商品，0.0-9.9：9.9元商品，0.0-19.9：19.9元商品
        ///</summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        ///<summary> 
        ///commission_rate_start string	否	佣金比例≥，值为空：全部商品，=20：佣金比例≥20的商品，=50：佣金比例≥50的商品
        ///</summary>
        [JsonProperty("commission_rate_start")]
        public float? CommissionRateStart { get; set; }

        ///<summary> 
        ///sale_num_start string	否	月销量≥ 值为空：全部商品，=500：月销量≥500的商品，=10000：月销量≥10000的商品
        ///</summary>
        [JsonProperty("sale_num_start")]
        public long? SaleNumStart { get; set; }

        ///<summary> 
        ///dsr_start string	否	动态评分≥ 值为空：全部商品，=4.6：动态评分≥4.6的商品，=4.9：动态评分≥4.9的商品
        ///</summary>
        [JsonProperty("dsr_start")]
        public float? DsrStart { get; set; }

        ///<summary> 
        ///coupon_amount_start string	否	券面额≥ 值为空：全部商品，=5：券面额≥5的商品，=20：券面额≥20的商品，=100：券面额≥100的商品
        ///</summary>
        [JsonProperty("coupon_amount_start")]
        public float? CouponAmountStart { get; set; }

        ///<summary> 
        ///q string	否	关键词 值为空：全部商品，：返回标题中带内衣的商品
        ///</summary>
        [JsonProperty("q")]
        public string Q { get; set; }

        ///<summary> 
        ///baodan string	否	极品爆单商品，值为空：全部商品，1：极品爆单商品（拍2件、拍3件、拍4件、拍5件、拍6件等）
        ///</summary>
        [JsonProperty("baodan")]
        public string Baodan { get; set; }

        ///<summary> 
        ///py_baoyou string	否	偏远地区包邮商品，值为空：全部商品，1：偏远地区包邮商品（新疆等地）
        ///</summary>
        [JsonProperty("py_baoyou")]
        public long? PyBaoYou { get; set; }

        ///<summary> 
        ///tag string	否	是否朋友圈火爆商品，值为空：全部商品，1：朋友圈火爆商品
        ///</summary>
        [JsonProperty("tag")]
        public long? Tag { get; set; }

        ///<summary> 
        ///start_date_time_yongjin string	否	数据更新开始时间，格式为：2019-08-22 17:00:00
        ///</summary>
        [JsonProperty("start_date_time_yongjin")]
        public string StartDateTimeYongJin { get; set; }

        ///<summary> 
        ///end_date_time_yongjin string	否	数据更新结束时间，格式为：2019-08-22 17:10:00
        ///</summary>
        [JsonProperty("end_date_time_yongjin")]
        public string EndDateTimeYongJin { get; set; }

        #endregion
    }
}
