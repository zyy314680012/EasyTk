using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ApiLunBoResponse
    {
        /// <summary>
        /// code":"6", /*自动增长列编号*/
        /// </summary>
        [JsonProperty("code")]
        public long? Code { get; set; }

        /// <summary>
        /// name":"天猫国际",  /*轮播图名称*/
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// pic":"https://api.zhetaoke.com:10001/api/banner/20.jpg",   /*图片地址*/
        /// </summary>
        [JsonProperty("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// get_url":"https://api.zhetaoke.com:10001/api/api_all.ashx?appkey={替换appkey}&page=1&page_size=20&sort=sale_num_desc&jh=haitao", /*商品请求地址*/
        /// </summary>
        [JsonProperty("get_url")]
        public string GetUrl { get; set; }

        /// <summary>
        /// date_time":"2019/08/03 17:25:17"   /*添加时间*/
        /// </summary>
        [JsonProperty("date_time")]
        public string DateTime { get; set; }

    }
}
