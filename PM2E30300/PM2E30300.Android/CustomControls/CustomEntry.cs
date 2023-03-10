using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Proyecto_recordatorios.Droid;
using Proyecto_recordatorios.Droid.CustomControls;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntry))]
namespace Proyecto_recordatorios.Droid.CustomControls
{
    public class CustomEntry: MaterialEntryRenderer
    {
        public CustomEntry(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.EditText.Background = null;
                Control.EditText.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}