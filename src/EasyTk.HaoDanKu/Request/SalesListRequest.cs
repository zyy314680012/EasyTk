using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 各大榜单API
    /// </summary>
    public class SalesListRequest : BaseRequest<WrapperResponse<List<SalesListResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/sales_list";

        #region 

        ///<summary> 
        ///sale_type integer	1	是	榜单类型：sale_type=1是实时销量榜（近2小时销量），type=2是今日爆单榜，type=3是昨日爆单榜，type=4是出单指数版
        ///</summary>
        [JsonProperty("sale_type")]
        public long SaleType { get; set; }

        ///<summary> 
        ///cid integer	1	否	商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        ///</summary>
        [JsonProperty("cid")]
        public long? Cid { get; set; }

        ///<summary> 
        ///min_id integer	1	否	作为请求地址中获取下一页的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long? MinId { get; set; }

        ///<summary> 
        ///back integer	500	否	每页返回条数（请在1,2,10,20,50,100中选择一个数值返回，最多返回top100条数据）
        ///</summary>
        [JsonProperty("back")]
        public long? Back { get; set; }

        ///<summary> 
        ///item_type string	1	否	是否只获取营销返利商品，1是，0否
        ///</summary>
        [JsonProperty("item_type")]
        public long? ItemType { get; set; }

        #endregion
    }
}
