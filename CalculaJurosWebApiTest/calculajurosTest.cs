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
            double x = 100.0;
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
            double x = 1.0;
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
            double x = 100.0;
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
            double x = 1;
            uint y = 0;
            double r;

            Taxa t = new Taxa();

            r = x * Math.Pow(1 + t.GetTaxa(), y);

            if (r <= 0.0)
                Assert.Fail("The result is below or equal zero");
        }

        //Testa se o os valores de entrada são números válidos
        [TestMethod]
        [Owner("Bruno")]
        public void TestNumeric()
        {
            string val = "5";
            string mes = "6";

            if(!CalculaJuros.IsNumeric(val) || !CalculaJuros.IsNumeric(mes))
                Assert.Fail("Input values ​​are not numbers");
        }

        //Testa se o resultado excede o limite de caracteres do tipo double (16c)
        [TestMethod]
        [Owner("Bruno")]
        public void TestLimit()
        {
            double x = 100;
            uint y = 3200;
            double r;
            string res;
            double zero = 0.0;

            Taxa t = new Taxa();

            r = x * Math.Pow(1 + t.GetTaxa(), y);

            res = r.ToString("F2", CultureInfo.CurrentCulture);

            if (!CalculaJuros.IsNumeric(res))
                Assert.Fail("Input values ​​are not numbers");

            if(res.Length > 16 || r == (1/zero))
                Assert.Fail("Result exceeded precision character limit. Result = " + res);

        }
    }
}
