using NUnit;
using NUnit.Framework.Internal.Execution;

namespace ProjectPhone
{
    [TestFixture]
    public class Tests
    {
        //Можно ли запускать тесты асинхронно?
        [Test]
        public async Task CreateThreeNumbers() 
        {
            TestData td = new TestData();
            Program.Generate(td, 3);
            Assert.That(td.phones.Count, Is.EqualTo(3));
        }

        [Test]
        public async Task CreateZeroNumbers() 
        {
            TestData td = new TestData();
            Program.Generate(td, 0);
            Assert.That(td.phones.Count, Is.EqualTo(0));
        }

        [Test]
        public async Task EnterNegativeCountNumber() 
        {
            TestData td = new TestData();
            Program.Generate(td, -1);
            Assert.That(td.phones.Count, Is.EqualTo(0));
        }
    }
}
