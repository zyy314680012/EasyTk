using EasyTk.PinDuoDuo.Request;
using Xunit;

namespace EasyTk.PinDuoDuo.Test
{
    public class GoodsTest : BaseTest
    {
        private readonly long _goodsId = 6013064611L;

        private readonly string _couponId = "A0045VC-530298869942224396";

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
            var req = new PddDdkGoodsSearchRequest
            {
                Keyword = "女装"
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
    }
}
