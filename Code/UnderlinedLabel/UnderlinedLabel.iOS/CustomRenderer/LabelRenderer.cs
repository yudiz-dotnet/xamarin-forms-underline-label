using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(UnderlinedLabel.Controls.Label), typeof(UnderlinedLabel.iOS.CustomRenderer.LabelRenderer))]
namespace UnderlinedLabel.iOS.CustomRenderer
{
    public class LabelRenderer : Xamarin.Forms.Platform.iOS.LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if(Control!=null)
            {
                if (((UnderlinedLabel.Controls.Label)Element).IsUnderlined)
                {
                    var extendedElement = (UnderlinedLabel.Controls.Label)Element;
                    Control.AttributedText = new NSMutableAttributedString(extendedElement.Text, Control.Font, underlineStyle: NSUnderlineStyle.Single);
                }
            }
        }
    }
}