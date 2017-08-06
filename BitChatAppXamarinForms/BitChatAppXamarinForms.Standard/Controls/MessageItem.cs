using BitChatAppXamarinForms.Model;
using Xamarin.Forms;

namespace BitChatAppXamarinForms.Controls
{
    public class MessageItem : StackLayout
    {
        public static Color BitChatBlue = Color.FromRgb(102, 153, 253);

        private Label _ProfileLabel;

        public MessageItem()
        {
            Orientation = StackOrientation.Vertical;

            _ProfileLabel = new Label();
            _ProfileLabel.SetBinding(Label.TextProperty, new Binding("FromProfile.ProfileName"));
        }
    }
}
