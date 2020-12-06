using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using EasyTk.Core;
using EasyTk.PinDuoDuo.Request;
using Xunit;

namespace EasyTk.PinDuoDuo.Test
{
    public class BaseTest
    {
        protected IClient Client;

        protected const string Pid = "8804138_132609385";

        public BaseTest()
        {
            Client = new PinDuoDuoClient("cfa2f1b78bc24f2882a12295aa3815c7",
                "b45f7f189dd133960ef5585cf9c25b45121726bd",
                "https://gw-api.pinduoduo.com/api/router");
        }

        public Dictionary<string, string> GetPidCustomParameters()
        {
            return new Dictionary<string, string>
            {
                { "uid","henry123"}
            };
        }

        public string ToJson(Dictionary<string, string> cp)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(cp);
        }
    }


}
