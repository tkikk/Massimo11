using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatematicaLibrary;

namespace MatematicaLibrary.Test
{
    /// <summary>
    /// Summary description for CalcolatriceTest
    /// </summary>
    [TestClass]
    public class CalcolatriceTest
    {
        public CalcolatriceTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMassimo()
        {
            double num1 = 5;
            double num2 = 0;
            double risultato = 5;

            double massimo = Calcolatrice.Massimo(num1, num2);
            Assert.AreEqual(risultato, massimo);
        }
        [TestMethod]
        public void TestMassimo1()
        {
            double num1 = 5;
            double num2 = 5;
            double risultato = 5;

            double massimo = Calcolatrice.Massimo(num1, num2);
            Assert.AreEqual(risultato, massimo);
        }
        [TestMethod]
        public void TestMassimo2()
        {
            double num1 = 8;
            double num2 = 0;
            double risultato = 8;

            double massimo = Calcolatrice.Massimo(num1, num2);
            Assert.AreEqual(risultato, massimo);
        }
        [TestMethod]
        public void TestMinimo()
        {
            double num1 = 5;
            double num2 = 0;
            double risultato = 0;

            double minimo = Calcolatrice.Minimo(num1, num2);
            Assert.AreEqual(risultato, minimo);
        }
        [TestMethod]
        public void TestMinimo1()
        {
            double num1 = 5;
            double num2 = 5;
            double risultato = 5;

            double minimo = Calcolatrice.Minimo(num1, num2);
            Assert.AreEqual(risultato, minimo);
        }
        [TestMethod]
        public void TestMinimo2()
        {
            double num1 = 8;
            double num2 = 3;
            double risultato = 3;

            double minimo = Calcolatrice.Minimo(num1, num2);
            Assert.AreEqual(risultato, minimo);
        }








        public void TestMedia()
        {
            double num1 = 18;
            double num2 = 9;
            double risultato = 9;

            double minimo = Calcolatrice.Minimo(num1, num2);
            Assert.AreEqual(risultato, minimo);
        }
        [TestMethod]
        public void TestMedia1()
        {
            double num1 = 6;
            double num2 = 3;
            double risultato = 4.5;

            double media = Calcolatrice.Media(num1, num2);
            Assert.AreEqual(risultato, media);
        }
        [TestMethod]
        public void TestMedia2()
        {
            double num1 = 8;
            double num2 = 2;
            double risultato = 5;

            double media = Calcolatrice.Media(num1, num2);
            Assert.AreEqual(risultato, media);
        }




        [TestMethod]
        public void TestMediatre()
        {
            double num1 = 8;
            double num2 = 2;
            double num3 = 2;
            double risultato = 4;

            double mediatre = Calcolatrice.Mediatre(num1, num2,num3);
            Assert.AreEqual(risultato, mediatre);
        }
        [TestMethod]
        public void TestMassimotre()
        {
            double num1 = 8;
            double num2 = 2;
            double num3 = 2;
            double risultato = 8;

            double massimotre = Calcolatrice.Massimotre(num1, num2, num3);
            Assert.AreEqual(risultato, massimotre);
        }
        [TestMethod]
        public void TestMinimotre()
        {
            double num1 = 8;
            double num2 = 2;
            double num3 = 2;
            double risultato = 2;

            double minimotre = Calcolatrice.Minimotre(num1, num2, num3);
            Assert.AreEqual(risultato, minimotre);
        }
    }
}
