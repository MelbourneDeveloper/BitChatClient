using BitChatAppXamarinForms.Model;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading.Tasks;

namespace BitChatAppXamarinForms.Model
{
    public interface IChatProvider : IEnumerable<ITextModel>, INotifyCollectionChanged
    {
        Task LoadAllAsync();
        Profile CurrentProfile { get; }
    }
}
