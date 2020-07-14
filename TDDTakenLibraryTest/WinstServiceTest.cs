using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenLibrary;

namespace TDDTakenLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private IOpbrengstDAO opbrengstDAO;         //STUB
        private IKostDAO kostDAO;                   //STUB
        private WinstService winstService;          //TE TESTEN CLASS

        [TestInitialize]
        public void Initialize()
        {
            opbrengstDAO = new OpbrengstDAOStub();
            kostDAO = new KostDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
        }
    }
}
