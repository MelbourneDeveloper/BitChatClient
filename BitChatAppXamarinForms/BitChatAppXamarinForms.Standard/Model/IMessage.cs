using System;

namespace BitChatAppXamarinForms.Model
{
    public interface IMessage : ITextModel
    {
        Profile FromProfile { get; set; }
        DateTime MessageDate { get; set; }
    }
}