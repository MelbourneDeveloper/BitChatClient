namespace BitChatAppXamarinForms.Model
{
    public class Profile : ModelBase
    {
        private string _ProfileName;
        private string _EmailAddress;

        public string ProfileName
        {
            get => _ProfileName;
            set
            {
                _ProfileName = value;
                RaisePropertyChanged();
            }
        }

        public string EmailAddress
        {
            get => _EmailAddress; set
            {
                _EmailAddress = value;
                RaisePropertyChanged();
            }
        }
    }
}
