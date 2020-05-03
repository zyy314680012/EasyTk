using EasyTk.HaoDanKu.Request;
using Xunit;

namespace EasyTk.HaoDanKu.Test
{
    public class GoodsTest : BaseTest
    {
        [Fact]
        public async void TestItemListRequest()
        {
            var req = new ItemListRequest
            {
                Nav = "1",
                Back = 100,
                MinId = 1,
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestTimingItemsRequest()
        {
            var req = new TimingItemsRequest
            {
                Start = 11,
                End = 14,
                Back = 100,
                MinId = 1,
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestUpdateItemRequest()
        {
            var req = new UpdateItemRequest()
            {
                Back = 100,
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestGetHighItemsRequest()
        {
            var req = new GetHighItemsRequest()
            {
                Back = 100,
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestGetActivityDataRequest()
        {
            var req = new GetActivityDataRequest()
            {
                Back = 100,
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestLowPricePinkAgeDataRequest()
        {
            var req = new LowPricePinkAgeDataRequest()
            {
                Back = 100,
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestDouYinItemsRequest()
        {
            var req = new DouYinItemsRequest()
            {
                ItemId = 596668952682,
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestGetFreeShippingDataRequest()
        {
            var req = new GetFreeShippingDataRequest()
            {
            };

            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestGetTrillDataRequest()
        {
            var req = new GetTrillDataRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestGetSimilarInfoRequest()
        {
            var req = new GetSimilarInfoRequest
            {
                ItemId = "596668952682"
            };
            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }
    }
}
