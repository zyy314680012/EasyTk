using System.Collections.Generic;
using EasyTk.HaoDanKu.Response.Partial;
using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class BrandResponse
    {
        [JsonProperty("data")]
        public IList<BrandResponseData> Data { get; set; }

        [JsonProperty("todayrecommend")]
        public TodayRecommendData TodayRecommend { get; set; }

        [JsonProperty("subjectitems")]
        public SubjectItemsData[] SubjectItems { get; set; }

        public class BrandResponseData
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

            [JsonProperty("item")]
            public BrandResponseDataItem[] Items { get; set; }

        }

        public class BrandResponseDataItem : GoodItemPartial
        {

        }

        public class TodayRecommendData
        {
            [JsonProperty("data")]
            public TodayRecommendDataData Data { get; set; }

            [JsonProperty("items")]
            public BrandResponseDataItem[] Items { get; set; }
        }

        public class TodayRecommendDataData
        {
            ///<summary> 
            ///id integer	9	品牌ID
            ///</summary>
            [JsonProperty("id")]
            public long Id { get; set; }

            ///<summary> 
            ///name string	蓝月亮	品牌名
            ///</summary>
            [JsonProperty("name")]
            public string Name { get; set; }

            ///<summary> 
            ///background string	http://img.haodanku.com/FhLIWY2qY3bUOi-F0mIFkchQ9G_L	背景图
            ///</summary>
            [JsonProperty("background")]
            public string Background { get; set; }

            ///<summary> 
            ///brand_logo string	http://img02.taobaocdn.com:80/tfscom/TB13RkiDAvoK1RjSZFNXXcxMVXa	品牌logo
            ///</summary>
            [JsonProperty("brand_logo")]
            public string BrandLogo { get; set; }

            ///<summary> 
            ///title string	高露洁公司已有200年的历史，产品已经销售到世界200多个国家和地区，成为全球领先的日用消费品公司...	品牌介绍
            ///</summary>
            [JsonProperty("title")]
            public string Title { get; set; }

            ///<summary> 
            ///actitvity_endtime string	1561392000	结束时间
            ///</summary>
            [JsonProperty("actitvity_endtime")]
            public string ActitvityEndTime { get; set; }

            ///<summary> 
            ///num string	30	品牌商品总数
            ///</summary>
            [JsonProperty("num")]
            public long? Num { get; set; }

            ///<summary> 
            ///multiple Array	"https://img.alicdn.com/bao/uploaded/TB2AIwMhaQoBKNjSZJnXXaw9VXa_!!2946707863.jpg", "http://img.alicdn.com/imgextra/i1/3325389525/TB2Xa9Kg3fH8KJjy1zcXXcTzpXa_!!3325389525.jpg", "http://img.alicdn.com/imgextra/i3/3493023771/O1CN01agIbfN1djA4wy6V4Z_!!3493023771.jpg", "http://img.alicdn.com/imgextra/i1/2200728754462/O1CN01xtYdTt1ipdmZsUJhB_!!2200728754462.jpg"	该品牌下商品主图（多张）
            ///</summary>
            [JsonProperty("multiple")]
            public string[] Multiple { get; set; }

        }

        public class SubjectItemsData
        {
            ///<summary> 
            ///brand_id integer	9	品牌ID
            ///</summary>
            [JsonProperty("brand_id")]
            public long BrandId { get; set; }

            ///<summary> 
            ///brand_name string	蓝月亮	品牌名称
            ///</summary>
            [JsonProperty("brand_name")]
            public string BrandName { get; set; }

            ///<summary> 
            ///brand_image string	http://img.haodanku.com/FhLIWY2qY3bUOi-F0mIFkchQ9G_L	品牌主题图片
            ///</summary>
            [JsonProperty("brand_image")]
            public string BrandImage { get; set; }

            ///<summary> 
            ///brand_logo string	http://img04.taobaocdn.com:80/tfscom/TB1ogrODzDpK1RjSZFrXXa78VXa	品牌logo
            ///</summary>
            [JsonProperty("brand_logo")]
            public string BrandLogo { get; set; }

            [JsonProperty("items")]
            public BrandResponseDataItem[] Items { get; set; }
        }
    }
}
