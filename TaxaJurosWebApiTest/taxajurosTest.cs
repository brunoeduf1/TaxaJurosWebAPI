using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaJurosWebAPI.Models;

namespace TaxaJurosWebApiTest
{
    [TestClass]
    public class TaxaJurosTest
    {
        //Testa se a taxa é 0.01
        [TestMethod]
        [Owner("Bruno")]
        public void TxValue()
        {
            Taxa tx = new Taxa();
            double str = tx.GetTaxa();

            if(str != 0.01)
                Assert.Fail("The value is different of 0.01");
        }
    }
}

