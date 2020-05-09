using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.ZheTaoKe.Request;
using Xunit;

namespace EasyTk.ZheTaoKe.Test
{
    public class DingDanTest : BaseTest
    {
        [Fact]
        public async void TestDingDanChaXun2Request()
        {
            var req = new DingDanChaXun2Request
            {
                StartTime = DateTime.Now.AddHours(-2).ToString("yyyy-MM-dd HH:mm:ss"),
                EndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),

            };
            var resp = await Client.ExecuteAsync(req);
            var real = await resp.GetAlimamaData();
            var q = real;
        }
    }
}
