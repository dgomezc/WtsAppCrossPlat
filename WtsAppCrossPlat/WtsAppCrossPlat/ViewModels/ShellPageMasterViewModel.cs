using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WtsAppCrossPlat.Core.Helpers;
using WtsAppCrossPlat.Mobile.Views;

namespace WtsAppCrossPlat.Mobile.ViewModels
{
    public class ShellPageMasterViewModel : Observable
    {
        public ObservableCollection<ShellPageMenuItem> MenuItems { get; set; }

        public ShellPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<ShellPageMenuItem>(new[]
            {
                new ShellPageMenuItem { Id = 0, Title = "Blank", TargetType = typeof(BlankPage) },
                new ShellPageMenuItem { Id = 1, Title = "Web view page", TargetType = typeof(WebViewPage) }
            });
        }
    }
}
