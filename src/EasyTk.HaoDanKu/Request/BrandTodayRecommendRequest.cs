using EasyTk.HaoDanKu.Response;

namespace EasyTk.HaoDanKu.Request
{
    /// <summary>
    /// 今日推荐品牌API
    /// </summary>
    public class BrandTodayRecommendRequest : BaseRequest<WrapperResponse<BrandTodayRecommendResponse>>
    {
        public override string GetApiUrl() => "http://v2.api.haodanku.com/brand_todayrecommend";
    }
}
