// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace AddStateMiddleware
{
    internal class ConversationState<T> : IMiddleware
    {
        private MemoryStorage storage;

        public ConversationState(MemoryStorage storage)
        {
            this.storage = storage;
        }

        public Task OnTurnAsync(ITurnContext turnContext, NextDelegate next, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new System.NotImplementedException();
        }
    }
}