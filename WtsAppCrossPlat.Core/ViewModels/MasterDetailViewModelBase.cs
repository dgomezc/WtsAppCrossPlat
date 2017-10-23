using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WtsAppCrossPlat.Core.Helpers;
using WtsAppCrossPlat.Core.Models;
using WtsAppCrossPlat.Core.Services;

namespace WtsAppCrossPlat.Core.ViewModels
{
    public class MasterDetailViewModelBase<T> : Observable
        where T : SampleOrder
    {
        private T _selectedItem;

        public MasterDetailViewModelBase()
        {
        }
        public ObservableCollection<T> SampleItems { get; private set; } = new ObservableCollection<T>();

        public T SelectedItem
        {
            set
            {
                Set(ref _selectedItem, value);
            }
            get
            {
                return _selectedItem;
            }
        }

        public virtual async Task LoadDataAsync()
        {
            SampleItems.Clear();

            var data = await SampleDataService.GetSampleModelDataAsync();

            foreach (T item in data)
            {
                SampleItems.Add(item);
            }
        }
    }
}
