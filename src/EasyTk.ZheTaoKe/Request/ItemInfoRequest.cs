using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class ItemInfoRequest : BaseRequest<ItemInfoResponse>
    {
        ///<summary> 
        ///num_iids string	是	商品ID串，用,分割，最大40个
        ///</summary>
        [JsonProperty("num_iids")]
        public string NumIids { get; set; }

        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10001/api/open_item_info.ashx"
        };
    }
}
