using EasyTk.PinDuoDuo.Request;
using Xunit;

namespace EasyTk.PinDuoDuo.Test
{
    public class CmsTest : BaseTest
    {
        [Fact]
        public async void TestPddDdkCmsPromUrlGenerateRequest()
        {
            var req = new PddDdkCmsPromUrlGenerateRequest
            {
                PIdList = new[] { Pid },
                GenerateMobile = true
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkLotteryUrlGenRequest()
        {
            var req = new PddDdkLotteryUrlGenRequest
            {
                PidList = new[] { Pid }
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
