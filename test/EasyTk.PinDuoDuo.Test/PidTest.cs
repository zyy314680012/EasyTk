using System;
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
    }
}
