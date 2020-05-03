using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 抖货商品API
    /// </summary>
    public class GetTrillDataRequest : BaseRequest<WrapperResponse<List<GetTrillDataResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_trill_data";

        #region 

        ///<summary> 
        ///integer	1	否	商品类目： 抖货商品类目：0热门，1百变穿搭，2时尚潮男，3舒适好物，4美妆达人，5魅力配饰，6步履不停，7包罗万象，8萌娃驾到，9宝妈神器，10居家好物，11吃货专区，12数码达人，13用电能手，15伴你前行，16学习娱乐，17萌宠世界，14其他 （对应好单库商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物）
        ///</summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }

        ///<summary> 
        ///integer	1	否	自定义排序 1.好单指数；2.今日销量；3.两小时销量
        ///</summary>
        [JsonProperty("order")]
        public long? Order { get; set; }

        ///<summary> 
        ///integer	1	否	作为请求地址中获取下一页的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long? MinId { get; set; }

        ///<summary> 
        ///integer	10	否	每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回，最多一页返回100条数据）（默认是10）
        ///</summary>
        [JsonProperty("back")]
        public long? Back { get; set; }

        #endregion
    }
}
