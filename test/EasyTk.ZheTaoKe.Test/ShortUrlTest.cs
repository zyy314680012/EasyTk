using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.ZheTaoKe.Request;
using Xunit;

namespace EasyTk.ZheTaoKe.Test
{
    public class ShortUrlTest : BaseTest
    {
        [Fact]
        public async void TestShortUrlTaoBao()
        {
            var req = new ShortUrlTaoBaoGetRequest
            {
                Content = "https://uland.taobao.com/coupon/edetail?e=A%2FsNHYPra74NfLV8niU3RxsUty%2FyJZUCIUcOemCte8jHoQe1tkK55bZB4GXhba7vfOv4wAGDipT50%2BplWpi10yfugWAY09%2Bd8busCbgR2UviCV54hS%2F32l%2Bl9Ohq8v%2FGBWQkv8LoqTqNa6AYd60W0%2Fw9EZd7p2%2Bgvz2UrrypuQ5%2Bz3EQ2rL%2FEWOsJDOE0cZGwdTDcYflJn5lBRYM90QVRw%3D%3D&app_pvid=59590_11.88.140.105_530_1589009386459&ptl=floorId%3A17741&app_pvid%3A59590_11.88.140.105_530_1589009386459&tpp_pvid%3A&union_lens=lensId%3APUB%401589009358%4002fb0630-0900-4ff7-a7cb-bb4c298c2b99_615489840834%4002nBNCL5CpfzWQP4CNToVoR"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestShortUrlSina()
        {
            var req = new ShortUrlSinaGetRequest
            {
                Type = 1,
                Content = "https://uland.taobao.com/coupon/edetail?e=A%2FsNHYPra74NfLV8niU3RxsUty%2FyJZUCIUcOemCte8jHoQe1tkK55bZB4GXhba7vfOv4wAGDipT50%2BplWpi10yfugWAY09%2Bd8busCbgR2UviCV54hS%2F32l%2Bl9Ohq8v%2FGBWQkv8LoqTqNa6AYd60W0%2Fw9EZd7p2%2Bgvz2UrrypuQ5%2Bz3EQ2rL%2FEWOsJDOE0cZGwdTDcYflJn5lBRYM90QVRw%3D%3D&app_pvid=59590_11.88.140.105_530_1589009386459&ptl=floorId%3A17741&app_pvid%3A59590_11.88.140.105_530_1589009386459&tpp_pvid%3A&union_lens=lensId%3APUB%401589009358%4002fb0630-0900-4ff7-a7cb-bb4c298c2b99_615489840834%4002nBNCL5CpfzWQP4CNToVoR"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestShortUrlBaidu()
        {
            var req = new ShortUrlBaiduGetRequest
            {
                Content = "https://uland.taobao.com/coupon/edetail?e=A%2FsNHYPra74NfLV8niU3RxsUty%2FyJZUCIUcOemCte8jHoQe1tkK55bZB4GXhba7vfOv4wAGDipT50%2BplWpi10yfugWAY09%2Bd8busCbgR2UviCV54hS%2F32l%2Bl9Ohq8v%2FGBWQkv8LoqTqNa6AYd60W0%2Fw9EZd7p2%2Bgvz2UrrypuQ5%2Bz3EQ2rL%2FEWOsJDOE0cZGwdTDcYflJn5lBRYM90QVRw%3D%3D&app_pvid=59590_11.88.140.105_530_1589009386459&ptl=floorId%3A17741&app_pvid%3A59590_11.88.140.105_530_1589009386459&tpp_pvid%3A&union_lens=lensId%3APUB%401589009358%4002fb0630-0900-4ff7-a7cb-bb4c298c2b99_615489840834%4002nBNCL5CpfzWQP4CNToVoR"
            };
            var resp = await Client.ExecuteAsync(req);
            var q = resp;
        }

        [Fact]
        public async void TestTklCreateRequest()
        {
            var req = new TklCreateRequest
            {
                Url = "https://uland.taobao.com/coupon/edetail?e=A%2FsNHYPra74NfLV8niU3RxsUty%2FyJZUCIUcOemCte8jHoQe1tkK55bZB4GXhba7vfOv4wAGDipT50%2BplWpi10yfugWAY09%2Bd8busCbgR2UviCV54hS%2F32l%2Bl9Ohq8v%2FGBWQkv8LoqTqNa6AYd60W0%2Fw9EZd7p2%2Bgvz2UrrypuQ5%2Bz3EQ2rL%2FEWOsJDOE0cZGwdTDcYflJn5lBRYM90QVRw%3D%3D&app_pvid=59590_11.88.140.105_530_1589009386459&ptl=floorId%3A17741&app_pvid%3A59590_11.88.140.105_530_1589009386459&tpp_pvid%3A&union_lens=lensId%3APUB%401589009358%4002fb0630-0900-4ff7-a7cb-bb4c298c2b99_615489840834%4002nBNCL5CpfzWQP4CNToVoR",
                SignUrl = 0,
            };
            var resp = await Client.ExecuteAsync(req);

            var resp2 = await resp.GetTklCreateResponse();

            var q = resp2;
        }
    }
}
