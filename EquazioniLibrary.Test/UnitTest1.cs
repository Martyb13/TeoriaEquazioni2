using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDeterminated1()
        {
            double a = 0;
            double b = 0;
            bool risultato_atteso = false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isDetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsDeterminated2()
        {
            double a = 1;
            double b = 0;
            bool risultato_atteso = true;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isDetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsDeterminated3()
        {
            double a = 0;
            double b = 1;
            bool risultato_atteso = false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isDetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsDeterminated4()
        {
            double a = 1;
            double b = 1;
            bool risultato_atteso = true;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isDetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }

    }
}
  
