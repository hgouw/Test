
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests
{
    [TestClass()]
    public class StakTests
    {
        private Stak stak;

        [TestInitialize()]
        public void InitialTest()
        {
            stak = new Stak();
            Assert.IsTrue(stak.IsEmpty);
        }

        [TestMethod()]
        public void PopTest()
        {
            stak.Push(new object());
            var item = stak.Pop();
            Assert.IsTrue(item != null);
        }

        [TestMethod()]
        public void PushTest()
        {
            stak.Push(new object());
            Assert.IsFalse(stak.IsEmpty);
        }
    }
}