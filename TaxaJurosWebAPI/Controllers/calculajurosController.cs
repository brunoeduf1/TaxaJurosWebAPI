using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxaJurosWebAPI.Models;

namespace TaxaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class calculajurosController : ControllerBase
    {
        [HttpGet("/calculajuros-valorinicial={val}&meses={m}")]
        public calculajuros Get(int val, int m)
        {
            calculajuros n = new calculajuros();
            n.calcularesultado(val, m);

            return n;
        }
    }
}
