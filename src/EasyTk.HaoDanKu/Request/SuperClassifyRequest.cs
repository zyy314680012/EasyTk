using EasyTk.HaoDanKu.Response;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 超级分类API
    /// </summary>
    public class SuperClassifyRequest : BaseRequest<SuperClassifyResponse>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/super_classify";
    }
}
