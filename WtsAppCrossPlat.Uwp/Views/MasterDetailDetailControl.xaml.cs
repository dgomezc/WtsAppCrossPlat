using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WtsAppCrossPlat.Uwp.Models;

namespace WtsAppCrossPlat.Uwp.Views
{
    public sealed partial class MasterDetailDetailControl : UserControl
    {
        public SampleOrderWithSymbol MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrderWithSymbol; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrderWithSymbol), typeof(MasterDetailDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public MasterDetailDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MasterDetailDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}