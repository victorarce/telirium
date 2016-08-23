using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using System;
using Telirium.XFRenderers.iOS;
using Telirium.XFRenderers;
using UIKit;
using System.ComponentModel;
using CoreGraphics;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]

namespace Telirium.XFRenderers.iOS
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            SetControlStyle();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            SetControlStyle();
        }

        private void SetControlStyle()
        {
            if (Control != null)
            {
                var imgDropDownArrow = UIImage.FromFile("ddarrow.png");
                Control.RightViewMode = UITextFieldViewMode.Always;
                Control.RightView = new UIImageView(imgDropDownArrow);
            }
        }


    }
}