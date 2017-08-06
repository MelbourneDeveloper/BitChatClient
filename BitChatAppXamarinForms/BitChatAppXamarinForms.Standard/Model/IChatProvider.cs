using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace BitChatAppXamarinForms.Model
{
    public interface IChatProvider : IEnumerable<ITextModel>, INotifyCollectionChanged
    {
        Task LoadAllAsync();
        Profile CurrentProfile { get; }
        void SendMessage(IMessage message);
    }
}
