using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEnqueue()
        {
            Queue qu = new Queue(5);
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            Assert.AreEqual(3, qu.Count());
        }
        [TestMethod]
        public void TestDequeue()
        {
            Queue qu1 = new Queue(5);
            qu1.Enqueue(1);
            qu1.Enqueue(2);
            qu1.Enqueue(3);
            Assert.AreEqual(2, qu1.Dequeue());
            Assert.AreEqual(3, qu1.Dequeue());
            Assert.AreEqual(1, qu1.Count());
        }
        [TestMethod]
        public void TestPeek()
        {
            Queue qu2 = new Queue(6);
            qu2.Enqueue(1);
            qu2.Enqueue(2);
            qu2.Enqueue(3);
            qu2.Enqueue(4);
            Assert.AreEqual(2, qu2.peek());
            Assert.AreEqual(3, qu2.peek());
            Assert.AreEqual(4, qu2.Count());
        }
    }
}
