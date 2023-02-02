using EasyTk.DaTaoKe.Request.DouYin;
using System.Threading.Tasks;
using Xunit;

namespace EasyTk.DaTaoKe.Test
{
    public class DouYinTest : BaseTest
    {
        [Fact]
        public async Task TestOrderAsync()
        {
            var req = new GetOrderRequest
            {
                OrderType = "1"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestGaoYongJingXuanAsync()
        {
            var req = new GetGaoYongJingXuanRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestSearchAsync()
        {
            var req = new SearchRequest
            {
                SearchType = 0,
                SortType = 1,
                Page = 1,
                PageSize = 10,
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestGetGaoYongJingXuanRankRequestAsync()
        {
            var req = new GetGaoYongJingXuanRankRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestMaterialsProductsDetailRequestAsync()
        {
            var req = new MaterialsProductsDetailRequest
            {
                ProductIds = "3566191198479755673"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
