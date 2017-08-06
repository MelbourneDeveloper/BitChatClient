using BitChatAppXamarinForms.Model;
using System;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BitChatAppXamarinForms.Controls
{
    public class ChatBox : ScrollView
    {
        public static BindableProperty ChatProviderProperty = BindableProperty.Create("ChatProvider", typeof(IChatProvider), typeof(ChatBox));
        public static Color BitChatBackgroundColour = Color.FromRgb(224, 224, 224);

        private StackLayout _MainLayout = new StackLayout { Orientation = StackOrientation.Horizontal };
        private IChatProvider _ChatProvider;

        public IChatProvider ChatProvider
        {
            get => _ChatProvider;

            set
            {
                _ChatProvider = value;
                _ChatProvider.CollectionChanged += _ChatProvider_CollectionChanged;

                //TODO: Kick off refresh here?
                _ChatProvider.LoadAllAsync();
            }
        }

        private async void _ChatProvider_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            await RefreshAsync();
        }

        public ChatBox()
        {
            BackgroundColor = BitChatBackgroundColour;
            Content = _MainLayout;
        }

        private async Task RefreshAsync()
        {
            _MainLayout.Children.Clear();

            if (_ChatProvider == null)
            {
                return;
            }

            foreach (var item in _ChatProvider)
            {
                var message = item as Message;
                var indicationNote = item as IndicationNote;

                if (message == null && indicationNote == null)
                {
                    throw new Exception($"Item type {item.GetType()} not supported");
                }

                if (message != null)
                {
                    ProcessMessage(message);
                }
            }
        }

        private void ProcessMessage(Message message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var messageItem = new MessageItem()
                {
                    BindingContext = message,
                    HorizontalOptions = message.FromProfile.Equals(ChatProvider.CurrentProfile) ? LayoutOptions.End : LayoutOptions.Start
                };
                _MainLayout.Children.Add(messageItem);
            });
        }
    }
}
