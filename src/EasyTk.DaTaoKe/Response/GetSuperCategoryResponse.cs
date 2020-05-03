using Newtonsoft.Json;

namespace EasyTk.DaTaoKe.Response
{
    public class GetSuperCategoryResponse
    {
        /// <summary>
        /// cid	一级分类ID，1 -女装，2 -母婴，3 -美妆，4 -居家日用，5 -鞋品，6 -美食，7 -文娱车品，8 -数码家电，9 -男装，10 -内衣，11 -箱包，12 -配饰，13 -户外运动，14 -家装家纺	Number	1
        /// </summary>
        [JsonProperty("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// cname	一级分类名称	String	女装
        /// </summary>
        [JsonProperty("cname")]
        public string Cname { get; set; }

        /// <summary>
        /// cpic	一级分类图标	string	https://img.alicdn.com/imgextra/i1/2053469401/TB2oX82HL9TBuNjy0FcXXbeiFXa-2053469401.png
        /// </summary>
        [JsonProperty("cpic")]
        public string Cpic { get; set; }

        [JsonProperty("subcategories")]
        public GetSuperCategorySub[] SubCategories { get; set; }

        public class GetSuperCategorySub
        {

            /// <summary>
            /// subcid	二级分类Id，根据实际返回id为准	Number	98713
            /// </summary>
            [JsonProperty("subcid")]
            public long SubCid { get; set; }

            /// <summary>
            /// scname	二级分类名称	String	T恤/短袖
            /// </summary>
            [JsonProperty("subcname")]
            public string SubCname { get; set; }

            /// <summary>
            /// scpic	二级分类图标	string	https://img.alicdn.com/imgextra/i1/2053469401/TB2oX82HL9TBuNjy0FcXXbeiFXa-2053469401.png
            /// </summary>
            [JsonProperty("scpic")]
            public string ScPic { get; set; }
        }

    }
}
