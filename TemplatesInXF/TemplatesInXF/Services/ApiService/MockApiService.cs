#if MOCK
[assembly: Xamarin.Forms.Dependency(typeof(TemplatesInXF.Services.MockApiService))]
#endif
namespace TemplatesInXF.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MockApiService : IApiService
    {
        public Task<bool> GetExampleAsync(Dictionary<string, string> exampleData)
        {
            return Task.FromResult(true);
        }
    }
}
