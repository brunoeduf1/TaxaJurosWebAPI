using System.Globalization;

namespace TaxaJurosWebAPI.Models
{
    public class Taxa
    {
        public string taxajuros { get; set; }

        public Taxa() { }

        public double GetTaxa()
        {
            double tx = 0.01;
            taxajuros = tx.ToString("F2", CultureInfo.CurrentCulture);

            return tx;
        }
    }
}
