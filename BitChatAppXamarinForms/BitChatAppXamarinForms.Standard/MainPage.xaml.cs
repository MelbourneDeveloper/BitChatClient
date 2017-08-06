using Adapt.Presentation;
using BitChatAppXamarinForms.Controls;
using BitChatAppXamarinForms.Model;
using Xamarin.Forms;
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

            MainNavigationPage.PushAsync(new ContentPage { Content = new ChatBox { ChatProvider = new DummyChatProvider(currentProfile) } });
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}