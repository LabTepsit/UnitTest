using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalcolatrice;

namespace LibraryCalcolatriceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivisioneZero()
        {
            Calcolatrice c = new Calcolatrice();
            c.Risultato = 1;
            try
            {
                c.Divisione(0);
                Assert.Fail(); // If it gets to this line, no exception was thrown
            }
            catch (Exception) { }
        }
    }
}
