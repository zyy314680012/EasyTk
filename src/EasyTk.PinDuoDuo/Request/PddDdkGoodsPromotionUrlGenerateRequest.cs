﻿using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 多多进宝推广链接生成
    /// </summary>
    public class PddDdkGoodsPromotionUrlGenerateRequest : BaseRequest<PddDdkGoodsPromotionUrlGenerateResponse>
    {
        public override string Type => "pdd.ddk.goods.promotion.url.generate";

        #region 

        /// <summary>
        /// crash_gift_id	LONG	非必填	多多礼金ID
        /// </summary>
        [JsonProperty("crash_gift_id")]
        public long? CrashGiftId { get; set; }

        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }

        /// <summary>
        /// generate_authority_url	BOOLEAN	非必填	是否生成带授权的单品链接。如果未授权，则会走授权流程
        /// </summary>
        [JsonProperty("generate_authority_url")]
        public bool GenerateAuthorityUrl { get; set; }

        /// <summary>
        /// 是否生成店铺收藏券推广链接
        /// </summary>
        [JsonProperty("generate_mall_collect_coupon")]
        public bool? GenerateMallCollectCoupon { get; set; }

        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        [JsonProperty("generate_qq_app")]
        public bool? GenerateQqApp { get; set; }

        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        [JsonProperty("generate_schema_url")]
        public bool? GenerateSchemaUrl { get; set; }

        /// <summary>
        /// 是否生成短链接，true-是，false-否
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }

        /// <summary>
        /// 是否生成微博推广链接
        /// </summary>
        [JsonProperty("generate_weiboapp_webview")]
        public bool? GenerateWeiboappWebview { get; set; }

        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        [JsonProperty("generate_we_app")]
        public bool? GenerateWeApp { get; set; }

        /// <summary>
        /// 商品ID，仅支持单个查询
        /// </summary>
        [JsonProperty("goods_id_list")]
        public long[] GoodsIdList { get; set; }

        /// <summary>
        /// goods_sign	STRING	非必填	商品goodsSign，用于查询指定商品，仅支持单个查询。
        /// </summary>
        [JsonProperty("goods_sign")]
        public string GoodsSign { get; set; }

        /// <summary>
        /// true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手
        /// </summary>
        [JsonProperty("multi_group")]
        public bool? MultiGroup { get; set; }

        /// <summary>
        /// 推广位ID
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }

        /// <summary>
        /// room_id_list 	STRING[]	非必填	直播间id列表，如果生成直播间推广链接该参数必填，goods_id_list填[1]
        /// </summary>
        [JsonProperty("room_id_list")]
        public string[] room_id_list { get; set; }

        /// <summary>
        /// 搜索id，建议填写，提高收益。来自pdd.ddk.goods.recommend.get、pdd.ddk.goods.search、pdd.ddk.top.goods.list.query等接口
        /// </summary>
        [JsonProperty("search_id")]
        public string SearchId { get; set; }

        /// <summary>
        /// target_id_list	STRING[]	非必填	直播预约id列表，如果生成直播间预约推广链接该参数必填，goods_id_list填[1]，room_id_list不填
        /// </summary>
        [JsonProperty("target_id_list")]
        public string[] TargetIdList { get; set; }

        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public long? ZsDuoId { get; set; }

        #endregion
    }
}
