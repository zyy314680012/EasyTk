using EasyTk.Core;
using EasyTk.Core.Extensions;
using EasyTk.HaoDanKu.Request;
using Xunit;

namespace EasyTk.HaoDanKu.Test
{
    public class BaseTest
    {
        protected IClient Client;
        public BaseTest()
        {
            Client = new HaoDanKuClient("mbdhinocealfgjk");
        }

        [Fact]
        public void TestGetProperties()
        {
            var req = new ItemListRequest
            {
                ApiKey = "xxxxxxxxxxxxxx"
            };

            var dic = req.GetParametersNameAndValue();
        }
    }
}
