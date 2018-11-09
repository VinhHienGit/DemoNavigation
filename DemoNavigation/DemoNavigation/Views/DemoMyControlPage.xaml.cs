using Android.Content;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoMyControlPage : ContentPage
    {
        public DemoMyControlPage()
        {
            InitializeComponent();
        }

        private void MyButton1_Clicked(object sender, EventArgs e)
        {
            label1.Text = "clicked";
            Random rd = new Random();
            label1.TextColor = Color.FromRgb(rd.Next(255), rd.Next(255), rd.Next(255));
        }
    }
}