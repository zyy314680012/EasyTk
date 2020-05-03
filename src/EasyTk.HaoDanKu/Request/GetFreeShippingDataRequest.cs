using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 偏远地区包邮商品API
    /// </summary>
    public class GetFreeShippingDataRequest : BaseRequest<WrapperResponse<List<GetFreeShippingDataResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_free_shipping_data";

        #region 

        ///<summary> 
        ///integer	1	否	商品类目： 0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        ///</summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }

        ///<summary> 
        ///integer	1	否	作为请求地址中获取下一页的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long? MinId { get; set; }

        ///<summary> 
        ///integer	10	否	自定义排序 1.综合；2.券后价从高到低；3.券后价从低到高；4.销量从高到低；5.销量价从低到高；（默认是1）
        ///</summary>
        [JsonProperty("order")]
        public long? Order { get; set; }

        ///<summary> 
        ///integer	10	否	每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        ///</summary>
        [JsonProperty("back")]
        public long? Back { get; set; }

        ///<summary> 
        ///string	红枣	否	偏远地区包邮商品关键词搜索
        ///</summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        #endregion
    }
}
