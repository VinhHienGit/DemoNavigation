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
	public partial class TabbedPageItem1 : ContentPage
	{
		public TabbedPageItem1 ()
		{
			InitializeComponent ();
		}

        private void btnNextPage_Clicked(object sender, EventArgs e)
        {
            Content.Navigation.PushAsync(new NextPage());
        }
    }
}