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

[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRendered))]
namespace Proyecto_recordatorios.Droid
{
    public class CustomLabelRendered : LabelRenderer
    {
        public CustomLabelRendered(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.SetTextIsSelectable(true);//EDITAR LABELS
        }
    }
}