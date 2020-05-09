using EasyTk.ZheTaoKe.Response;

namespace EasyTk.ZheTaoKe.Request
{
    /// <summary>
    /// 解析商品编号API（返回商品ID和券ID）：支持淘口令文案、长链接、二合一链接、短链接、喵口令、新浪短链，可直接返回特殊优惠券
    /// </summary>
    public class ShangPinIdRequest : ShangPinParseRequest<ShangPinIdResponse>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_shangpin_id.ashx"
        };
    }
}
