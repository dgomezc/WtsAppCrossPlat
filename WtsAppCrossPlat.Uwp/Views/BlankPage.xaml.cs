using Windows.UI.Xaml.Controls;
using WtsAppCrossPlat.Core.ViewModels;

namespace WtsAppCrossPlat.Uwp.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankViewModel ViewModel { get; } = new BlankViewModel();

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
