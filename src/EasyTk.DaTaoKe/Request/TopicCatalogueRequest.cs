using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.DaTaoKe.Response;

namespace EasyTk.DaTaoKe.Request
{
    public class TopicCatalogueRequest : BaseRequest<WrapperResponse<List<TopicCatalogueResponse>>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/goods/topic/catalogue";

        public override string Version => "v1.1.0";

    }
}
