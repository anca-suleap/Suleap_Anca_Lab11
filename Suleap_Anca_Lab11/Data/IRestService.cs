using System.Threading.Tasks;
using Suleap_Anca_Lab11.Models;

namespace Suleap_Anca_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }

}
