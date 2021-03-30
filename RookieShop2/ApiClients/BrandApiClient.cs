using Microsoft.AspNetCore.Http;
using RookieShop2.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RookieShop2.ApiClients
{
    public class BrandApiClient : IBrandApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BrandApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IList<BrandVm>> GetBrands()
        {
            var httpClient = _httpClientFactory.CreateClient("local");
            var response = await httpClient.GetAsync("api/brands");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<BrandVm>>();
        }
    }
}
