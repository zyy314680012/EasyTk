using EasyTk.Core;

namespace EasyTk.PinDuoDuo.Response
{
    public abstract class BaseResponse : IResponse
    {
        public string Body { get; set; }
    }
}
