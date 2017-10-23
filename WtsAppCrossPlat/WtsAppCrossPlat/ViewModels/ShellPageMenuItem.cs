using System;
using WtsAppCrossPlat.Mobile.Views;

namespace WtsAppCrossPlat.Mobile.ViewModels
{
    public class ShellPageMenuItem
    {
        public ShellPageMenuItem()
        {
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}