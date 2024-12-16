using NUnit.Framework;
using PowerArgs;

namespace Pi.Runtime.Tests
{
    [TestFixture]
    public class ArgumentsTests
    {
        [Test]
        public void Defaults()
        {
            var arguments = Args.Parse<Arguments>(new string[0]);
            Assert.That(20, Is.EqualTo(arguments.DecimalPlaces));
            Assert.That(RunMode.Console, Is.EqualTo(arguments.Mode));
            Assert.That("/pi.txt", Is.EqualTo(arguments.OutputPath));
        }

        [Test]
        public void DecimalPlaces()
        {
            var arguments = Args.Parse<Arguments>(new string[] { "-dp", "10" });
            Assert.That(10, Is.EqualTo(arguments.DecimalPlaces));

        }


        [Test]
        public void Unknown()
        {
            var arguments = Args.Parse<Arguments>(new string[] { "-unk", "own"});
            ClassicAssert.IsNotNull(arguments);
        }
    }
}