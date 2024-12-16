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
            ClassicAssert.AreEqual(20, arguments.DecimalPlaces);
            ClassicAssert.AreEqual(RunMode.Console, arguments.Mode);
            ClassicAssert.AreEqual("/pi.txt", arguments.OutputPath);
        }

        [Test]
        public void DecimalPlaces()
        {
            var arguments = Args.Parse<Arguments>(new string[] { "-dp", "10" });
            ClassicAssert.AreEqual(10, arguments.DecimalPlaces);
        }

        [Test]
        public void Unknown()
        {
            var arguments = Args.Parse<Arguments>(new string[] { "-unk", "own"});
            ClassicAssert.IsNotNull(arguments);
        }
    }
}