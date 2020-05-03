using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Response;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 失效举报API
    /// </summary>
    public class ApiReportRequest : BaseRequest<ApiReportResponse>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/api_report";
    }
}
