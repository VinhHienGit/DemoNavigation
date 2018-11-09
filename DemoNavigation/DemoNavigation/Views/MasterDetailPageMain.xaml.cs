using DemoNavigation.Models;
using DemoNavigation.Views.Details;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageMain : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MasterDetailPageMain()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }

        public void NavigateDetailFromMenu(HomeMenuItem item)
        {
            if (item == null)
                return;
            Page p = (Page)Activator.CreateInstance(item.TargetType);
            Detail = new TabbedPage1();
            IsPresented = false;
        }
        public void NavigateMasterFromMenu(Page p)
        {
            if (p == null)
                return;
            Master.Navigation.PushAsync(p);
        }
    }
}