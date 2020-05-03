using EasyTk.Core.Enums;

namespace EasyTk.Core
{
    public interface IRequest<TResponse> where TResponse : IResponse
    {
        HttpMethod GetMethod();

        string GetApiUrl();
    }
}
