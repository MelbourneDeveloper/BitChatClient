using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace BitChatAppXamarinForms.Model
{
    public class DummyChatProvider : ObservableCollection<ITextModel>, IChatProvider
    {
        public Profile CurrentProfile { get; private set; }

        public DummyChatProvider(Profile currentProfile)
        {
            CurrentProfile = currentProfile;
        }

        public async Task LoadAllAsync()
        {
            Add(new Message { FromProfile = CurrentProfile, Text = "Test", MessageDate = DateTime.Now });
            Add(new Message { FromProfile = new Profile { EmailAddress = "test@test.com", ProfileName = "Test Guy" }, Text = "Test", MessageDate = DateTime.Now });
        }
    }
}
