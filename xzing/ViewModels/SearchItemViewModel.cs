

using System.Threading.Tasks;
using xzing.Models;
using xzing.Views;

namespace xzing.ViewModels
{
    public class SearchItemViewModel : BaseViewModel
    {

        public SearchItemViewModel()
        {
            Title = "Search";
        }

        public async Task<Item> SearchItem(string itemName)
        {
           return await DataStore.GetItemAsync(itemName);
        }
    }
}