using EasyTk.ZheTaoKe.Request;
using Xunit;

namespace EasyTk.ZheTaoKe.Test
{
    public class GaoYongZhuanLianTest : BaseTest
    {
        [Fact]
        public async void TestGaoYongZhuanLianTbkPrivilegeGetResponseRequest()
        {
            foreach (var signUrl in new[] { 0, 3, 4 })
            {
                var req = new GaoYongZhuanLianTbkPrivilegeGetResponseRequest
                {
                    Pid = Pid,
                    NumIid = ItemId.ToString(),
                    SignUrl = signUrl
                };
                var resp = await Client.ExecuteAsync(req);
                var q = resp;
            }
        }

        [Fact]
        public async void TestGaoYongZhuanLianOnlyUrlRequest()
        {
            foreach (var signUrl in new[] { 1, 2 })
            {
                var req = new GaoYongZhuanLianOnlyUrlRequest()
                {
                    Pid = Pid,
                    NumIid = ItemId.ToString(),
                    SignUrl = signUrl
                };
                var resp = await Client.ExecuteAsync(req);
                var q = resp;
            }
        }

        [Fact]
        public async void TestGaoYongZhuanLianFullInfoRequest()
        {
            foreach (var signUrl in new[] { 5 })
            {
                var req = new GaoYongZhuanLianFullInfoRequest()
                {
                    Pid = Pid,
                    NumIid = ItemId.ToString(),
                    SignUrl = signUrl
                };
                var resp = await Client.ExecuteAsync(req);
                var q = resp;
            }
        }

        [Fact]
        public async void TestGaoYongZhuanLianTklTbkPrivilegeGetResponseRequest()
        {
            foreach (var signUrl in new[] { 0, 3, 4 })
            {
                var req = new GaoYongZhuanLianTklTbkPrivilegeGetResponseRequest
                {
                    Pid = Pid,
                    Tkl = Tkl,
                    SignUrl = signUrl
                };
                var resp = await Client.ExecuteAsync(req);
                var q = resp;
            }
        }

        [Fact]
        public async void TestGaoYongZhuanLianTklOnlyUrlRequest()
        {
            foreach (var signUrl in new[] { 1, 2 })
            {
                var req = new GaoYongZhuanLianTklOnlyUrlRequest()
                {
                    Pid = Pid,
                    Tkl = Tkl,
                    SignUrl = signUrl
                };
                var resp = await Client.ExecuteAsync(req);
                var q = resp;
            }
        }

        [Fact]
        public async void TestGaoYongZhuanLianTklFullInfoRequest()
        {
            foreach (var signUrl in new[] { 5 })
            {
                var req = new GaoYongZhuanLianTklFullInfoRequest()
                {
                    Pid = Pid,
                    Tkl = Tkl,
                    SignUrl = signUrl
                };
                var resp = await Client.ExecuteAsync(req);
                var q = resp;
            }
        }
    }
}
