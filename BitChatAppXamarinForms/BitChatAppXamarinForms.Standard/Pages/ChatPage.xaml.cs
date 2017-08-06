using BitChatAppXamarinForms.Model;
using System;
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

        private void SendButton_Clicked(object sender, System.EventArgs e)
        {
            TheChatBox.ChatProvider.SendMessage(new Message { FromProfile = ChatProvider.CurrentProfile, MessageDate = DateTime.Now, Text = TheEditor.Text });
            TheEditor.Text = string.Empty;
        }

        private void TheEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            SendButton.IsEnabled = TheEditor.Text != string.Empty;
        }
    }
}