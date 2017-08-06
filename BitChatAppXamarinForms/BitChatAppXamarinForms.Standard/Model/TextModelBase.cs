using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitChatAppXamarinForms.Model
{
    public class TextModelBase : ModelBase
    {
        private string _Text;

        public string Text
        {
            get => _Text;
            set
            {
                _Text = value;
                RaisePropertyChanged();
            }
        }
    }
}
