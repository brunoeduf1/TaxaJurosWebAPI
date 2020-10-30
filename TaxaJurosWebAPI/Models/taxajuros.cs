using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxaJurosWebAPI.Models
{
    public class Taxa
    {
        public double taxajuros { get; set; }

        public Taxa() { }
        public void GetTaxa()
        {
            taxajuros = 0.01;
        }
    }
}
