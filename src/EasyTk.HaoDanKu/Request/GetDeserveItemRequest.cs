using EasyTk.HaoDanKu.Response;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 今日值得买API
    /// </summary>
    public class GetDeserveItemRequest : BaseRequest<GetDeserveItemResponse>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/get_deserve_item";
    }
}
