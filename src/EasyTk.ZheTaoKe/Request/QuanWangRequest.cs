using EasyTk.ZheTaoKe.Response;
using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Request
{
    public class QuanWangRequest : BaseRequest<BaseResponseContainer<QuanWangResponse[]>>
    {
        protected override string[] GatewayArray => new[]
        {
            "https://api.zhetaoke.com:10003/api/api_quanwang.ashx",
            "http://api.zhetaoke.cn:10000/api/api_quanwang.ashx"
        };

        #region ===============

        ///<summary> 
        ///page int	否	分页获取数据,第几页
        ///</summary>
        [JsonProperty("page")]
        public long? Page { get; set; } = 1;

        ///<summary> 
        ///page_size int	否	每页数据条数（默认每页20条），可自定义1-50之间
        ///</summary>
        [JsonProperty("page_size")]
        public long? PageSize { get; set; } = 20;

        ///<summary> 
        ///商品排序方式，new：按照综合排序，total_sale_num_asc：按照总销量从小到大排序，total_sale_num_desc：按照总销量从大到小排序，sale_num_asc：按照月销量从小到大排序，sale_num_desc：按照月销量从大到小排序，commission_rate_asc：按照佣金比例从小到大排序，commission_rate_desc：按照佣金比例从大到小排序，price_asc：按照价格从小到大排序，price_desc：按照价格从大到小排序。
        ///</summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        ///<summary> 
        ///q string	否	输入“内衣”关键词，返回标题中带内衣的商品。
        ///</summary>
        [JsonProperty("q")]
        public string Q { get; set; }

        /// <summary>
        ///material_id	string	否	官方的物料Id，默认为空表示全网商品；
        /// </summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }

        ///<summary> 
        ///youquan string	否	是否有券，1为有券，其它值为全部商品
        ///</summary>
        [JsonProperty("youquan")]
        public long? YouQuan { get; set; } = 0;

        ///<summary> 
        ///haiwai string	否	是否海外商品，1为海外，其它值为全部商品
        ///</summary>
        [JsonProperty("haiwai")]
        public long? HaiWai { get; set; }

        ///<summary> 
        ///haoping string	否	是否好评商品，1为好评，其它值为全部商品
        ///</summary>
        [JsonProperty("haoping")]
        public long? HaoPing { get; set; }

        ///<summary> 
        ///tj string	否	是否天猫商品，值为空：全部商品，tmall：天猫商品
        ///</summary>
        [JsonProperty("tj")]
        public string Tj { get; set; }

        ///<summary> 
        ///itemloc string	否	商品所在地，值为空：全部商品，其它值：北京、上海、广州、深圳、重庆、杭州等。必须是城市名称，不能带省份。
        ///</summary>
        [JsonProperty("itemloc")]
        public string Itemloc { get; set; }

        /// <summary>
        /// need_prepay	string	否	是否加入消费者保障，值为空：全部商品，1：加入消费者保障
        /// </summary>
        [JsonProperty("need_prepay")]
        public string NeedPrepay { get; set; }

        ///<summary> 
        ///cat string	否	商品筛选-后台类目ID(category_id)。用,分割，最大10个，该ID可以加入折淘客开放平台API群来获取。cat=50014023，表示：垂钓装备。cat=29，表示：宠物/宠物食品及用品。cat=50050359，表示：水产肉类/新鲜蔬果/熟食。cat=50454031，表示：景点门票/演艺演出/周边游。cat=122650005，表示：童鞋/婴儿鞋/亲子鞋。cat=122950001，表示：节庆用品/礼品。大家可以利用此参数，制作更多的特色专题栏目，如需要更多分类，请联系折淘客QQ群技术。
        ///</summary>
        [JsonProperty("cat")]
        public string Cat { get; set; }

        ///<summary> 
        ///start_tk_rate string	否	淘客佣金比率下限。如：输入20，表示大于等于20%
        ///</summary>
        [JsonProperty("start_tk_rate")]
        public float? StartTkRate { get; set; }

        ///<summary> 
        ///end_tk_rate string	否	淘客佣金比率上限。如：输入50，表示小于等于50%
        ///</summary>
        [JsonProperty("end_tk_rate")]
        public float? EndTkRate { get; set; }

        ///<summary> 
        ///start_price string	否	折扣价格下限。如：输入100，表示大于等于100元
        ///</summary>
        [JsonProperty("start_price")]
        public float? StartPrice { get; set; }

        ///<summary> 
        ///end_price string	否	折扣价格上限。如：输入200，表示小于等于200元
        ///</summary>
        [JsonProperty("end_price")]
        public float? EndPrice { get; set; }

        ///<summary> 
        ///type string	否	过滤值 值为0：不过滤，值为1：轻度过滤，值为2：中度过滤，强烈推荐值为2。
        ///</summary>
        [JsonProperty("type")]
        public long? Type { get; set; }

        #endregion
    }
}
