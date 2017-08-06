using System;

namespace BitChatAppXamarinForms.Model
{
    public class Message : ModelBase
    {
        private string _Text;
        private DateTime _MessageDate;

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
    }
}
