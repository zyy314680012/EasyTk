using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    public class GetGaoYongJingXuanRequest : BaseRequest<WrapperResponseDouYinPage<GetGaoYongJingXuanResponse>>
    {
        public override string GetApiUrl()
            => "https://openapi.dataoke.com/api/tiktok/tiktok-sx-goods-list";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// kw String 否 关键词
        /// </summary>
        [JsonProperty("kw")]
        public string Kw { get; set; }

        /// <summary>
        /// sort String 否 排序：0-综合排序，1-两小时销量，2-月销量，3-7天销量，4-24小时销量，6-总销量，7-30天达人推广数，11-佣金， 12-订单量，14-佣金比例
        /// </summary>
        [JsonProperty("sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// page String 否 页码
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// size String 否 每页数量
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// first_cate_ids String 否 筛选商品一级分类（360-食品饮料，345-居家百货，353-美妆个护，366-服饰内衣，371-鞋包配饰，380-生鲜果蔬，386-母婴童玩，392-数码家电，399-运动户外，405-宠物用品，408-医药保健，415-汽配摩托，419-图书音像，426-礼品文创
        /// </summary>
        [JsonProperty("first_cate_ids")]
        public int? FirstCateIds { get; set; }

        /// <summary>
        /// price_start String 否 筛选价格区间-最小值（单位元）
        /// </summary>
        [JsonProperty("price_start")]
        public double? PriceStart { get; set; }

        /// <summary>
        /// price_end String 否 筛选价格区间-最大值（单位元）
        /// </summary>
        [JsonProperty("price_end")]
        public double? PriceEnd { get; set; }

        /// <summary>
        /// commission_rate_start String 否 筛选佣金比例区间-最小值（x100%，如10%填10）
        /// </summary>
        [JsonProperty("commission_rate_start")]
        public string CommissionRateStart { get; set; }

        /// <summary>
        /// commission_rate_end String 否 筛选佣金比例区间-最大值（x100%，如10%填10）
        /// </summary>
        [JsonProperty("commission_rate_end")]
        public string CommissionRateEnd { get; set; }

        /// <summary>
        /// commission_amount_start String 否 筛选佣金金额区间-最小值（单位元）
        /// </summary>
        [JsonProperty("commission_amount_start")]
        public double? CommissionAmountStart { get; set; }

        /// <summary>
        /// commission_amount_end String 否 筛选佣金金额区间-最大值（单位元）
        /// </summary>
        [JsonProperty("commission_amount_end")]
        public double? CommissionAmountEnd { get; set; }

        /// <summary>
        /// sales_30day_start String 否 筛选月销量区间-最小值
        /// </summary>
        [JsonProperty("sales_30day_start")]
        public long? Sales_30dayStart { get; set; }

        /// <summary>
        /// sales_30day_end String 否 筛选月销量区间-最大值
        /// </summary>
        [JsonProperty("sales_30day_end")]
        public long? Sales_30dayEnd { get; set; }

        /// <summary>
        /// sales_start String 否 筛选总销量区间-最小值
        /// </summary>
        [JsonProperty("sales_start")]
        public long? SalesStart { get; set; }

        /// <summary>
        /// sales_end String 否 筛选总销量区间-最大值
        /// </summary>
        [JsonProperty("sales_end")]
        public long? SalesEnd { get; set; }


        #endregion
    }
}
