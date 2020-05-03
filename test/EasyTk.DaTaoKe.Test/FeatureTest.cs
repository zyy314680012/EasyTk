using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using EasyTk.DaTaoKe.Request;
using Xunit;

namespace EasyTk.DaTaoKe.Test
{
    public class FeatureTest : BaseTest
    {
        [Fact]
        public async void TestGetTbTopicListRequest()
        {
            var req = new GetTbTopicListRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestDdqGoodsListRequest()
        {
            //171
            var req = new DdqGoodsListRequest { };
            var resp = await Client.ExecuteAsync(req);
            var aq = resp;
        }

        [Fact]
        public async void TestGetRankingListRequest()
        {
            //var req = new GetRankingListRequestNormal { RankType = 1 };
            //var req = new GetRankingListRequestHotWorldRise { };
            var req = new GetRankingListRequestHotWorld { };


            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestTopicCatalogueRequest()
        {
            var req = new TopicCatalogueRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        //1433
        [Fact]
        public async void TestTopicGoodsListRequest()
        {
            var req = new TopicGoodsListRequest
            {
                TopicId = 1433L
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestNineOpGoodsListRequest()
        {
            var req = new NineOpGoodsListRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetBrandListRequest()
        {
            var req = new GetBrandListRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestListSimilerGoodsByOpenRequest()
        {
            var req = new ListSimilerGoodsByOpenRequest
            {
                Id = 25965621
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestActivityCatalogueRequest()
        {
            var req = new ActivityCatalogueRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestActivityGoodsListRequest()
        {
            var req = new ActivityGoodsListRequest
            {
                ActivityId = 26L
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
