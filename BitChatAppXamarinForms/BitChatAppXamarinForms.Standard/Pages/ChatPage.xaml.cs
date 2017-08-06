using BitChatAppXamarinForms.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BitChatAppXamarinForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        public IChatProvider ChatProvider
        {
            get
            {
                return TheChatBox.ChatProvider;
            }
            set
            {
                TheChatBox.ChatProvider = value;
            }
        }

        public ChatPage()
        {
            InitializeComponent();
        }
    }
}