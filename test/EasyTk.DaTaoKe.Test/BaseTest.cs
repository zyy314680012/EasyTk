using EasyTk.Core;
using EasyTk.DaTaoKe.Request;
using Xunit;

namespace EasyTk.DaTaoKe.Test
{
    public class BaseTest
    {
        protected IClient Client;

        public BaseTest()
        {
            Client = new DaTaoKeClient("5d8dc581e4b72", "dd5c2e8b1c0aed00e9600a484eff2eec", "mm_15437535_613650266_109159500341");
        }
    }
}
