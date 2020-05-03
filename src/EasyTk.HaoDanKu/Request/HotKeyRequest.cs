using EasyTk.HaoDanKu.Response;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 热搜关键词记录API
    /// </summary>
    public class HotKeyRequest : BaseRequest<WrapperResponse<List<HotKeyResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/hot_key";
    }
}
