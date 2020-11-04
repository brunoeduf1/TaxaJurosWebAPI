using System;
using System.Globalization;
using TaxaJurosWebAPI.Models;

namespace CalculaJurosWebAPI.Models
{
    public class CalculaJuros
    {

        public string resultado { get; set; }

        public void CalculaResultado(string valorinicial, uint meses)
        {
            double r;
            double val = 0.0;
            bool msgError = false;

            Taxa t = new Taxa();

            //Verifica se o valor digitado é um número válido
            if (!IsNumeric(valorinicial) && msgError == false)
            {
                resultado = "O valor digitado não é um número válido";
                msgError = true;
            }

            else
            {
                val = Double.Parse(valorinicial, CultureInfo.CurrentCulture);
                r = val * Math.Pow(1 + t.GetTaxa(), meses);
                resultado = r.ToString("F2", CultureInfo.CurrentCulture);
            }

            //Verifica se o valor inicial é maior que zero
            if (val <= 0 && msgError == false)
            {
                resultado = "O valor informado deve ser superior a zero";
                msgError = true;
            }
        }

        public static bool IsNumeric(string val)
        {
            double retNum;
            char[] valArray;

            bool isNum = Double.TryParse(Convert.ToString(val), 
                System.Globalization.NumberStyles.Currency,
                System.Globalization.NumberFormatInfo.CurrentInfo, out retNum);

            valArray = val.ToCharArray(0, val.Length);

            foreach (char c in valArray)
            {
                if (!char.IsNumber(c))
                {
                    if (c == '.')
                        isNum = false;
                }
            }
            
            return isNum;
        }
    }
}
