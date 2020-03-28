namespace TemplatesInXF.Services
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;

    internal class CustomHttpClientHandler : HttpClientHandler
    {
        #if DEBUG
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", string.Empty);
            return await base.SendAsync(request, cancellationToken);
        }
        #endif

        #if (!DEBUG)
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", string.Empty);
            return await base.SendAsync(request, cancellationToken);
        }
        #endif
    }
}