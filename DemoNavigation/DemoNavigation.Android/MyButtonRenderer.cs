using System;
using Android.Content;
using DemoNavigation.MyControll;
using DemoNavigation;
using DemoNavigation.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Graphics;

[assembly: ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]

namespace DemoNavigation.Droid
{
    public class MyButtonRenderer : VisualElementRenderer<Frame>
    {
        public MyButtonRenderer(Context context) : base(context)
        {
        }

        //protected override void DispatchDraw(global::Android.Graphics.Canvas canvas)
        //{
        //    #region for Vertical Gradient
        //    //var gradient = new Android.Graphics.LinearGradient(0, 0, 0, Height,
        //    #endregion
        //    var gradient = new GradientDrawable(GradientDrawable.Orientation.TopBottom, new[] {
        //        Color.FromRgba(255, 255, 255, 255).ToAndroid().ToArgb(),
        //        Color.FromRgba(70, 70, 70, 50).ToAndroid().ToArgb() });
        //    base.SetBackgroundDrawable(gradient);
        //}
        
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            try
            {
                var btn = e.NewElement as MyButton;
                var gradient = new GradientDrawable(GradientDrawable.Orientation.LeftRight, new[] {
                    btn.StartColor.ToAndroid().ToArgb(),
                    btn.CenterColor.ToAndroid().ToArgb(),
                    btn.EndColor.ToAndroid().ToArgb()});
                base.SetBackgroundDrawable(gradient);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"          ERROR: ", ex.Message);
            }
        }
            
    }
}