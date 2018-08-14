using Xamarin.Forms;

namespace UnderlinedLabel.Controls
{
    public class Label : Xamarin.Forms.Label
    {
        public Label()
        {
            FontSize = 30;
            TextColor = Color.Purple;
        }

        public static readonly BindableProperty IsUnderlinedProperty = BindableProperty.Create("IsUnderlined", typeof(bool), typeof(Label), false);

        public bool IsUnderlined
        {
            get { return (bool)GetValue(IsUnderlinedProperty); }
            set { SetValue(IsUnderlinedProperty, value); }
        }
    }
}