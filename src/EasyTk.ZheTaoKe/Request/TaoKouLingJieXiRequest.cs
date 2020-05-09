using EasyTk.ZheTaoKe.Response;

namespace EasyTk.ZheTaoKe.Request
{
    /// <summary>
    /// 解析淘口令API（返回推广url）：支持淘口令文案，返回推广url链接
    /// </summary>
    public class TaoKouLingJieXiRequest : ShangPinParseRequest<TaoKouLingJieXiResponse>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_taokouling_jiexi.ashx"
        };
    }
}