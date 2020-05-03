using Newtonsoft.Json;

namespace EasyTk.HaoDanKu.Response
{
    public class SuperClassifyResponse : BaseResponse
    {
        ///<summary> 
        ///general_classify string	general_classify	超级分类数据
        ///</summary>
        [JsonProperty("general_classify")]
        public SuperClassifyResponseData[] GeneralClassify { get; set; }


        public class SuperClassifyResponseData
        {
            ///<summary> 
            ///cid integer	1	所属类目：1女装，2男装，3内衣，4美妆，5配饰，6鞋品，7箱包，8儿童，9母婴，10居家，11美食，12数码，13家电，14其他，15车品，16文体
            ///</summary>
            [JsonProperty("cid")]
            public long Cid { get; set; }

            ///<summary> 
            ///main_name string	裙装	二级类目总称
            ///</summary>
            [JsonProperty("main_name")]
            public string MainName { get; set; }

            ///<summary> 
            ///
            ///</summary>
            [JsonProperty("data")]
            public SuperClassifyResponseSubData[] Data { get; set; }
        }

        public class SuperClassifyResponseSubData
        {
            /// <summary>
            /// 名称
            /// </summary>
            [JsonProperty("next_name")]
            public string NextName { get; set; }

            [JsonProperty("info")]
            public SuperClassifyResponseSubInfo[] Info { get; set; }
        }

        public class SuperClassifyResponseSubInfo
        {
            ///<summary> 
            ///son_name string	连衣裙	二级具体类目名
            ///</summary>
            [JsonProperty("son_name")]
            public string SonName { get; set; }

            ///<summary> 
            ///imgurl string	http:\/\/img.haodanku.com\/89937f347f81f5c5539f9da9b35b7a62-600	分类图
            ///</summary>
            [JsonProperty("imgurl")]
            public string ImgUrl { get; set; }
        }
    }
}
