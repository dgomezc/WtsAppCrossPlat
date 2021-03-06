﻿using System;
using WtsAppCrossPlat.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WtsAppCrossPlat.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellPage : Xamarin.Forms.MasterDetailPage
    {
        public ShellPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ShellPageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}