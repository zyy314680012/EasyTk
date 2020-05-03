using EasyTk.Core;
using Newtonsoft.Json;

namespace EasyTk.PinDuoDuo.Response
{
    public abstract class BaseResponse : IResponse
    {
        public string Body { get; set; }

        public abstract bool IsSuccess { get; }

        public abstract ErrorResponse Error { get; }
    }

    public abstract class BaseResponse<TResponseData> : BaseResponse
    {
        public abstract TResponseData Data { get; set; }

        public override bool IsSuccess => Data != null;

        private bool _isDeserialized = false;
        private ErrorResponse _error = null;

        public override ErrorResponse Error
        {
            get
            {
                if (IsSuccess)
                {
                    return null;
                }
                if (_isDeserialized)
                {
                    return _error;
                }

                try
                {
                    _error = JsonConvert.DeserializeObject<ErrorResponse>(Body);
                }
                catch
                {
                    //
                }
                _isDeserialized = true;

                return _error;
            }
        }
    }
}
