using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoNavigation.MyControll;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace DemoNavigation.Droid
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null || e.OldElement != null) return;

            var element = (MyEntry)Element;
            var ourCustomColorHere = element.LineColor.ToAndroid();
            Control.Background.SetColorFilter(ourCustomColorHere, PorterDuff.Mode.SrcAtop);
        }
    }
}