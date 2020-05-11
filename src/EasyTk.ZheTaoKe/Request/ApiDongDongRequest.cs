using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ApiDongDongRequest : BaseRequest<BaseResponseContainer<ApiDongDongResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_dongdong.ashx"
        };

        #region ============================

        /// <summary>
        /// page	int	否	分页获取数据,第几页
        /// </summary>
        [JsonProperty("page")]
        public long? Page { get; set; } = 1;

        /// <summary>
        /// page_size	int	否	每页数据条数（默认每页20条），可自定义1-50之间
        /// </summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; } = 20L;

        /// <summary>
        /// sort	string	否	商品排序方式，new：按照综合排序，total_sale_num_asc：按照总销量从小到大排序，total_sale_num_desc：按照总销量从大到小排序，sale_num_asc：按照月销量从小到大排序，sale_num_desc：按照月销量从大到小排序，commission_rate_asc：按照佣金比例从小到大排序，commission_rate_desc：按照佣金比例从大到小排序，price_asc：按照价格从小到大排序，price_desc：按照价格从大到小排序，coupon_info_money_asc：按照优惠券金额从小到大排序，coupon_info_money_desc：按照优惠券金额从大到小排序，shop_level_asc：按照店铺等级从低到高排序，shop_level_desc：按照店铺等级从高到低排序，tkfee_asc：按照返佣金额从低到高排序，tkfee_desc：按照返佣金额从高到低排序，code：按照code值从大到小排序，date_time：按照更新时间排序，random：按照随机排序
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// t	string	否	按照时间段获取，值为空：全部咚咚抢商品，8-10：当日8点到10点之间咚咚抢商品，不包含10点及以后时间。0点，8点，10点，13点，15点，17点，19点，20点 
        /// </summary>
        [JsonProperty("t")]
        public string T { get; set; }

        /// <summary>
        /// start_dongdong_time	string	否	咚咚抢开始时间，格式为：2019-08-22 00:00:00，可用来获取昨日前日等数据，获取今日数据不需要输入。
        /// </summary>
        [JsonProperty("start_dongdong_time")]
        public string StartDongDongTime { get; set; }

        /// <summary>
        /// end_dongdong_time	string	否	咚咚抢结束时间，格式为：2019-08-22 23:59:59，可用来获取昨日前日等数据，获取今日数据不需要输入。
        /// </summary>
        [JsonProperty("end_dongdong_time")]
        public string EndDongDongTime { get; set; }

        #endregion
    }
}
