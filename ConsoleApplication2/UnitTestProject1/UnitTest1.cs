using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testpush()
        {
            Stack st = new Stack(5);
            st.push(1);
            st.push(2);
            st.push(3);
            Assert.AreEqual(3, st.count());
        }
        [TestMethod]
        public void testPop()
        {
            //push and pop

            Stack st = new Stack(4);
            st.push(1);
            st.push(2);
            st.push(3);
            st.push(4);
            Assert.AreEqual(4, st.pop());
            Assert.AreEqual(3, st.pop());
        }
        [TestMethod]
        public void tesPeek()
        {
            Stack st = new Stack(4);
            st.push(1);
            st.push(2);
            st.push(3);
            Assert.AreEqual(3, st.peek());
            Assert.AreEqual(3, st.count());
        }
        [TestMethod]
        public void testClear()
        {
            Stack st = new Stack(4);
            st.push(1);
            st.push(2);
            st.push(3);
            st.clear();
            Assert.AreEqual(0, st.count());
        }
    }
}
