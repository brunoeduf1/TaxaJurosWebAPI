using System;
using System.Globalization;
using TaxaJurosWebAPI.Models;

namespace CalculaJurosWebAPI.Models
{
    public class CalculaJuros
    {
        public string Resultado { get; set; }

        public string CalculaResultado(string valorinicial, string meses)
        {
            double r = 0.0;
            double val = 0.0;
            uint mes;
            bool msgError = false;
            double zero = 0.0;

            Taxa t = new Taxa();

            //Verifica se o valor digitado é um número válido
            if ((!IsNumeric(valorinicial) && msgError == false) || !IsNumeric(meses))
            {
                Resultado = "Valor e(ou) mês informado(s) inválido(s)";

                msgError = true;
            }

            else
            {
                val = Double.Parse(valorinicial, CultureInfo.CurrentCulture);

                mes = uint.Parse(meses, CultureInfo.CurrentCulture);

                r = val * Math.Pow(1 + t.GetTaxa(), mes);

                Resultado = r.ToString("F2", CultureInfo.CurrentCulture);
            }

            //Verifica se o resultado excede o limite de caracteres esperados
            if ((Resultado.Length > 16 || r == (1 /zero)) && msgError == false)
            {
                Resultado = "Resultado excedeu o limte de caracteres de precisão";

                msgError = true;
            }

            //Verifica se o valor inicial é maior que zero
            if (val <= 0 && msgError == false)
            {
                Resultado = "O valor informado deve ser superior a zero";

                msgError = true;
            }

            return Resultado;
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
