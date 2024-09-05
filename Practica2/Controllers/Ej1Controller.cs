using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2.Ej1;

namespace Practica2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string nombre1, [FromQuery] string nombre2, [FromQuery] string nombre3)
        {
            List<Persona> personas = [];

            personas.Add(new Persona(nombre1));
            personas.Add(new Persona(nombre2));
            personas.Add(new Persona(nombre3));

            var saludos = personas.Select(p => p.GetSaludo()).ToList();

            return Ok(saludos);
        }
    }
}
