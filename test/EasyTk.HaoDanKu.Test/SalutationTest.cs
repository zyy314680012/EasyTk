using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.HaoDanKu.Request;
using Xunit;

namespace EasyTk.HaoDanKu.Test
{
    public class SalutationTest : BaseTest
    {
        [Fact]
        public async void TestGetSalutationDataRequest()
        {
            var req = new GetSalutationDataRequest
            {
                Back = 10
            };

            var resp = await Client.ExecuteAsync(req);

            var gg = resp;
        }
    }
}
