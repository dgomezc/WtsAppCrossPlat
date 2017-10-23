using WtsAppCrossPlat.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WtsAppCrossPlat.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();

            ViewModel.Initialize(webView);
            BindingContext = ViewModel;
        }

        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();
    }
}