using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.ZheTaoKe.Request;
using Xunit;

namespace EasyTk.ZheTaoKe.Test
{
    public class GoodParseTest : BaseTest
    {
        [Fact]
        public async void TestShangPinIdRequest()
        {
            var req = new ShangPinIdRequest
            {
                Content = Tkl,
                Type = 1,
                Hjs = 1,
                Tlj = 1,
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestTaoKouLingJieXiRequest()
        {
            var req = new TaoKouLingJieXiRequest()
            {
                Content = Tkl,
                Type = 1,
                Hjs = 1,
                Tlj = 1,
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetLocationRequest()
        {
            var req = new GetLocationRequest()
            {
                Content = Tkl,
                Type = 1,
                Hjs = 1,
                Tlj = 1,
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
