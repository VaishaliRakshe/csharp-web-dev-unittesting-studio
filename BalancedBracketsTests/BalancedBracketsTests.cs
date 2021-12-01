using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]

        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestLeftAndRight()
        {
            Assert.IsTrue(BalancedBracketsTests.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void TestRightBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBracketsTests.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void TestLeftBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBracketsTests.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void TestTextLeftBracketTextRightBracket()
        {
            Assert.IsTrue(BalancedBracketsTests.HasBalancedBrackets("Java[Script]"));
        }
        [TestMethod]
        public void TestBackwardBracket()
        {
            Assert.IsFalse(BalancedBracketsTests.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void TestThreeLeftBracketsAndThreeRight()
        {
            Assert.IsFalse(BalancedBracketsTests.HasBalancedBrackets("]]]JavaScript[[["));
        }
    }
}
