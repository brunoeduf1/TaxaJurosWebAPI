using System;
using System.Globalization;

namespace TaxaJurosWebAPI.Models
{
    public class calculajuros
    {

        public string resultado { get; set; }

        public void calcularesultado(int valorinicial, int meses)
        {
            double r;
            
            Taxa t = new Taxa();

            r = valorinicial * Math.Pow(1 + t.GetTaxa(), meses);
            resultado = r.ToString("F2", CultureInfo.CurrentCulture);

        }
    }
}
