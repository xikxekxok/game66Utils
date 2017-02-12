using System.Threading.Tasks;
using Akka.Actor;
using game66Utils.Actors;
using NUnit.Framework;

namespace game66Utils.Tests
{
    public class ComparePricesTests
    {
        private ActorSystem _system;
        private IActorRef _fake;
        private IActorRef _comparator;

        [SetUp]
        public void Setup()
        {
            _system = ActorSystem.Create("MySystem");
            _fake = _system.ActorOf(Props.Create(() => new FakeActor()));
            _comparator = _system.ActorOf(Props.Create(() => new ComparePricesActor(_fake)));
        }

        [TearDown]
        public async Task TearDown()
        {
            await _system.Terminate();
        }

        [Test]
        public void 
    }
}