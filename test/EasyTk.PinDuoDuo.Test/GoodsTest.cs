using EasyTk.PinDuoDuo.Request;
using System.Threading.Tasks;
using Xunit;

namespace EasyTk.PinDuoDuo.Test
{
    public class GoodsTest : BaseTest
    {
        private readonly long _mallId = 425129557L;

        private readonly long _goodsId = 6013064611L;

        private readonly string _couponId = "A0045VC-530298869942224396";

        private readonly long _themeId = 7607L;

        [Fact]
        public async void TestPddDdkCouponInfoQueryRequest()
        {
            var req = new PddDdkCouponInfoQueryRequest
            {
                CouponIds = new[] { _couponId }
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsSearchRequest()
        {
            var cp = GetPidCustomParameters();
            cp.Add("event", "12345");
            var req = new PddDdkGoodsSearchRequest
            {
                Keyword = "女装",
                Pid = Pid,
                CustomParameters = ToJson(cp)
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsBasicInfoGetRequest()
        {
            var req = new PddDdkGoodsBasicInfoGetRequest
            {
                GoodsIdList = new[] { _goodsId }
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsDetailRequest()
        {
            var req = new PddDdkGoodsDetailRequest
            {
                GoodsIdList = new[] { _goodsId }
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsPromotionUrlGenerateRequest()
        {
            var req = new PddDdkGoodsPromotionUrlGenerateRequest
            {
                GoodsIdList = new[] { _goodsId },
                PId = Pid
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsRecommendGetRequest()
        {
            var req = new PddDdkGoodsRecommendGetRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsUnitQueryRequest()
        {
            var req = new PddDdkGoodsUnitQueryRequest
            {
                GoodsId = _goodsId
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkGoodsZsUnitUrlGenRequest()
        {
            var req = new PddDdkGoodsZsUnitUrlGenRequest
            {
                SourceUrl =
                    "https://mobile.yangkeduo.com/app.html?use_reload=1&launch_url=duo_coupon_landing.html%3Fgoods_id%3D6013064611%26pid%3D8804138_132609385%26cpsSign%3DCC_200503_8804138_132609385_951cea37fe23dd5cbd8b9d6f716beb0f%26duoduo_type%3D2&campaign=ddjb&cid=launch_dl_force_",
                Pid = Pid
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkMallGoodsListGetRequest()
        {
            var req = new PddDdkMallGoodsListGetRequest
            {
                MallId = _mallId,
                PageNumber = 1,
                PageSize = 20
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkMallUrlGenRequest()
        {
            var req = new PddDdkMallUrlGenRequest
            {
                MallId = _mallId,
               // Pid = Pid
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkMerchantListGetRequest()
        {
            var req = new PddDdkMerchantListGetRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkOrderListIncrementGetRequest()
        {
            var req = new PddDdkOrderListIncrementGetRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkResourceUrlGenRequest()
        {
            var req = new PddDdkResourceUrlGenRequest
            {
                Pid = Pid
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkRpPromUrlGenerateRequest()
        {
            var req = new PddDdkRpPromUrlGenerateRequest
            {
                PIdList = new[] { Pid }
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkThemeListGetRequest()
        {
            var req = new PddDdkThemeListGetRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkThemeGoodsSearchRequest()
        {
            var req = new PddDdkThemeGoodsSearchRequest
            {
                ThemeId = _themeId
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkThemePromUrlGenerateRequest()
        {
            var req = new PddDdkThemePromUrlGenerateRequest
            {
                ThemeIdList = new[] { _themeId },
                Pid = Pid
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async Task TestPddDdkTopGoodsListQueryRequest()
        {
            var req = new PddDdkTopGoodsListQueryRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestPddDdkWeAppQrCodeUrlGenRequest()
        {
            var req = new PddDdkWeAppQrCodeUrlGenRequest
            {
                GoodsIdList = new[] { _goodsId },
                PId = Pid
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
