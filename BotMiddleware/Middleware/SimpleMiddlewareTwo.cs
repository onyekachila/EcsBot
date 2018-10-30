using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace BotMiddleware.Middleware
{
    public class SimpleMiddlewareTwo : IMiddleware
    {
        public async Task OnTurnAsync(ITurnContext turnContext, NextDelegate next, CancellationToken cancellationToken = default(CancellationToken))
        {
            await turnContext.SendActivityAsync($"[SimpleMiddlewareTwo] {turnContext.Activity.Type}/OnTurn/Before");

            if (turnContext.Activity.Type == ActivityTypes.Message && turnContext.Activity.Text == "secret password")
            {
                // calling next() is totally optional. if the middleware does not call next then the
                // next middleware in the pipeline will not be called, AND the bot will not receive the message.
                //
                // in this instance, we are only handing the message to downstream bots if the user says "secret password"
                await next(cancellationToken);
            }

            await turnContext.SendActivityAsync($"[SimpleMiddlewareTwo] {turnContext.Activity.Type}/OnTurn/After");
        }
    }
}
