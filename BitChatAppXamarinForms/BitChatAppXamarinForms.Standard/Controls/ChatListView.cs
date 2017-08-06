using Xamarin.Forms;

namespace BitChatAppXamarinForms.Controls
{
    public class ChatListView : ListView
    {
        private Color BitChatBackgroundColour = Color.FromRgb(224, 224, 224);

        public ChatListView()
        {
            BackgroundColor = BitChatBackgroundColour;
        }
    }
}
