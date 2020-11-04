using CalculaJurosWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace CalculaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet("/calculajuros-valorinicial={valor}&meses={meses}")]
        public CalculaJuros Get(string valor, uint meses)
        {
            CalculaJuros calc = new CalculaJuros();
            calc.CalculaResultado(valor, meses);

            return calc;
        }
        /*[HttpGet]
        public IActionResult calculajuros()
        {
            string valorinicial = "010717";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["valor"]))
                valorinicial = HttpContext.Request.Query["valor"];

            uint meses = 5;

            string m = meses.ToString("F0", CultureInfo.CurrentCulture);
                    
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["meses"]))
                m = HttpContext.Request.Query["meses"];

            CalculaJuros calc = new CalculaJuros();
            calc.CalculaResultado(valorinicial, meses);

            return Content(valorinicial + meses);
        }*/


    }
}
