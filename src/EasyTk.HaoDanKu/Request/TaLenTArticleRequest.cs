using EasyTk.HaoDanKu.Response;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 文章详情API
    /// css下载页面  https://pan.baidu.com/s/1RVGlM3Hijpg7BWt0m1HsZA
    /// </summary>
    public class TaLenTArticleRequest : BaseRequest<WrapperResponse<TaLenTArticleResponse>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/talent_article";

        #region 

        ///<summary> 
        ///id integer	747	是	达人文章ID
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion
    }
}
