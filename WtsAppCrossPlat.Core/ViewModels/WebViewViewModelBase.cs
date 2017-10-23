using System.Windows.Input;
using WtsAppCrossPlat.Core.Helpers;

namespace WtsAppCrossPlat.Core.ViewModels
{
    public abstract class WebViewViewModelBase : Observable
    {
        protected const string DefaultUrl = "https://developer.microsoft.com/en-us/windows/apps";

        public ICommand GoBack { protected set; get; }
        public ICommand GoForward { protected set; get; }
        public ICommand Refresh { protected set; get; }
        public ICommand OpenInBrowser { get; protected set; }
    }
}