using System;
using System.Threading.Tasks;
using Akka.Actor;
using game66Utils.Messages;

namespace game66Utils.Actors
{
    public abstract class OneTypeReceiveActor<TInput> : ReceiveActor
    {
        protected OneTypeReceiveActor()
        {
            ReceiveAsync<TInput>(async x => await HandlePrivate(x));
            // ReSharper disable once ObjectCreationAsStatement
            ReceiveAny(x => Sender.Tell(new Failure { Exception = new ArgumentException($"Unknown message type {x.GetType().Name}") }, Self));
        }

        private async Task HandlePrivate(TInput message)
        {
            try
            {
                await Handle(message);
                Sender.Tell(new CompletedMessage(), Self);
            }
            catch (Exception e)
            {
                Sender.Tell(new Failure {Exception = e}, Self);
            }
        }

        protected abstract Task Handle(TInput message);

    }

    public abstract class OneTypeReceiveActor<TInput, TOutput> : ReceiveActor
    {
        protected OneTypeReceiveActor()
        {
            ReceiveAsync<TInput>(async x => await HandlePrivate(x));
            // ReSharper disable once ObjectCreationAsStatement
            ReceiveAny(x => Sender.Tell(new Failure { Exception = new ArgumentException($"Unknown message type {x.GetType().Name}") }, Self));
        }

        private async Task HandlePrivate(TInput message)
        {
            try
            {
                var result = await Handle(message);
                Sender.Tell(result, Self);
            }
            catch (Exception e)
            {
                Sender.Tell(new Failure { Exception = e }, Self);
            }
        }

        protected abstract Task<TOutput> Handle(TInput message);
    }
}