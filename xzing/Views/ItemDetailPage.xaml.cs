using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using xzing.Models;
using xzing.ViewModels;

namespace xzing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Name = "Item 1",
                

            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}