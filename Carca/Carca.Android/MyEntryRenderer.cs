using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Carca;
using Carca.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(MyEntry),typeof(MyEntryRenderer))]
namespace Carca.Droid
{
    class MyEntryRenderer:EntryRenderer
    { 
        public MyEntryRenderer(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                

                var gradientDrawable = new GradientDrawable();

                gradientDrawable.SetCornerRadius(60f);
                gradientDrawable.SetStroke(3, Android.Graphics.Color.LightGray);

                Control.SetBackground(gradientDrawable);
            }
        }
    }
}