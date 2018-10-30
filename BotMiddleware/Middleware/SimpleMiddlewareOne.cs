using Microsoft.Bot.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BotMiddleware.Middleware
{
    public class SimpleMiddlewareOne : IMiddleware
    {
        public async Task OnTurnAsync(ITurnContext turnContext, NextDelegate next, CancellationToken cancellationToken = default(CancellationToken))
        {
            await turnContext.SendActivityAsync($"[SimpleMiddlewareOne] {turnContext.Activity.Type}/OnTurn/Before");

            await next(cancellationToken);

            await turnContext.SendActivityAsync($"[SimpleMiddlewareOne] {turnContext.Activity.Type}/OnTurn/After");
        }
    }
}
