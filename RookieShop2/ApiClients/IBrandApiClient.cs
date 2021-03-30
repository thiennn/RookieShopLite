using RookieShop2.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RookieShop2.ApiClients
{
    public interface IBrandApiClient
    {
        Task<IList<BrandVm>> GetBrands();
    }
}