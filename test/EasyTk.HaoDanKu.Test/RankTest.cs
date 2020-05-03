using EasyTk.HaoDanKu.Request;
using Xunit;

namespace EasyTk.HaoDanKu.Test
{
    public class RankTest : BaseTest
    {
        [Fact]
        public async void TestSalesListRequest()
        {
            var req = new SalesListRequest
            {
                SaleType = 1
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestTaLenTInfoRequest()
        {
            var req = new TaLenTInfoRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestTaLenTArticleRequest()
        {
            var req = new TaLenTArticleRequest
            {
                Id = 10425L
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestManArticlesRequest()
        {
            // 10041,10290,10246,10166,10056,10291,10182,9970,10184,10395,10006,10317,10100,10122,10167,10083,10365,10261,10187,
            // 10228,10201,9984,10040,10186,10229,10364,10007,10023,10141,10070,10411,10410,10331,10304,10121,10348,10022,10275,
            // 10276,10244,10385,10386,10349,10213,10260,10425
            var req = new ManArticlesRequest
            {
                Id = 10386L
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestSelectedItemRequest()
        {
            var req = new SelectedItemRequest()
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestFastBuyRequest()
        {
            var req = new FastBuyRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestSubjectHotRequest()
        {
            var req = new SubjectHotRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestColumnRequest()
        {
            var req = new ColumnRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetKeywordItemsRequest()
        {
            var req = new GetKeywordItemsRequest
            {
                Keyword = "女装"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestHotKeyRequest()
        {
            var req = new HotKeyRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestBlackListRequest()
        {
            var req = new BlackListRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestCheckSellerNickRequest()
        {
            var req = new CheckSellerNickRequest
            {
                SellerNick = "tb550496606"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestSuperClassifyRequest()
        {
            var req = new SuperClassifyRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetSubjectRequest()
        {
            var req = new GetSubjectRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetSubjectItemRequest()
        {
            var req = new GetSubjectItemRequest
            {
                Id = 10378
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestItemDetailRequest()
        {
            // "itemid":"25130740288"
            // "product_id":"16963159"
            var req = new ItemDetailRequest
            {
                ItemId = "25130740288",
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestExcellentEditorRequest()
        {
            var req = new ExcellentEditorRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetDeserveItemRequest()
        {
            var req = new GetDeserveItemRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestSuperSearchRequest()
        {
            var req = new SuperSearchRequest
            {
                Keyword = "蚕宝宝"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
