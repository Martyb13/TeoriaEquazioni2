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
        [TestMethod]
        public void TestIsIndeterminated1()
        {
            double a = 1;
            double b = 1;
            bool risultato_atteso = false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isIndetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsIndeterminated2()
        {
            double a = 0;
            double b = 5;
            bool risultato_atteso =false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isIndetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsIndeterminated3()
        {
            double a = 20;
            double b = 1;
            bool risultato_atteso = false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isIndetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsIndeterminated4()
        {
            double a = 0;
            double b = 0;
            bool risultato_atteso = true;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isIndetermined(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsInconsisted1()
        {
            double a = 0;
            double b = 0;
            bool risultato_atteso = false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isInconsisted(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsInconsisted2()
        {
            double a = 1;
            double b = 0;
            bool risultato_atteso = false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isInconsisted(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsInconsisted3()
        {
            double a = 0;
            double b = 11;
            bool risultato_atteso = true;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isInconsisted(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestIsInconsisted4()
        {
            double a = 3;
            double b = 4;
            bool risultato_atteso = false;

            bool risultato_ottenuto = EquazioniLibrary.Equazioni.isInconsisted(a, b);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
    }
}
  
