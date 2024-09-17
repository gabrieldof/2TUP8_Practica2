using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2.Ej4;

namespace Practica2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {

        [HttpPost("ConducirConCombustible")]
        public IActionResult ConducirConCombustible([FromBody] int cantidadCombustible)
        {
            Coche coche = new Coche(cantidadCombustible);
            return Ok(coche.Conducir());
            
        }


        [HttpPost("CargarCombustibleYConducir")]
        public IActionResult CargarCombustibleYConducir([FromBody] int cantidadCombustible)
        {
            Coche coche = new Coche(0); // Crear coche sin combustible
            coche.CargarCombustible(cantidadCombustible); // Cargar combustible
            return Ok(coche.Conducir());

        }

    }
}
