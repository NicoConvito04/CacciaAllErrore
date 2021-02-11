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

        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = -100;
            long valore_aspettato = -3;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[4] { 4, 6, 7, -9.1 };
            double valore_aspettato = 3;
            double resp = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, resp);
        }


    }
}

