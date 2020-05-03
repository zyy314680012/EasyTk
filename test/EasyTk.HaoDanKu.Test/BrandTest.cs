using EasyTk.HaoDanKu.Request;
using Xunit;

namespace EasyTk.HaoDanKu.Test
{
    public class BrandTest : BaseTest
    {
        [Fact]
        public async void TestBrandRequest()
        {
            var req = new BrandRequest { };
            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestBrandInfoRequest()
        {
            var req = new BrandInfoRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestSingleBrandRequest()
        {
            var req = new SingleBrandRequest
            {
                Id = 1
            };
            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestBrandTodayRecommendRequest()
        {
            var req = new BrandTodayRecommendRequest { };
            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }

        [Fact]
        public async void TestBrandSubjectItemsRequest()
        {
            var req = new BrandSubjectItemsRequest { };
            var resp = await Client.ExecuteAsync(req);
            var g = resp;
        }
    }
}
