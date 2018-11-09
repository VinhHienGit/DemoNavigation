using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigation.Views.TabbedPageItems
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedPageItem3 : ContentPage
	{
		public TabbedPageItem3 ()
		{
			InitializeComponent ();
		}

        private void btnNextPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NextPage());
        }
    }
}