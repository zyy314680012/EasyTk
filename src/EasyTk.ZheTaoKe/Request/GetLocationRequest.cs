using EasyTk.ZheTaoKe.Response;

namespace EasyTk.ZheTaoKe.Request
{
    public class GetLocationRequest : ShangPinParseRequest<GetLocationResponse>
    {
        /// <summary>
        /// 获取跳转URL地址API：支持淘口令文案、淘宝长链接、淘宝短链接等各种跳转URL地址，返回原始推广url链接
        /// </summary>
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_get_location.ashx"
        };
    }
}