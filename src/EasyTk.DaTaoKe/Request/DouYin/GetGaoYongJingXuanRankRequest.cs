using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    public class GetGaoYongJingXuanRankRequest : BaseRequest<WrapperResponseDouYinList<GetGaoYongJingXuanRankResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tiktok/tiktok-sx-goods-rank";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// sort_key String 否 榜单类型，不填默认返实时销量榜。comprehensive_score ：实时销量榜 ；drainage_product_list ：引流榜 ；meat_list： 利润商品榜 ；quality_product_list：品质商品榜
        /// </summary>
        [JsonProperty("sort_key")]
        public string SortKey { get; set; }

        /// <summary>
        /// cate1 String 否 榜单类目，不填默认返综合。360-食品饮料，345-居家百货，353-美妆个护，366-服饰内衣，371-鞋包配饰，380-生鲜果蔬，386-母婴童玩，392-数码家电，399-运动户外，405-宠物用品，408-医药保健，415-汽配摩托，419-图书音像，426-礼品文创
        /// </summary>
        [JsonProperty("cate1")]
        public string Cate1 { get; set; }

        /// <summary>
        /// sort String 否 销量榜单维度 1-2小时销量 2-月销量 3-7日销量 4-24小时销量 6-总销量；sort_key为comprehensive_score 时必填
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        #endregion
    }
}
