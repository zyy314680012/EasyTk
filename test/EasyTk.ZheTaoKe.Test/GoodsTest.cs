﻿using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.ZheTaoKe.Request;
using Xunit;

namespace EasyTk.ZheTaoKe.Test
{
    public class GoodsTest : BaseTest
    {
        [Fact]
        public async void TestItemInfoRequest()
        {
            var req = new ItemInfoRequest
            {
                NumIids = $"{ItemId}"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiAllRequest()
        {
            var req = new ApiAllRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiDetailRequest()
        {
            var req = new ApiDetailRequest
            {
                NumIids = "616632349304,583030512831,583030512831"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestQuanWangRequest()
        {
            var req = new QuanWangRequest
            {
                Q = "女装"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiVideosRequest()
        {
            var req = new ApiVideosRequest
            {
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestOpenQrPicRequest()
        {
            var req = new OpenQrPicRequest
            {
                Content = "￥UdQy1LUv85B￥"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiXiaoShiRequest()
        {
            var req = new ApiXiaoShiRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiQuanTianRequest()
        {
            var req = new ApiQuanTianRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiShiShiRequest()
        {
            var req = new ApiShiShiRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiYongJinRequest()
        {
            var req = new ApiYongJinRequest();
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiDongDongRequest()
        {
            var req = new ApiDongDongRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiShiXiaoRequest()
        {
            var req = new ApiShiXiaoRequest();
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiGuanJianCiRequest()
        {
            var req = new ApiGuanJianCiRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiSuggestRequest()
        {
            var req = new ApiSuggestRequest
            {
                Content = "女"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiLunBoRequest()
        {
            var req = new ApiLunBoRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestApiLiWuZhuanTiRequest()
        {
            var req = new ApiLiWuZhuanTiRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
