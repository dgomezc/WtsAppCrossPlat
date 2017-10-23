using System;
using System.Linq;
using WtsAppCrossPlat.Core.Models;
using WtsAppCrossPlat.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WtsAppCrossPlat.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailPage : ContentPage
	{
		public MasterDetailPage ()
		{
			InitializeComponent ();
            Appearing += MasterDetailPage_Appearing;
            BindingContext = ViewModel;
        }

        private async void MasterDetailPage_Appearing(object sender, EventArgs e)
        {
            await ViewModel.LoadDataAsync();
            ViewModel.SelectedItem = ViewModel.SampleItems.First();
        }

        public MasterDetailViewModelBase<SampleOrder> ViewModel { get; } = new MasterDetailViewModelBase<SampleOrder>();
    }
}