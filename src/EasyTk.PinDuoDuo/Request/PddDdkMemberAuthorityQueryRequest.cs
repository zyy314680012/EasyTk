﻿using EasyTk.PinDuoDuo.Response;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Request
{
    /// <summary>
    /// pdd.ddk.member.authority.query查询是否绑定备案
    /// </summary>
    public class PddDdkMemberAuthorityQueryRequest : BaseRequest<PddDdkMemberAuthorityQueryResponse>
    {
        public override string Type => "pdd.ddk.member.authority.query";

        /// <summary>
        /// pid	STRING	非必填	推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// custom_parameters	STRING	非必填	自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
    }
}
