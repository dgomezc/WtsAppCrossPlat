using System;
using WtsAppCrossPlat.Core.ViewModels;
using Xamarin.Forms;

namespace WtsAppCrossPlat.Mobile.ViewModels
{
    public class WebViewViewModel : WebViewViewModelBase
    {
        private WebView _webView;
        private WebViewSource _source;
        private bool _canGoBack, _canGoForward;

        public WebViewViewModel()
        {
            Source = new UrlWebViewSource
            {
                Url = DefaultUrl
            };

            GoBack = new Command(
                canExecute: () => CanGoBack,
                execute: () => _webView?.GoBack());

            GoForward = new Command(
                canExecute: () => CanGoForward,
                execute: () => _webView?.GoForward());

            Refresh = new Command(
                execute: () => _webView.Source = (_webView.Source as UrlWebViewSource).Url);

            OpenInBrowser = new Command(
                execute: () => Device.OpenUri(new Uri(DefaultUrl)));
           
        }

        public WebViewSource Source
        {
            set
            {
                Set(ref _source, value);
            }
            get
            {
                return _source;
            }
        }

        public bool CanGoBack
        {
            set
            {
                if (Set(ref _canGoBack, value))
                {
                    (GoBack as Command).ChangeCanExecute();
                }
            }
            get
            {
                return _canGoBack;
            }
        }

        public bool CanGoForward
        {
            set
            {
                if (Set(ref _canGoForward, value))
                {
                    (GoForward as Command).ChangeCanExecute();
                }
            }
            get
            {
                return _canGoForward;
            }
        }

        public void Initialize(WebView webView)
        {
            _webView = webView;
        }
    }
}
