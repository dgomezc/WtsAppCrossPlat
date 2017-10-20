using System;
using Windows.UI.Xaml.Controls;
using WtsAppCrossPlat.Uwp.ViewModels;

namespace WtsAppCrossPlat.Uwp.Views
{
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame);
        }
    }
}
