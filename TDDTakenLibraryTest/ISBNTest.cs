using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class ISBNTest
    {
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersIsFout()
        {
            new ISBN(978902743964L);
        }

        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void NummerMet14CijfersIsFout()
        {
            new ISBN(97890274396422L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNegatiefNummerIsFout()
        {
            new ISBN(-97890727439642L);
        }

        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void NummerMet0IsFout()
        {
            new ISBN(0);
        }

        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersMetVerkeerdeControleNr()
        {
            new ISBN(8789027439642L);
        }

        [TestMethod]
        public void NummerMet13CijfersMetCorrecteControleNr()
        {
            new ISBN(9789027439642L);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersMetVerkeerdeControleNr0()
        {
            new ISBN(7789227439640L);
        }

        [TestMethod]
        public void NummerMet13CijfersMetCorrecteControleNr0()
        {
            new ISBN(9789227439640L);
        }
    }
}
