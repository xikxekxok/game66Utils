using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Util;
using game66Utils.Actors;
using game66Utils.Messages;

namespace game66Utils.Tests
{
    public class FakeActor : UntypedActor
    {
        private List<object> _messages;

        protected override void PreStart()
        {
            _messages = new List<object>();
        }

        protected override void OnReceive(object message)
        {
            if (message is GetStackMessage)
            {
                Sender.Tell(_messages);
            }
            else
                _messages.Add(message);
        }

        public class GetStackMessage
        {
            
        }
    }

    public class FakeResponseActor : UntypedActor
    {
        private readonly object _response;

        public FakeResponseActor(object response)
        {
            _response = response;
        }
        protected override void OnReceive(object message)
        {
            Sender.Tell(_response);
        }
    }

    public class FakeRowParser : OneTypeReceiveActor<FileRow, PriceRow>
    {
        protected override async Task<PriceRow> Handle(FileRow message) => 
            string.IsNullOrEmpty(message?.Id) 
                ? null
                : new PriceRow { Id = message.Id, Price = 0 };
    }
}