using Adapt.Presentation;
using BitChatAppXamarinForms.Model;
using BitChatAppXamarinForms.Pages;
using Xamarin.Forms.Xaml;

namespace Adapt.PresentationSamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage
    {
        public static IPermissions Permissions;

        public MainPage()
        {
            InitializeComponent();

            var currentProfile = new Profile { EmailAddress = "Christian_findlay@hotmail.com", ProfileName = "Christian Findlay" };

            var chatPage = new ChatPage();
            chatPage.ChatProvider = new DummyChatProvider(currentProfile);

            MainNavigationPage.PushAsync(chatPage);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}