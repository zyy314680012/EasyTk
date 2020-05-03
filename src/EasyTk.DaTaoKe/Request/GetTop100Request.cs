using EasyTk.DaTaoKe.Response;

namespace EasyTk.DaTaoKe.Request
{
    public class GetTop100Request:BaseRequest<WrapperResponse<GetTop100Response>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/category/get-top100";

        public override string Version => "v1.0.1";
    }
}
