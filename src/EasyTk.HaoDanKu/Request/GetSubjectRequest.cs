using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Response;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 精选专题API
    /// 该专题约5-7天更新1次，每次至少更新2个专题，该接口需配合专题商品API去获取专题里的商品内容
    /// </summary>
    public class GetSubjectRequest : BaseRequest<WrapperResponse<List<GetSubjectResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_subject";
    }
}
