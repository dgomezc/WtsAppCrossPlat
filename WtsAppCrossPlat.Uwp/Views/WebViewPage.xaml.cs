using Windows.UI.Xaml.Controls;
using WtsAppCrossPlat.Uwp.ViewModels;

namespace WtsAppCrossPlat.Uwp.Views
{
    public sealed partial class WebViewPage : Page
    {
        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
