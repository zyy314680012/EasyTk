using System.Collections.Generic;
using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    public class BrandRequest : BaseRequest<BrandResponse>
    {
        /// <summary>
        /// 品牌列表API
        /// </summary>
        /// <returns></returns>
        public override string GetApiUrl() => "http://v2.api.haodanku.com/brand";

        #region

        ///<summary> 
        ///integer	integer	是	返回个数，默认返回20条数据
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; } = 20;

        ///<summary> 
        ///integer	1	是	根据上一次请求作为下一次请求的参数值，默认是1
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        ///<summary> 
        ///integer	1	否	品牌分类：默认选择全部分类，1是母婴童品，2百变女装，3是食品酒水，4是居家日用，5是美妆洗护，6是品质男装，7是舒适内衣，8是箱包配饰，9是男女鞋靴，10是宠物用品，11是数码家电，12是车品文体
        ///</summary>
        [JsonProperty("brandcat")]
        public long? BrandCat { get; set; }


        #endregion
    }
}
