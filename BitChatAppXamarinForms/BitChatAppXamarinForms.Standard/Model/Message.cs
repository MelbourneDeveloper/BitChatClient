using System;

namespace BitChatAppXamarinForms.Model
{
    public class Message : ModelBase
    {
        private string _Text;
        private DateTime _MessageDate;
        private Profile _FromProfile;

        public string Text
        {
            get => _Text;
            set
            {
                _Text = value;
                RaisePropertyChanged();
            }
        }

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
