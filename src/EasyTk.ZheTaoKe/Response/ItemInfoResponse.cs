using Newtonsoft.Json;

namespace EasyTk.ZheTaoKe.Response
{
    public class ItemInfoResponse : BaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tbk_item_info_get_response")]
        public TbkItemInfoGetResponse Response { get; set; }

        public class TbkItemInfoGetResponse
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("results")]
            public TbkItemInfoGetResults Results { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("request_id")]
            public string RequestId { get; set; }
        }

        public class TbkItemInfoGetResults
        {
            [JsonProperty("n_tbk_item")]
            public NTbkItem[] Items { get; set; }
        }

        public class NTbkItem
        {
            ///<summary> 
            ///cat_name String	女装	一级类目名称
            ///</summary>
            [JsonProperty("cat_name")]
            public string CatName { get; set; }

            ///<summary> 
            ///num_iid Number	123	商品ID
            ///</summary>
            [JsonProperty("num_iid")]
            public long? NumIid { get; set; }

            ///<summary> 
            ///title String	连衣裙	商品标题
            ///</summary>
            [JsonProperty("title")]
            public string Title { get; set; }

            ///<summary> 
            ///pict_url String	http://gi4.md.alicdn.com/bao/uploaded/i4/xxx.jpg	商品主图
            ///</summary>
            [JsonProperty("pict_url")]
            public string PictUrl { get; set; }

            ///<summary> 
            ///small_images String[]	http://gi4.md.alicdn.com/bao/uploaded/i4/xxx.jpg	商品小图列表
            ///</summary>
            [JsonProperty("small_images")]
            public SmallImages SmallImages { get; set; }

            ///<summary> 
            ///reserve_price String	102.00	商品一口价格
            ///</summary>
            [JsonProperty("reserve_price")]
            public float? ReservePrice { get; set; }

            ///<summary> 
            ///zk_final_price String	88.00	折扣价（元） 若属于预售商品，付定金时间内，折扣价=预售价
            ///</summary>
            [JsonProperty("zk_final_price")]
            public float? ZkFinalPrice { get; set; }

            ///<summary> 
            ///user_type Number	1	卖家类型，0表示集市，1表示商城
            ///</summary>
            [JsonProperty("user_type")]
            public long? UserType { get; set; }

            ///<summary> 
            ///provcity String	杭州	商品所在地
            ///</summary>
            [JsonProperty("provcity")]
            public string ProvCity { get; set; }

            ///<summary> 
            ///item_url String	http://detail.m.tmall.com/item.htm?id=xxx	商品链接
            ///</summary>
            [JsonProperty("item_url")]
            public string ItemUrl { get; set; }

            ///<summary> 
            ///seller_id Number	123	卖家id
            ///</summary>
            [JsonProperty("seller_id")]
            public long? SellerId { get; set; }

            ///<summary> 
            ///volume Number	1	30天销量
            ///</summary>
            [JsonProperty("volume")]
            public long? Volume { get; set; }

            ///<summary> 
            ///nick String	xx旗舰店	店铺名称
            ///</summary>
            [JsonProperty("nick")]
            public string Nick { get; set; }

            ///<summary> 
            ///cat_leaf_name String	情趣内衣	叶子类目名称
            ///</summary>
            [JsonProperty("cat_leaf_name")]
            public string CatLeafName { get; set; }

            ///<summary> 
            ///is_prepay Boolean	true	是否加入消费者保障
            ///</summary>
            [JsonProperty("is_prepay")]
            public bool? IsPrepay { get; set; }

            ///<summary> 
            ///shop_dsr Number	23	店铺dsr 评分
            ///</summary>
            [JsonProperty("shop_dsr")]
            public float? ShopDsr { get; set; }

            ///<summary> 
            ///ratesum Number	13	卖家等级
            ///</summary>
            [JsonProperty("ratesum")]
            public long? RateSum { get; set; }

            ///<summary> 
            ///i_rfd_rate Boolean	true	退款率是否低于行业均值
            ///</summary>
            [JsonProperty("i_rfd_rate")]
            public bool? IRfdRate { get; set; }

            ///<summary> 
            ///h_good_rate Boolean	true	好评率是否高于行业均值
            ///</summary>
            [JsonProperty("h_good_rate")]
            public bool? HGoodRate { get; set; }

            ///<summary> 
            ///h_pay_rate30 Boolean	true	成交转化是否高于行业均值
            ///</summary>
            [JsonProperty("h_pay_rate30")]
            public bool? HPayRate30 { get; set; }

            ///<summary> 
            ///free_shipment Boolean	true	是否包邮
            ///</summary>
            [JsonProperty("free_shipment")]
            public bool? FreeShipment { get; set; }

            ///<summary> 
            ///material_lib_type String	1	商品库类型，支持多库类型输出，以英文逗号分隔“,”分隔，1:营销商品主推库，2. 内容商品库，如果值为空则不属于1，2这两种商品类型
            ///</summary>
            [JsonProperty("material_lib_type")]
            public string MaterialLibType { get; set; }

            ///<summary> 
            ///presale_discount_fee_text String	付定金立减20元	预售商品-商品优惠信息
            ///</summary>
            [JsonProperty("presale_discount_fee_text")]
            public string PreSaleDiscountFeeText { get; set; }

            ///<summary> 
            ///presale_tail_end_time Number	1937297392332	预售商品-付定金结束时间（毫秒）
            ///</summary>
            [JsonProperty("presale_tail_end_time")]
            public long? PreSaleTailEndTime { get; set; }

            ///<summary> 
            ///presale_tail_start_time Number	1937297392332	预售商品-付尾款开始时间（毫秒）
            ///</summary>
            [JsonProperty("presale_tail_start_time")]
            public long? PreSaleTailStartTime { get; set; }

            ///<summary> 
            ///presale_end_time Number	1937297392332	预售商品-付定金结束时间（毫秒）
            ///</summary>
            [JsonProperty("presale_end_time")]
            public long? PreSaleEndTime { get; set; }

            ///<summary> 
            ///presale_start_time Number	1937297392332	预售商品-付定金开始时间（毫秒）
            ///</summary>
            [JsonProperty("presale_start_time")]
            public long? PreSaleStartTime { get; set; }

            ///<summary> 
            ///presale_deposit String	100	预售商品-定金（元）
            ///</summary>
            [JsonProperty("presale_deposit")]
            public float? PreSaleDeposit { get; set; }

            ///<summary> 
            ///ju_play_end_time Number	1937297392332	聚划算满减 -结束时间（毫秒）
            ///</summary>
            [JsonProperty("ju_play_end_time")]
            public long? JuPlayEndTime { get; set; }

            ///<summary> 
            ///ju_play_start_time Number	1937297392332	聚划算满减 -开始时间（毫秒）
            ///</summary>
            [JsonProperty("ju_play_start_time")]
            public long? JuPlayStartTime { get; set; }

            ///<summary> 
            ///play_info String	玩法	1聚划算满减：满N件减X元，满N件X折，满N件X元） 2天猫限时抢：前N分钟每件X元，前N分钟满N件每件X元，前N件每件X元）
            ///</summary>
            [JsonProperty("play_info")]
            public string PlayInfo { get; set; }

            ///<summary> 
            ///tmall_play_activity_end_time Number	1937297392332	天猫限时抢可售 -结束时间（毫秒）
            ///</summary>
            [JsonProperty("tmall_play_activity_end_time")]
            public long? TmallPlayActivityEndTime { get; set; }

            ///<summary> 
            ///tmall_play_activity_start_time Number	1937297392332	天猫限时抢可售 -开始时间（毫秒）
            ///</summary>
            [JsonProperty("tmall_play_activity_start_time")]
            public long? TmallPlayActivityStartTime { get; set; }

            ///<summary> 
            ///ju_online_start_time String	1581868800000	聚划算信息-聚淘开始时间（毫秒）
            ///</summary>
            [JsonProperty("ju_online_start_time")]
            public long? JuOnlineStartTime { get; set; }

            ///<summary> 
            ///ju_online_end_time String	1582300799000	聚划算信息-聚淘结束时间（毫秒）
            ///</summary>
            [JsonProperty("ju_online_end_time")]
            public long? JuOnlineEndTime { get; set; }

            ///<summary> 
            ///ju_pre_show_start_time String	1581868800000	聚划算信息-商品预热开始时间（毫秒）
            ///</summary>
            [JsonProperty("ju_pre_show_start_time")]
            public long? JuPreShowStartTime { get; set; }

            ///<summary> 
            ///ju_pre_show_end_time String	1582300799000	聚划算信息-商品预热结束时间（毫秒）
            ///</summary>
            [JsonProperty("ju_pre_show_end_time")]
            public long? JuPreShowEndTime { get; set; }
        }

        public class SmallImages
        {
            [JsonProperty("string")]
            public string[] String { get; set; }
        }
    }
}
