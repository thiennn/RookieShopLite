using Microsoft.AspNetCore.Mvc;
using RookieShop2.ApiClients;
using System.Threading.Tasks;

namespace RookieShop2.ViewComponents
{
    public class BrandMenuViewComponent : ViewComponent
    {
        private readonly IBrandApiClient _brandApiClient;

        public BrandMenuViewComponent(IBrandApiClient brandApiClient)
        {
            _brandApiClient = brandApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var brands = await _brandApiClient.GetBrands();

            return View(brands);
        }
    }
}
