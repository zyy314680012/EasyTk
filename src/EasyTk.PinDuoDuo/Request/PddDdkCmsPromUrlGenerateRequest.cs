﻿using System;
using System.Collections.Generic;
using System.Text;
using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// 生成商城-频道推广链接
    /// </summary>
    public class PddDdkCmsPromUrlGenerateRequest : BaseRequest<PddDdkCmsPromUrlGenerateResponse>
    {
        public override string Type => "pdd.ddk.cms.prom.url.generate";

        #region 

        /// <summary>
        /// 0, "1.9包邮"；1, "今日爆款"； 2, "品牌清仓"； 4,"PC端专属商城"；不传值为默认商城
        /// </summary>
        [JsonProperty("channel_type")]
        public long? ChannelType { get; set; }

        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }

        /// <summary>
        /// 是否生成手机跳转链接。true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_mobile")]
        public bool? GenerateMobile { get; set; }

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
        /// 是否唤起微信客户端， 默认false 否，true 是
        /// </summary>
        [JsonProperty("generate_weapp_webview")]
        public bool? GenerateWeAppWebView { get; set; }

        /// <summary>
        /// 单人团多人团标志。true-多人团，false-单人团 默认false
        /// </summary>
        [JsonProperty("multi_group")]
        public bool? MultiGroup { get; set; }

        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        [JsonProperty("p_id_list")]
        public string[] PIdList { get; set; }

        #endregion
    }
}
