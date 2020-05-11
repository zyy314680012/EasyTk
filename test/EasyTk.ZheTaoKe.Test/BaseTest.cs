using EasyTk.Core;

namespace EasyTk.ZheTaoKe.Test
{
    public class BaseTest
    {
        protected IClient Client;

        public const string Pid = "mm_15437535_1655550009_110371550195";

        public const long ItemId = 610638877760L;

        public const string Tkl = "￥kg1H1omzton￥";//"￥nph21oNs488￥";

        public const long ShopId = 2206967713953L;

        public BaseTest()
        {
            Client = new ZheTaoKeClient("32c117bcdf47426dbabd85d0f8741571", "19930");
        }
    }
}
