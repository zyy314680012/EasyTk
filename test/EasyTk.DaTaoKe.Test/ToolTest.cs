using EasyTk.DaTaoKe.Request.Jd;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EasyTk.DaTaoKe.Test
{
    public class ToolTest : BaseTest
    {
        [Fact]
        public async void TestPromotionUnionConvertRequest()
        {
            var req = new PromotionUnionConvertRequest
            {
                MaterialId = "https://item.jd.com/10021804183200.html",
                Code = "henry123"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
