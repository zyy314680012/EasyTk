using EasyTk.HaoDanKu.Response;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 完整黑名单库API
    /// </summary>
    public class BlackListRequest : BaseRequest<WrapperResponse<List<BlackListResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/blacklist";
    }
}