using EasyTk.HaoDanKu.Response;
using System.Collections.Generic;

namespace EasyTk.HaoDanKu.Request
{
    public class BrandSubjectItemsRequest : BaseRequest<WrapperResponse<List<BrandSubjectItemsResponse>>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/brand_subjectitems";
    }
}
