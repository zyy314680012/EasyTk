using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.DaTaoKe.Request;
using Xunit;

namespace EasyTk.DaTaoKe.Test
{
    public class SearchTest : BaseTest
    {
        [Fact]
        public async void TestSearchSuggestionRequest()
        {
            var req = new SearchSuggestionRequest
            {
                KeyWords = "女装",
                Type = 1
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestListSuperGoodsRequest()
        {
            var req = new ListSuperGoodsRequest
            {
                KeyWords = "女装",
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetDtkSearchGoodsRequest()
        {
            var req = new GetDtkSearchGoodsRequest
            {
                KeyWords = "女装"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetTop100Request()
        {
            var req = new GetTop100Request { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetTbServiceRequest()
        {
            var req = new GetTbServiceRequest
            {
                KeyWords = "女装"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
