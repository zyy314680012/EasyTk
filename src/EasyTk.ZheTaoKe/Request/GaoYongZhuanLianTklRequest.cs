using System;
using System.Collections.Generic;
using System.Linq;
using EasyTk.Core;
using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public abstract class GaoYongZhuanLianTklRequest<TResponse> : BaseRequest<TResponse> where TResponse : IResponse
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_gaoyongzhuanlian_tkl.ashx",
            "http://api.zhetaoke.cn:10000/api/open_gaoyongzhuanlian_tkl.ashx"
        };

        #region =============================

        ///<summary> 
        ///pid string	是	淘客PID，mm_xxx_xxx_xxx,三段格式，必须与授权的账户相同，否则出错
        ///</summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        ///<summary> 
        ///tkl string	是	淘口令文案或者二合一链接或者长链接或者短链接或者喵口令。请注意，该参数需要进行Urlencode编码后传入。
        ///         淘口令文案：复制这条信息，￥ysuUbqEiTSt￥，打开【手机淘宝】即可。
        ///         二合一链接：以https://uland.taobao.com/coupon/edetail?e=开头的链接
        ///         长链接：以https://s.click.taobao.com/t?e=开头的链接
        ///         短链接：类似https://s.click.taobao.com/R7rDLHw的链接
        ///         喵口令：类似http://***.com/s/3X51L?tm=cd5add的链接
        ///         重要的事情说三遍：该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！该参数需要进行Urlencode编码！
        ///</summary>
        [JsonProperty("tkl")]
        public string Tkl { get; set; }


        ///<summary> 
        ///relation_id string	否	渠道关系ID，仅适用于渠道推广场景。
        ///</summary>
        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        ///<summary> 
        ///signurl int	否	
        ///         signurl=5，返回结果整合高拥转链API、解析商品编号API、全网商品详情API、淘口令创建API，已经自动判断和拼接使用全网G券还是全网S券。
        ///         signurl=4，返回结果整合高拥转链API、解析商品编号API、商品简版详情API、淘口令创建API，已经自动判断和拼接使用全网G券还是全网S券。
        ///         signurl=3，返回结果整合高拥转链API、解析商品编号API，已经自动判断和拼接使用全网G券还是全网S券。
        ///         signurl=0或1或2，返回官方高拥转链接口结果，需要自行判断和拼接使用全网G券或者全网S券。
        ///         signurl=0，表示直接返回最终结果。
        ///         signurl=1或2，表示返回淘宝联盟请求地址，大家拿到地址后再用自己的服务器二次请求即可获得最终结果，值为1返回http链接，值为2返回https安全链接。
        ///</summary>
        [JsonProperty("signurl")]
        public int SignUrl
        {
            get => _signUrl;
            set
            {
                if (AllowValues.Contains(value))
                {
                    _signUrl = value;
                }
                else
                {
                    foreach (var key in _signUrlClass.Keys)
                    {
                        if (key == value)
                        {
                            throw new ArgumentException($"类型错误，请使用 {_signUrlClass[key]}");
                        }
                    }
                    throw new ArgumentException($"类型错误，可用值 {string.Join(",", AllowValues)}");
                }
            }
        }

        private int _signUrl;

        #endregion


        private readonly Dictionary<int, string> _signUrlClass = new Dictionary<int, string>()
        {
            {0, nameof(GaoYongZhuanLianTklTbkPrivilegeGetResponseRequest)},
            {1, nameof(GaoYongZhuanLianTklOnlyUrlRequest)},
            {2, nameof(GaoYongZhuanLianTklOnlyUrlRequest)},
            {3, nameof(GaoYongZhuanLianTklTbkPrivilegeGetResponseRequest)},
            {4, nameof(GaoYongZhuanLianTklTbkPrivilegeGetResponseRequest)},
            {5, nameof(GaoYongZhuanLianTklFullInfoRequest)},
        };

        protected abstract int[] AllowValues { get; }
    }

    public class GaoYongZhuanLianTklTbkPrivilegeGetResponseRequest : GaoYongZhuanLianTklRequest<GaoYongZhuanLianTklTbkPrivilegeGetResponse>
    {
        protected override int[] AllowValues => new[] { 0, 3, 4 };
    }

    public class GaoYongZhuanLianTklOnlyUrlRequest : GaoYongZhuanLianTklRequest<GaoYongZhuanLianTklOnlyUrlResponse>
    {
        protected override int[] AllowValues => new[] { 1, 2 };
    }

    public class GaoYongZhuanLianTklFullInfoRequest : GaoYongZhuanLianTklRequest<GaoYongZhuanLianTklFullInfoResponse>
    {
        protected override int[] AllowValues => new[] { 5 };
    }
}
