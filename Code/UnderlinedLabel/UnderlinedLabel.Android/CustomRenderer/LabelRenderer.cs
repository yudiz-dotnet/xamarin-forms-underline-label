using Android.Content;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(UnderlinedLabel.Controls.Label), typeof(UnderlinedLabel.Droid.CustomRenderer.LabelRenderer))]
namespace UnderlinedLabel.Droid.CustomRenderer
{
    public class LabelRenderer : Xamarin.Forms.Platform.Android.LabelRenderer
    {
        public LabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if(Control!=null)
            {
                if (((UnderlinedLabel.Controls.Label)Element).IsUnderlined) 
                {
                    Control.PaintFlags = PaintFlags.UnderlineText; // This will add underline to the label
                }
            }
        }
    }
}