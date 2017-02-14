using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.TestKit.NUnit;
using game66Utils.Actors;
using game66Utils.Actors.Parse;
using game66Utils.Models;
using NUnit.Framework;

namespace game66Utils.Tests
{
    [TestFixture]
    public class ParseFileTests
    {
        private ActorSystem _system;
        private IActorRef _fake;
        private IActorRef _parser;

        [SetUp]
        public void Setup()
        {
            _system = ActorSystem.Create("MySystem");
            _fake = _system.ActorOf(Props.Create(() => new FakeActor()));
           var rowParser = _system.ActorOf(Props.Create<FakeRowParser>());
            _parser = _system.ActorOf(Props.Create(() => new ParseInputFileActor(_fake, rowParser)));
        }

        [TearDown]
        public async Task TearDown()
        {
            await _system.Terminate();
        }

        private async Task<List<object>> GetFakeMessage()
        {
            var response= await _fake.Ask(new FakeActor.GetStackMessage()) as List<object>;

            return response;
        }


        [Test]
        public async Task ParseInputFile_ExistingEmptyFile_TellCorrectType()
        {
            var message = new UserInputMessage
            {
                FileUrl = System.AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\TestData\\empty.xlsx",
                PriceColumn = "A",
                TitleColumn = "B"
            };

            var parserResponse = await _parser.Ask(message);
            Assert.NotNull((parserResponse) as CompletedMessage, parserResponse.ToString());

            var response = await GetFakeMessage();

            Assert.AreEqual(1, response.Count);
            var result = response[0] as List<PriceRow>;
            Assert.NotNull(result);
            Assert.AreEqual(0, result.Count);
            
        }

        [Test]
        public async Task ParseInputFile_NotExistingFile_TellCorrectType()
        {
            var message = new UserInputMessage
            {
                FileUrl = System.AppDomain.CurrentDomain.BaseDirectory+"\\badFile.xlsx",
                PriceColumn = "A",
                TitleColumn = "B"
            };

            var response = await _parser.Ask(message);
            Assert.NotNull((response as Failure)?.Exception, response.ToString());

            var result = await GetFakeMessage();

            Assert.AreEqual(0, result.Count);

        }


        [Test]
        public async Task ParseInputFile_ExistingNonEmptyFile_TellCorrectList()
        {
            var message = new UserInputMessage
            {
                FileUrl = System.AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\TestData\\test.xlsx",
                PriceColumn = "C",
                TitleColumn = "A"
            };

            var parserResponse = await _parser.Ask(message);
            Assert.NotNull((parserResponse) as CompletedMessage, parserResponse.ToString());

            var response = await GetFakeMessage();

            Assert.AreEqual(1, response.Count);
            var result = response[0] as List<PriceRow>;
            Assert.NotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Any(x=>string.Equals("id1", x.Id, StringComparison.InvariantCultureIgnoreCase)));
            Assert.IsTrue(result.Any(x=>string.Equals("id3", x.Id, StringComparison.InvariantCultureIgnoreCase)));

        }
    }
}
