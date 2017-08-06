
using samples = Adapt.PresentationSamples;
using Adapt.Presentation.UWP;

namespace XamForms.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            Adapt.PresentationSamples.MainPage.Permissions = new Permissions();

            var app = new samples.App();

            LoadApplication(app);
        }
    }
}
