using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using DemoInfermieri.CustomLayout;
using DemoInfermieri.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEditorCircle), typeof(CustomEditorRendererCircle))]
namespace DemoInfermieri.Droid.CustomRenderers
{
    class CustomEditorRendererCircle : EditorRenderer
    {
        public CustomEditorRendererCircle(Context context) : base(context)
    {
    }
    protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
    {
        base.OnElementChanged(e);
        if (e.NewElement != null)
        {
            var view = (CustomEditorCircle)Element;
            if (view.IsCurvedCornersEnabled)
            {
                // creating gradient drawable for the curved background  
                var _gradientBackground = new GradientDrawable();
                _gradientBackground.SetShape(ShapeType.Rectangle);
                //  _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());
                _gradientBackground.SetColor(Color.White.ToAndroid());

                // Thickness of the stroke line  
                _gradientBackground.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());

                // Radius for the curves  
                _gradientBackground.SetCornerRadius(
                    DpToPixels(this.Context, Convert.ToSingle(view.CornerRadius)));

                // set the background of the   
                Control.SetBackground(_gradientBackground);
            }
            // Set padding for the internal text from border  
            Control.SetPadding(
                (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingTop,
                (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingBottom);
        }
    }
    public static float DpToPixels(Context context, float valueInDp)
    {
        DisplayMetrics metrics = context.Resources.DisplayMetrics;
        return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
    }
}
}