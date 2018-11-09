using DemoNavigation.Models;
using DemoNavigation.Views.Details;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageMaster : ContentPage
    {
        MasterDetailPageMain RootPage { get => Application.Current.MainPage as MasterDetailPageMain; }
        List<HomeMenuItem> menuItems;
        public MasterDetailPageMaster()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = 0, Title="TabbedPage 1", TargetType = typeof(TabbedPage1) },
                new HomeMenuItem {Id = 1, Title="TabbedPage 2", TargetType = typeof(TabbedPage1) }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;
                var item = e.SelectedItem as HomeMenuItem;
                RootPage.NavigateDetailFromMenu(item);
            };
        }

        private void BtnGotoAbout_Clicked(object sender, EventArgs e)
        {
            RootPage.NavigateMasterFromMenu(new AboutPage());
        }
    }
}