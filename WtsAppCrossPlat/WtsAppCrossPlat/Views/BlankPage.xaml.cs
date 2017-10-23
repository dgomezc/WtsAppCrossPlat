using WtsAppCrossPlat.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WtsAppCrossPlat.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlankPage : ContentPage
    {
        public BlankPage()
        {
            InitializeComponent();
            BindingContext = ViewModel;
        }

        public BlankViewModel ViewModel { get; } = new BlankViewModel();
    }
}