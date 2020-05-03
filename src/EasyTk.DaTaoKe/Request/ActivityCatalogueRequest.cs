using EasyTk.DaTaoKe.Response;
using System.Collections.Generic;

namespace EasyTk.DaTaoKe.Request
{
    public class ActivityCatalogueRequest : BaseRequest<WrapperResponse<List<ActivityCatalogueResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/activity/catalogue";

        public override string Version => "v1.1.0";
    }
}
