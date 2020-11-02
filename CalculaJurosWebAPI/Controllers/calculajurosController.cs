using CalculaJurosWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class calculajurosController : ControllerBase
    {
        [HttpGet("/calculajuros-valorinicial={valor}&meses={meses}")]
        public CalculaJuros Get(string valor, uint meses)
        {
            CalculaJuros calc = new CalculaJuros();
            calc.CalculaResultado(valor, meses);

            return calc;
        }
    }
}
