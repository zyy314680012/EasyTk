using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace EasyTk.Helpers
{
    public class HttpHelper
    {
        private static IHttpClientFactory _httpClientFactory;
        public static IHttpClientFactory HttpClientFactory
        {
            get
            {
                if (_httpClientFactory == null)
                {
                    var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
                    _httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
                }

                return _httpClientFactory;
            }
        }
    }
}
