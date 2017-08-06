using System;

namespace BitChatAppXamarinForms.Model
{
    public class Message : TextModelBase, IMessage
    {
        private DateTime _MessageDate;
        private Profile _FromProfile;

        public DateTime MessageDate
        {
            get => _MessageDate; set
            {
                _MessageDate = value;
                RaisePropertyChanged();
            }
        }

        public Profile FromProfile
        {
            get => _FromProfile;
            set
            {
                _FromProfile = value;
                RaisePropertyChanged();
            }
        }
    }
}
