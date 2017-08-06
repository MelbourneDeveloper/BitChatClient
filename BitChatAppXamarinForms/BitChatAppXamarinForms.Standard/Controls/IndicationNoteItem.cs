using Xamarin.Forms;

namespace BitChatAppXamarinForms.Controls
{
    public class IndicationNoteItem : Label
    {
        public static Color IndicationColour = Color.FromRgb(240, 255, 255);

        public IndicationNoteItem()
        {
            BackgroundColor = IndicationColour;
            SetBinding(TextProperty, new Binding("Text"));
            HorizontalOptions = LayoutOptions.Center;
        }
    }
}
