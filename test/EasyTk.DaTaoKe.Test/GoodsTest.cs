using EasyTk.DaTaoKe.Request;
using Xunit;

namespace EasyTk.DaTaoKe.Test
{
    public class GoodsTest : BaseTest
    {
        [Fact]
        public async void TestGoodsGetGoodsListRequest()
        {
            var req = new GetGoodsListRequest { };
            var resp = await Client.ExecuteAsync(req);

            var q = resp;
        }

        [Fact]
        public async void TestGetGoodsDetailsRequest()
        {
            var req = new GetGoodsDetailsRequest
            {
                Id = 26001509
            };
            var resp = await Client.ExecuteAsync(req);

            var q = resp;
        }

        [Fact]
        public async void TestPullGoodsByTimeRequest()
        {
            var req = new PullGoodsByTimeRequest()
            {
            };
            var resp = await Client.ExecuteAsync(req);

            var q = resp;
        }

        [Fact]
        public async void TestGetStaleGoodsByTimeRequest()
        {
            var req = new GetStaleGoodsByTimeRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetNewestGoodsRequest()
        {
            var req = new GetNewestGoodsRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
