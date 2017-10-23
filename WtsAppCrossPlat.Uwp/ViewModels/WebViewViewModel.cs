using System;
using System.Windows.Input;

using WtsAppCrossPlat.Core.Helpers;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WtsAppCrossPlat.Core.ViewModels;

namespace WtsAppCrossPlat.Uwp.ViewModels
{
    public class WebViewViewModel : WebViewViewModelBase
    {
        private Uri _source;

        public Uri Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        private bool _isLoading;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }

            set
            {
                if (value)
                {
                    IsShowingFailedMessage = false;
                }

                Set(ref _isLoading, value);
                IsLoadingVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private Visibility _isLoadingVisibility;

        public Visibility IsLoadingVisibility
        {
            get { return _isLoadingVisibility; }
            set { Set(ref _isLoadingVisibility, value); }
        }

        private bool _isShowingFailedMessage;

        public bool IsShowingFailedMessage
        {
            get
            {
                return _isShowingFailedMessage;
            }

            set
            {
                if (value)
                {
                    IsLoading = false;
                }

                Set(ref _isShowingFailedMessage, value);
                FailedMesageVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private Visibility _failedMesageVisibility;

        public Visibility FailedMesageVisibility
        {
            get { return _failedMesageVisibility; }
            set { Set(ref _failedMesageVisibility, value); }
        }

        private ICommand _navCompleted;

        public ICommand NavCompletedCommand
        {
            get
            {
                if (_navCompleted == null)
                {
                    _navCompleted = new RelayCommand<WebViewNavigationCompletedEventArgs>(NavCompleted);
                }

                return _navCompleted;
            }
        }

        private void NavCompleted(WebViewNavigationCompletedEventArgs e)
        {
            IsLoading = false;
            OnPropertyChanged(nameof(GoBack));
            OnPropertyChanged(nameof(GoForward));
        }

        private ICommand _navFailed;

        public ICommand NavFailedCommand
        {
            get
            {
                if (_navFailed == null)
                {
                    _navFailed = new RelayCommand<WebViewNavigationFailedEventArgs>(NavFailed);
                }

                return _navFailed;
            }
        }

        private void NavFailed(WebViewNavigationFailedEventArgs e)
        {
            // Use `e.WebErrorStatus` to vary the displayed message based on the error reason
            IsShowingFailedMessage = true;
        }

        private ICommand _retryCommand;

        public ICommand RetryCommand
        {
            get
            {
                if (_retryCommand == null)
                {
                    _retryCommand = new RelayCommand(Retry);
                }

                return _retryCommand;
            }
        }

        private void Retry()
        {
            IsShowingFailedMessage = false;
            IsLoading = true;

            _webView?.Refresh();
        }        

        private WebView _webView;

        public WebViewViewModel()
        {
            IsLoading = true;
            Source = new Uri(DefaultUrl);

            InitializeCommands();
        }

        public void Initialize(WebView webView)
        {
            _webView = webView;
        }

        private void InitializeCommands()
        {
            GoForward = new RelayCommand(
                canExecute: () => _webView?.CanGoForward ?? false,
                execute: () => _webView?.GoForward()
                );

            GoBack = new RelayCommand(
                canExecute: () => _webView?.CanGoBack ?? false,
                execute: () => _webView?.GoBack()
                );

            Refresh = new RelayCommand(
                execute: () => _webView?.Refresh());

            OpenInBrowser = new RelayCommand(
                async () => await Windows.System.Launcher.LaunchUriAsync(Source));
        }
    }
}
