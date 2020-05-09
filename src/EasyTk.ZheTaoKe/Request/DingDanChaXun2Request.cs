using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class DingDanChaXun2Request : BaseRequest<DingDanChaXun2Response>
    {
        #region =========================

        ///<summary> 
        ///start_time string	是	订单查询开始时间，2019-04-05 12:18:22
        ///</summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        ///<summary> 
        ///end_time string	是	订单查询结束时间，2019-04-25 15:18:22，目前最大可查3个小时内的数据
        ///</summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        ///<summary> 
        ///query_type string	否	查询时间类型，1：按照订单淘客创建时间查询，2:按照订单淘客付款时间查询，3:按照订单淘客结算时间查询
        ///</summary>
        [JsonProperty("query_type")]
        public string QueryType { get; set; }

        ///<summary> 
        ///position_index string	否	位点，除第一页之外，都需要传递；前端原样返回。注意：从第二页开始，位点必须传递前一页返回的值，否则翻页无效。
        ///</summary>
        [JsonProperty("position_index")]
        public string PositionIndex { get; set; }

        ///<summary> 
        ///page_size string	否	页大小，默认20，1~100
        ///</summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; } = 20L;

        ///<summary> 
        ///member_type string	否	推广者角色类型,2:二方，3:三方，不传，表示所有角色
        ///</summary>
        [JsonProperty("member_type")]
        public string MemberType { get; set; }

        ///<summary> 
        ///tk_status string	否	淘客订单状态，12-付款，13-关闭，14-确认收货（暂时无法结算佣金），3-结算成功;不传，表示所有状态
        ///</summary>
        [JsonProperty("tk_status")]
        public string TkStatus { get; set; }

        ///<summary> 
        ///jump_type string	否	跳转类型，当向前或者向后翻页必须提供,-1: 向前翻页,1：向后翻页
        ///</summary>
        [JsonProperty("jump_type")]
        public string JumpType { get; set; }

        ///<summary> 
        ///page_no string	否	第几页，默认1，1~100
        ///</summary>
        [JsonProperty("page_no")]
        public long? PageNo { get; set; } = 1;

        ///<summary> 
        ///order_scene string	否	场景订单场景类型，1:常规订单，2:渠道订单，3:会员运营订单，默认为1
        ///</summary>
        [JsonProperty("order_scene")]
        public long OrderScene { get; set; } = 1;

        ///<summary> 
        ///signurl int	否	值为1或者2，表示返回淘宝联盟请求地址，大家拿到地址后再用自己的服务器二次请求即可获得最终结果，值为1返回http链接，值为2返回https安全链接。
        ///</summary>
        [JsonProperty("signurl")]
        public int SignUrl { get; set; } = 2;


        #endregion

        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_dingdanchaxun2.ashx",
            "http://api.zhetaoke.cn:10000/api/open_open_dingdanchaxun2.ashx"
        };
    }
}
