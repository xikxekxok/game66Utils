using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using game66Utils.Actors;
using game66Utils.Messages;
using NUnit.Framework;

namespace game66Utils.Tests
{
    [TestFixture]
    public class ParseRowTests
    {
        private ActorSystem _system;
        private IActorRef _parser;

        [SetUp]
        public void Setup()
        {
            _system = ActorSystem.Create("MySystem");
            _parser = _system.ActorOf(Props.Create(() => new ParseInputRowActor()));
        }

        [TearDown]
        public async Task TearDown()
        {
            await _system.Terminate();
        }

        [Test]
        public async Task ParseRow_EmptyId_ReturnsNull()
        {
            var result = await _parser.Ask(new FileRow
            {
                Id = null,
                Price = "42"
            });

            Assert.IsNull(result);
        }

        [Test]
        public async Task ParseRow_EmptyPrice_ReturnsNull()
        {
            var result = await _parser.Ask(new FileRow
            {
                Id = "dsdfsdf",
                Price = ""
            });

            Assert.IsNull(result);
        }


        [Test]
        public async Task ParseRow_NoSeparatorPrice_Returns()
        {
            var result = await _parser.Ask(new FileRow
            {
                Id = "id",
                Price = "422"
            }) as PriceRow;

            Assert.NotNull(result);
            Assert.AreEqual("id", result.Id);
            Assert.Greater(0.001, Math.Abs(422 - result.Price));
        }

        [Test]
        public async Task ParseRow_DotSeparatorPrice_Returns()
        {
            var result = await _parser.Ask(new FileRow
            {
                Id = "id",
                Price = "422.25"
            }) as PriceRow;

            Assert.NotNull(result);
            Assert.AreEqual("id", result.Id);
            Assert.Greater(0.001, Math.Abs((decimal)422.25 - result.Price));
        }


        [Test]
        public async Task ParseRow_CommaSeparatorPrice_Returns()
        {
            var result = await _parser.Ask(new FileRow
            {
                Id = "id",
                Price = "422,25"
            }) as PriceRow;

            Assert.NotNull(result);
            Assert.AreEqual("id", result.Id);
            Assert.Greater(0.001, Math.Abs((decimal)422.25 - result.Price));
        }
    }
}
