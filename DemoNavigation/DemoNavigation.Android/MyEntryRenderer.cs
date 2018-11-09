using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using DemoNavigation.Droid;
using DemoNavigation.MyControll;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]


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
            var element = (MyEntry)Element;
            if (Control == null || element == null || e.OldElement != null) return;
            if(element.LineColor == Color.Transparent)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                //this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                //Control.SetHintTextColor(ColorStateList.ValueOf(element.TextColor.ToAndroid()));
            }
            else
            {
                var ourcustomcolorhere = element.LineColor.ToAndroid();
                Control.Background.SetColorFilter(ourcustomcolorhere, PorterDuff.Mode.SrcAtop);
            }
        }
    }
}