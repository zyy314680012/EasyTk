using EasyTk.Core;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class SingleBrandResponse
    {
        ///<summary> 
        ///id integer	8357753	品牌自增ID
        ///</summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        ///<summary> 
        ///tb_brand_name string	Three Squirrels/三只松鼠	淘宝品牌名称
        ///</summary>
        [JsonProperty("tb_brand_name")]
        public string TbBrandName { get; set; }

        ///<summary> 
        ///fq_brand_name string	三只松鼠	蜂擎品牌名称
        ///</summary>
        [JsonProperty("fq_brand_name")]
        public string FqBrandName { get; set; }

        ///<summary> 
        ///brand_logo string	http://img02.taobaocdn.com:80/tfscom/TB1jsD.DxjaK1RjSZFAXXbdLFXa	品牌logo
        ///</summary>
        [JsonProperty("brand_logo")]
        public string BrandLogo { get; set; }

        ///<summary> 
        ///inside_logo string	http://img02.taobaocdn.com:80/tfscom/TB1jsD.DxjaK1RjSZFAXXbdLFXa	内页logo
        ///</summary>
        [JsonProperty("inside_logo")]
        public string InsideLogo { get; set; }

        ///<summary> 
        ///brandcat integer	11	品牌类目
        ///</summary>
        [JsonProperty("brandcat")]
        public long? BrandCat { get; set; }

        ///<summary> 
        ///introduce string	三只松鼠，互联网坚果销量冠军品牌，致力于生产天然新鲜、非过度加工的健康食品，誓将卖萌服务与极致用户体验进行到底，数百万消费者的不二选择，值得信赖！	品牌简介
        ///</summary>
        [JsonProperty("introduce")]
        public string Introduce { get; set; }


    }
}
