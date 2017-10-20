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
                    new ShellPageMenuItem { Id = 0, Title = "Page 1" },
                    new ShellPageMenuItem { Id = 1, Title = "Page 2" },
                    new ShellPageMenuItem { Id = 2, Title = "Page 3" },
                    new ShellPageMenuItem { Id = 3, Title = "Page 4" },
                    new ShellPageMenuItem { Id = 4, Title = "Page 5" },
                });
        }
    }
}
