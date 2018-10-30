using System;
using Microsoft.Bot.Builder;

namespace AddStateMiddleware
{
    public class BotAccessors
    {
        public BotAccessors(ConversationState conversationState)
        {
            ConversationState = conversationState ?? throw new ArgumentNullException(nameof(conversationState));
        }

        public static string DemoStateName { get; } = $"{nameof(BotAccessors)}.DemoStateAccessor";

        public IStatePropertyAccessor<DemoState> DemoStateAccessor { get; set; }
        public ConversationState ConversationState { get; }
    }
}
