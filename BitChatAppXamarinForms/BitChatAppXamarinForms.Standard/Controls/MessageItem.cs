using BitChatAppXamarinForms.Model;
using Xamarin.Forms;

namespace BitChatAppXamarinForms.Controls
{
    public class MessageItem : StackLayout
    {
        public static Color BitChatBlue = Color.FromRgb(102, 153, 253);

        private Label _ProfileLabel;
        private Label _TextLabel;
        private Label _DateTimeLabel;

        public MessageItem()
        {
            BackgroundColor = Color.White;

            Margin = new Thickness(4);

            Orientation = StackOrientation.Vertical;

            _ProfileLabel = new Label();
            _ProfileLabel.SetBinding(Label.TextProperty, new Binding("FromProfile.ProfileName"));
            _ProfileLabel.TextColor = BitChatBlue;
            _ProfileLabel.HorizontalTextAlignment = TextAlignment.Start;
            Children.Add(_ProfileLabel);

            _TextLabel = new Label();
            _TextLabel.SetBinding(Label.TextProperty, new Binding(nameof(Message.Text)));
            _TextLabel.HorizontalTextAlignment = TextAlignment.Start;
            _TextLabel.MinimumWidthRequest = 300;
            Children.Add(_TextLabel);

            _DateTimeLabel = new Label();
            _DateTimeLabel.SetBinding(Label.TextProperty, new Binding(nameof(Message.MessageDate)));
            _DateTimeLabel.HorizontalTextAlignment = TextAlignment.End;
            Children.Add(_DateTimeLabel);
        }
    }
}
