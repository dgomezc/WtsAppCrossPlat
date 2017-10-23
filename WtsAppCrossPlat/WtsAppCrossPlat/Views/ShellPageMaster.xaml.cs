using WtsAppCrossPlat.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WtsAppCrossPlat.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellPageMaster : ContentPage
    {
        public ListView ListView;

        public ShellPageMaster()
        {
            InitializeComponent();

            BindingContext = new ShellPageMasterViewModel();
            ListView = MenuItemsListView;
        }       
    }
}