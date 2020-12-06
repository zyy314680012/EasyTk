using System;
using System.Threading.Tasks;
using EasyTk.PinDuoDuo.Request;
using Xunit;

namespace EasyTk.PinDuoDuo.Test
{
    public class PidTest : BaseTest
    {
        [Fact]
        public async void TestPddDdkGoodsPidQueryRequest()
        {
            var req = new PddDdkGoodsPidQueryRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsPidGenerateRequest()
        {
            var req = new PddDdkGoodsPidGenerateRequest
            {
                Number = 2,
                PIdNameList = new[] { "TEST-001", "TEST-002" }
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkFinanceCpaQueryRequest()
        {
            var req = new PddDdkFinanceCpaQueryRequest
            {
                //DateQuery = DateTime.Today.ToString("yyyy-MM-dd")
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;

        }

        [Fact]
        public async Task TestPddDdkMemberAuthorityQueryRequest()
        {
            var cp = GetPidCustomParameters();
            cp.Add("ac", "1234");
            var req = new PddDdkMemberAuthorityQueryRequest()
            {
                Pid = Pid,
                CustomParameters = ToJson(cp)
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestPddDdkRpPromUrlGenerateRequest()
        {
            var cp = GetPidCustomParameters();
            var req = new PddDdkRpPromUrlGenerateRequest()
            {
                ChannelType = 10,
                PIdList = new[] { Pid },
                CustomParameters = ToJson(cp)
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
