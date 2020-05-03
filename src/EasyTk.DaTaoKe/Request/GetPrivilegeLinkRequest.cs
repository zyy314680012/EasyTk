using EasyTk.DaTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request
{
    /// <summary>
    /// 高效转链
    /// 高效转链接口将您的pid信息、商品地址及优惠券信息进行转链，转链后的结果可进行推广或完成订单，接口支持授权淘宝账号下所有PID进行转链。由于接口特殊性，请适量缓存已转链的链接，以达最佳效率
    /// </summary>
    public class GetPrivilegeLinkRequest : BaseRequest<WrapperResponse<GetPrivilegeLinkResponse>>
    {
        public override string GetApiUrl() => "https://openapi.dataoke.com/api/tb-service/get-privilege-link";

        public override string Version => "v1.1.1";

        #region 

        /// <summary>
        /// goodsId	淘宝商品id	是	String	
        /// </summary>
        [JsonProperty("goodsId")]
        public string GoodsId { get; set; }

        /// <summary>
        /// couponId	优惠券ID	否	String	商品的优惠券ID，一个商品在联盟可能有多个优惠券，可通过填写该参数的方式选择使用的优惠券，请确认优惠券ID正确，否则无法正常跳转
        /// </summary>
        [JsonProperty("couponId")]
        public string CouponId { get; set; }

        /// <summary>
        /// pid	推广位ID	否	string	用户可自由填写当前大淘客账号下已授权淘宝账号的任一pid，若未填写，则默认使用创建应用时绑定的pid
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// channelId	渠道id	否	string	用于代理体系，渠道id将会和传入的pid进行验证，验证通过将正常转链，请确认从私域管理系统中提取的渠道id是否正确
        /// </summary>
        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        #endregion
    }
}
