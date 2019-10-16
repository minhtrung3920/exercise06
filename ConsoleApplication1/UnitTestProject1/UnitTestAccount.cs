using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestAccount()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));

            Assert.AreEqual(200000, acc.Balance());
        }
        [TestMethod]
        public void TestDeposit()
        {
            Account acc1 = new Account(1500);
            Assert.AreEqual(500, acc1.Deposit());
        }
    }
}
