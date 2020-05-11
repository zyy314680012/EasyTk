namespace EasyTk.ZheTaoKe.Request
{
    public class ApiShiShiRequest : ApiXiaoShiRequest
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/api_shishi.ashx"
        };
    }
}
