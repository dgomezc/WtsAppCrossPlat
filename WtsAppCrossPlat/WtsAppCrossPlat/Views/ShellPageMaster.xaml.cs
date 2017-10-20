using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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