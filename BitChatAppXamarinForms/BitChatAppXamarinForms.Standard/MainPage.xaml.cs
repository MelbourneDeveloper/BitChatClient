using Adapt.Presentation;
using BitChatAppXamarinForms.Controls;
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
            MainNavigationPage.PushAsync(new ContentPage { Content = new ChatBox() });
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}