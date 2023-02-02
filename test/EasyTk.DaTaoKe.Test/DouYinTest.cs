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
            var req = new OrderListRequest
            {
                OrderType = "1"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestGaoYongJingXuanAsync()
        {
            var req = new SxGoodsListRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestSearchAsync()
        {
            var req = new MaterialsProductsSearchRequest
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
            var req = new SxGoodsRankRequest
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

        [Fact]
        public async Task TestLiveShareMaterialRequestAsync()
        {
            var req = new LiveShareMaterialRequest
            {

            };

            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestKolProductShareRequestAsync()
        {
            var req = new KolProductShareRequest
            {
                ProductUrl = "https://haohuo.jinritemai.com/ecommerce/trade/detail/index.html?id=3566191198479755673&origin_type=open_platform&pick_source=Bjp3aEw",
                ExternalInfo = "000002a",
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestRankRequestAsync()
        {
            var req = new RankRequest
            {
                Cid = 100,
                ListType = "24h"
            };

            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestInstituteLiveShareRequestAsync()
        {
            var req = new InstituteLiveShareRequest
            {
                BuyinId = "6961635340667240734",
                ExternalInfo = "000001A",
                NeedQrCode = 1,
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestDistributionLiveProductListRequestAsync()
        {
            var req = new DistributionLiveProductListRequest
            {
                AuthorBuyinId = "6961635340667240734",
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestOneYuanGoodsListRequestAsync()
        {
            var req = new OneYuanGoodsListRequest
            {

            };

            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestOneFenGoodsListRequestAsync()
        {
            var req = new OneFenGoodsListRequest
            {

            };

            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
