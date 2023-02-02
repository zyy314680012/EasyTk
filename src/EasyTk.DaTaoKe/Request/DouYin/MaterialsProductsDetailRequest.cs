using EasyTk.DaTaoKe.Response;
using EasyTk.DaTaoKe.Response.DouYin;
using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Request.DouYin
{
    public class MaterialsProductsDetailRequest : BaseRequest<WrapperResponseDouYinTotal<MaterialsProductsDetailResponse>>
    {
        public override string GetApiUrl() => "https://openapiv2.dataoke.com/tiktok/tiktok-materials-products-details";

        public override string Version => "v1.0.0";

        #region

        /// <summary>
        /// productIds String 是 批量商品ID（最多20个)
        /// </summary>
        [JsonProperty("productIds")]
        public string ProductIds { get; set; }

        #endregion
    }
}
