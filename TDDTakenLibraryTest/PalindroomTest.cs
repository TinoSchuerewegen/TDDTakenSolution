using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class PalindroomTest
    {
        [TestMethod]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom("lepel").IsPalindroom());
        }

        [TestMethod]
        public void VorkIsGeenPalindroom()
        {
            Assert.IsFalse(new Palindroom("vork").IsPalindroom01());
        }

        [TestMethod]
        public void EenLegeStringIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom(string.Empty).IsPalindroom02());
        }
    }
}
