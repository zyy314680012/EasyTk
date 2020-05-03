using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetBrandListResponse
    {
        /// <summary>
        /// brandId	品牌ID	String	3224818
        /// </summary>
        [JsonProperty("brandId")]
        public string BrandId { get; set; }

        /// <summary>
        /// brandName	品牌名称	String	背靠背
        /// </summary>
        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        /// <summary>
        /// brandLogo	品牌logo	String	https://img.alicdn.com/bao/uploaded///img.taobaocdn.com/tps/TB1xENRpf2H8KJjy1zkXXXr7pXa
        /// </summary>
        [JsonProperty("brandLogo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// brandEnglish	品牌英文名称	String	Kappa
        /// </summary>
        [JsonProperty("brandEnglish")]
        public string BrandEnglish { get; set; }

        /// <summary>
        /// brandScore	店铺评分	Number	3
        /// </summary>
        [JsonProperty("brandScore")]
        public string BrandScore { get; set; }

        /// <summary>
        /// location	发源地	String	北京
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// establishTime	创立时间	String	1987
        /// </summary>
        [JsonProperty("establishTime")]
        public string EstablishTime { get; set; }

        /// <summary>
        /// belong	所属公司	String	
        /// </summary>
        [JsonProperty("belong")]
        public string Belong { get; set; }

        /// <summary>
        /// position	品牌定位：1. 奢侈 2.轻奢 3.大众	Sting	1
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// consumer	消费群体	String	
        /// </summary>
        [JsonProperty("consumer")]
        public string Consumer { get; set; }

        /// <summary>
        /// label	特色标签	String	
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// simpleLabel	一句话评价	String	
        /// </summary>
        [JsonProperty("simpleLabel")]
        public string SimpleLabel { get; set; }

        /// <summary>
        /// cids	主营类目（可能有多个主营类目，用逗号隔开）
        /// </summary>
        [JsonProperty("cids")]
        public string Cids { get; set; }

        [JsonProperty("shop")]
        public GetBrandListShop[] Shops { get; set; }


        public string[] GetLabel()
        {
            if (!string.IsNullOrEmpty(Label))
            {
                try
                {
                    var arr = JsonConvert.DeserializeObject<string[]>(Label);
                    return arr;
                }
                catch
                {
                    //
                }
            }
            return new string[0];
        }

        public class GetBrandListShop
        {
            /// <summary>
            /// name	旗舰店铺名称	String	Kappa官方旗舰店
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// sellerId	店铺ID	Number	285492195
            /// </summary>
            [JsonProperty("sellerId")]
            public string SellerId { get; set; }

        }
    }
}
