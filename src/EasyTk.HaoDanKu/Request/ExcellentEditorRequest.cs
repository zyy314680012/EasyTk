using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 精编文案API
    /// </summary>
    public class ExcellentEditorRequest : BaseRequest<WrapperResponse<List<ExcellentEditorResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/excellent_editor";

        #region 

        ///<summary> 
        ///min_id integer	1	是	分页，用于实现类似分页抓取效果，来源于上次获取后的数据的min_id值，默认开始请求值为1（该方案比单纯123分页的优势在于：数据更新的情况下保证不会重复也无需关注和计算页数）
        ///</summary>
        [JsonProperty("min_id")]
        public long MinId { get; set; } = 1;

        ///<summary> 
        ///back Integer	500	是	每页返回条数（请在1,2,10,20,50,100,120,200,500,1000中选择一个数值返回）
        ///</summary>
        [JsonProperty("back")]
        public long Back { get; set; } = 500;

        #endregion

    }
}
