using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace OperazioniTests
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void TestCalcoloMisterioso()
        {
                int n = 10;
                long valore_aspettato = 7257600;
                long resp = Gestione.CalcoloMisterioso(n);
                Assert.AreEqual(valore_aspettato , resp);
        }

    }
}

