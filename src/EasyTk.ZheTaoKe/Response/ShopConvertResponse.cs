using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class ShopConvertResponse : BaseResponse
    {
        /// <summary>
        /// 返回淘宝联盟请求地址，大家拿到地址后再用自己的服务器二次请求即可获得最终结果
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ShopConvertResponse> GetShopConvertResponse()
        {
            if (Response != null)
            {
                return this;
            }

            if (Response == null && !string.IsNullOrEmpty(Url))
            {
                return await ZheTaoKeClient.RequestAsync<ShopConvertResponse>(Url);
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tbk_sc_shop_convert_response")]
        public TbkScShopConvertResponse Response { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public class TbkScShopConvertResponse
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("results")]
            public TbkScShopConvertResult Results { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("request_id")]
            public string RequestId { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class TbkScShopConvertResult
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("n_tbk_shop")]
            public NTbkShop[] Shops { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class NTbkShop
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("user_id")]
            public long? UserId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("click_url")]
            public string ClickUrl { get; set; }
        }
    }
}
