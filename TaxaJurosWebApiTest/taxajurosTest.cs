using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaJurosWebAPI.Models;
using System.Globalization;
using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

namespace TaxaJurosWebApiTest
{
    [TestClass]
    public class taxajurosTest
    {
        //Testa se a taxa � 0.01
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

