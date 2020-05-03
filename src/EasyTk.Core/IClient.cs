using System.Threading.Tasks;

namespace EasyTk.Core
{
    /// <summary>
    /// 客户端
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// 执行
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : IResponse;
    }
}
