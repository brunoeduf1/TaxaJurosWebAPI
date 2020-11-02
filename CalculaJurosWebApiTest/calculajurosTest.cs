using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculaJurosWebAPI.Models;
using TaxaJurosWebAPI.Models;
using System;
using System.Globalization;

namespace CalculaJurosWebApiTest
{
    [TestClass]
    public class CalculaJurosTest
    {

        //Testa a conversão para string
        [TestMethod]
        [Owner("Bruno")]
        public void TestConversionType()
        {
            uint x = 100;
            uint y = 5;
            double r;
            string res;

            Taxa t = new Taxa();

            r = x * Math.Pow(1 + t.GetTaxa(), y);

            res = r.ToString("F2", CultureInfo.CurrentCulture);

            Assert.IsInstanceOfType(res, typeof(string));
        }

        //Verifica se a string não está nula
        [TestMethod]
        [Owner("Bruno")]
        public void TestResult()
        {
            uint x = 1;
            uint y = 0;
            double r;
            string res;

            Taxa t = new Taxa();

            r = x * Math.Pow(1 + t.GetTaxa(), y);

            res = r.ToString("F2", CultureInfo.CurrentCulture);

            Assert.IsNotNull(res);
        }

        //Testa se o resultado é do tipo double
        [TestMethod]
        [Owner("Bruno")]
        public void TestResultType()
        {
            uint x = 100;
            uint y = 5;
            double r;

            Taxa t = new Taxa();

            r = x * Math.Pow(1 + t.GetTaxa(), y);

            Assert.IsInstanceOfType(r, typeof(double));
        }

        //Testa se o resultado é maior ou igual a zero
        [TestMethod]
        [Owner("Bruno")]
        public void TestResultAboveOrEqualZero()
        {
            uint x = 100;
            uint y = 0;
            double r;

            Taxa t = new Taxa();

            r = x * Math.Pow(1 + t.GetTaxa(), y);

            if (r < 0.0)
                Assert.Fail("The result is below zero");
        }
    }
}
