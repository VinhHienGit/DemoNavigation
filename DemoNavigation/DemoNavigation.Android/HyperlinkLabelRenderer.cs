using DemoNavigation.Droid;
using Android.Text.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using DemoNavigation.MyControll;

[assembly: ExportRenderer(typeof(HyperlinkLabel), typeof(HyperlinkLabelRenderer))]
namespace DemoNavigation.Droid
{
    public class HyperlinkLabelRenderer: LabelRenderer
    {
        public HyperlinkLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Linkify.AddLinks(Control, MatchOptions.All);

        }
    }
}