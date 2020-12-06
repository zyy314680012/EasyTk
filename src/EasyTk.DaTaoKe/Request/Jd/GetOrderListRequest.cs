using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.Jd;

namespace EasyTk.DaTaoKe.Request.Jd
{
    public class GetOrderListRequest : BaseRequest<WrapperResponse<GetOrderListResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/dels/jd/order/outer/get-order-list";

        public override string Version => "v1.0.0";
    }
}
