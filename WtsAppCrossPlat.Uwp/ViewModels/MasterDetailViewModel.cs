using System.Threading.Tasks;
using WtsAppCrossPlat.Core.ViewModels;
using WtsAppCrossPlat.Uwp.Models;
using Windows.UI.Xaml.Controls;
using WtsAppCrossPlat.Core.Services;

namespace WtsAppCrossPlat.Uwp.ViewModels
{
    public class MasterDetailViewModel : MasterDetailViewModelBase<SampleOrderWithSymbol>
    {
        public override async Task LoadDataAsync()
        {
            SampleItems.Clear();

            var data = await SampleDataService.GetSampleModelDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(new SampleOrderWithSymbol(item));
            }
        }
    }
}
