using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void HetHoogsteBodVanEenNieuweVeilingIsNul()
        {
            var veiling = new Veiling();
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }

        [TestMethod]
        public void HetHoogsteBodNaEenEersteBodIsHetBedragVanDatBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(100);
            Assert.AreEqual(100m, veiling.HoogsteBod);
        }

        [TestMethod]
        public void NaMeerdereBiedingenIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(100m);
            veiling.DoeBod(200m);
            veiling.DoeBod(150m);
            Assert.AreEqual(200m, veiling.HoogsteBod);
        }
    }
}
