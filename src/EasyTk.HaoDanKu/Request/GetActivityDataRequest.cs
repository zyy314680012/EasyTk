using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 节日活动版块API -- 天猫3·8女王节
    /// </summary>
    public class GetActivityDataRequest : BaseRequest<WrapperResponse<List<GetActivityDataResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_activity_data";

        #region MyRegion

        ///<summary> 
        ///integer	0	否	商品类目：0全部，1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体，17宠物
        ///</summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }

        ///<summary> 
        ///integer	10	是	每页返回条数（请在1,2,5,10,20,50,100中选择一个数值返回）
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; }

        ///<summary> 
        ///integer	1	是	分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;


        #endregion
    }
}
