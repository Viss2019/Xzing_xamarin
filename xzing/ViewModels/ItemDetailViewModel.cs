using System;

using xzing.Models;

namespace xzing.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Name;
            Item = item;
        }
    }
}
