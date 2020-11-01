using CalculaJurosWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class calculajurosController : ControllerBase
    {
        [HttpGet("/calculajuros-valorinicial={val}&meses={m}")]
        public calculajuros Get(int val, int m)
        {
            calculajuros calc = new calculajuros();
            calc.calcularesultado(val, m);

            return calc;
        }
    }
}
