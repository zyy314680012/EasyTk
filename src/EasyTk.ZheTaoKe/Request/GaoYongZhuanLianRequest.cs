using EasyTk.Core;
using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyTk.ZheTaoKe.Request
{
    public abstract class GaoYongZhuanLianRequest<TResponse> : BaseRequest<TResponse> where TResponse : IResponse
    {
        ///<summary> 
        ///pid string	是	淘客PID，mm_xxx_xxx_xxx,三段格式，必须与授权的账户相同，否则出错
        ///</summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        ///<summary> 
        ///num_iid string	否	商品ID,商品ID或me必须填一个
        ///</summary>
        [JsonProperty("num_iid")]
        public string NumIid { get; set; }

        ///<summary> 
        ///me string	否	二合一的me参数，大多数是e后面的那个参数
        ///</summary>
        [JsonProperty("me")]
        public string Me { get; set; }

        ///<summary> 
        ///relation_id string	否	渠道关系ID，仅适用于渠道推广场景。
        ///</summary>
        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        ///<summary> 
        ///signurl int	否	
        /// 	            signurl=5，返回结果整合高拥转链API、解析商品编号API、全网商品详情API、淘口令创建API，已经自动判断和拼接使用全网G券还是全网S券。
        /// 	            signurl=4，返回结果整合高拥转链API、解析商品编号API、商品简版详情API、淘口令创建API，已经自动判断和拼接使用全网G券还是全网S券。
        /// 	            signurl=3，返回结果整合高拥转链API、解析商品编号API，已经自动判断和拼接使用全网G券还是全网S券。
        /// 	            signurl=0或1或2，返回官方高拥转链接口结果，需要自行判断和拼接使用全网G券或者全网S券。
        /// 	            signurl=0，表示直接返回最终结果。
        /// 	            signurl=1或2，表示返回淘宝联盟请求地址，大家拿到地址后再用自己的服务器二次请求即可获得最终结果，值为1返回http链接，值为2返回https安全链接。
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

        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_gaoyongzhuanlian.ashx",
            "http://api.zhetaoke.cn:10000/api/open_gaoyongzhuanlian.ashx"
        };

        private readonly Dictionary<int, string> _signUrlClass = new Dictionary<int, string>()
        {
            {0, nameof(GaoYongZhuanLianTbkPrivilegeGetResponseRequest)},
            {1, nameof(GaoYongZhuanLianOnlyUrlRequest)},
            {2, nameof(GaoYongZhuanLianOnlyUrlRequest)},
            {3, nameof(GaoYongZhuanLianTbkPrivilegeGetResponseRequest)},
            {4, nameof(GaoYongZhuanLianTbkPrivilegeGetResponseRequest)},
            {5, nameof(GaoYongZhuanLianTbkPrivilegeGetResponseRequest)},
        };

        protected abstract int[] AllowValues { get; }
    }

    public class GaoYongZhuanLianTbkPrivilegeGetResponseRequest : GaoYongZhuanLianRequest<GaoYongZhuanLianTbkPrivilegeGetResponse>
    {
        protected override int[] AllowValues => new[] { 0, 3, 4 };
    }

    public class GaoYongZhuanLianOnlyUrlRequest : GaoYongZhuanLianRequest<GaoYongZhuanLianOnlyUrlResponse>
    {
        protected override int[] AllowValues => new[] { 1, 2 };
    }

    public class GaoYongZhuanLianFullInfoRequest : GaoYongZhuanLianRequest<GaoYongZhuanLianFullInfoResponse>
    {
        protected override int[] AllowValues => new[] { 5 };
    }
}
