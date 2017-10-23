using Microsoft.Toolkit.Uwp.UI.Controls;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WtsAppCrossPlat.Uwp.ViewModels;

namespace WtsAppCrossPlat.Uwp.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        public MasterDetailViewModel ViewModel { get; } = new MasterDetailViewModel();

        public MasterDetailPage()
        {
            InitializeComponent();
            Loaded += MasterDetailPage_Loaded;
        }

        private async void MasterDetailPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync();

            if (MasterDetailsViewControl.ViewState == MasterDetailsViewState.Both)
            {
                ViewModel.SelectedItem = ViewModel.SampleItems.First();
            }
        }
    }
}
