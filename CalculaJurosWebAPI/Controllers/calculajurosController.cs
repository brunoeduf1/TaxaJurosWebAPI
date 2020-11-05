using CalculaJurosWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        public CalculaJuros Get(string valorinicial, string meses)
        {
            CalculaJuros res = new CalculaJuros();
            res.CalculaResultado(valorinicial, meses);

            return res;
        }
    }
}
