using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    public class ListSimilerGoodsByOpenRequest : BaseRequest<WrapperResponse<List<ListSimilerGoodsByOpenResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/list-similer-goods-by-open";

        #region 

        /// <summary>
        /// id	大淘客的商品id	是	Number	
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// size	每页条数	否	Number	默认10 ， 最大值100
        /// </summary>
        [JsonProperty("size")]
        public long? Size { get; set; }

        #endregion
    }
}
