using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xzing.ViewModels;
using ZXing;
using ZXing.Mobile;

namespace xzing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchItemPage : ContentPage
    {
        SearchItemViewModel _vm => BindingContext as SearchItemViewModel;
        MobileBarcodeScanner _scanner;

        public SearchItemPage()
        {
            InitializeComponent();
            BindingContext = new SearchItemViewModel();

            _scanner = new MobileBarcodeScanner();

            StartScanner();
        }

        private async void StartScanner()
        {
            var result = await _scanner.Scan();

            if (result != null)
            {
                var itemResult = await _vm.SearchItem(result.Text);
                await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(itemResult)));
            }
        }

        private void ScanResult(object sender, EventArgs args)
        {
            StartScanner();
        }
    }
}