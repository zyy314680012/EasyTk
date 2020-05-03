using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.DaTaoKe.Request;
using Xunit;

namespace EasyTk.DaTaoKe.Test
{
    public class BasicTest : BaseTest
    {
        [Fact]
        public async void TestGetPrivilegeLinkRequest()
        {
            var req = new GetPrivilegeLinkRequest
            {
                GoodsId = "601930909460",
                Pid = "mm_15437535_613650266_109159500341"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetSuperCategoryRequest()
        {
            var req = new GetSuperCategoryRequest { };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestGetCollectionListRequest()
        {
            var req = new GetCollectionListRequest
            {
                Cid = "1,2,3,4,5,6,7,8,9,10,11,12,13,14"
            };
            var resp = await Client.ExecuteAsync(req);

            var q = resp;
        }

        [Fact]
        public async void TestGetOwnerGoodsRequest()
        {
            var req = new GetOwnerGoodsRequest
            {

            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }
    }
}
