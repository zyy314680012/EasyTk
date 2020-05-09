using EasyTk.Core;

namespace EasyTk.ZheTaoKe.Response
{
    public abstract class BaseResponse : IResponse
    {
        public string Body { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public virtual bool IsSuccess => true;
    }
}
