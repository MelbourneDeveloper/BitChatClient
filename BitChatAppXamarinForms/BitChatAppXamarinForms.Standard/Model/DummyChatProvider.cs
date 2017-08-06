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
            Add(new Message { FromProfile = CurrentProfile, Text = "Hi.", MessageDate = DateTime.Now });
            Add(new Message { FromProfile = new Profile { EmailAddress = "test@test.com", ProfileName = "Test Guy" }, Text = "Hi. How are you?", MessageDate = DateTime.Now });
            Add(new Message { FromProfile = CurrentProfile, Text = "I'm alright.", MessageDate = DateTime.Now });
            Add(new Message { FromProfile = CurrentProfile, Text = "I'm doing some coding.", MessageDate = DateTime.Now });
        }
    }
}
