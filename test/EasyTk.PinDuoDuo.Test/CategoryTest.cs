using EasyTk.PinDuoDuo.Request;
using System.Threading.Tasks;
using Xunit;

namespace EasyTk.PinDuoDuo.Test
{
    public class CategoryTest : BaseTest
    {
        [Fact]
        public async Task TestCategory()
        {
            var req = new PddGoodsCatsGetRequest
            {
                ParentCatId = 0
            };
            var resp = await Client.ExecuteAsync(req);
            var bb = resp;
        }

        [Fact]
        public async Task TestOpt()
        {
            var req = new PddGoodsOptGetRequest
            {
                ParentOptId = 0L
            };
            var resp = await Client.ExecuteAsync(req);
            var bb = resp;
        }
    }
}
