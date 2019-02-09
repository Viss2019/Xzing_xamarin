using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace xzing.ViewModels
{
    public class SearchItemViewModel : BaseViewModel
    {
        public SearchItemViewModel()
        {
            Title = "Search";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}