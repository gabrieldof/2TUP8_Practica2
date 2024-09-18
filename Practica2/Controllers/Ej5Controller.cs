using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2.Ej5;
using System.Text;

namespace Practica2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        private static List<Personaje> personajes = new List<Personaje>();
        private static List<Enemigo> enemigos = new List<Enemigo>();

        // Endpoint para crear un personaje de fuerza
        [HttpPost("CrearPersonajeFuerza")]
        public IActionResult CrearPersonajeFuerza([FromBody] PersonajeDeFuerza personaje)
        {
            personajes.Add(personaje);
            return Ok($"{personaje.Nombre} creado con éxito");
        }

        // Endpoint para crear un personaje de agilidad
        [HttpPost("CrearPersonajeAgilidad")]
        public IActionResult CrearPersonajeAgilidad([FromBody] PersonajeDeAgilidad personaje)
        {
            personajes.Add(personaje);
            return Ok($"{personaje.Nombre} creado con éxito");
        }

        // Endpoint para crear un personaje de magia
        [HttpPost("CrearPersonajeMagia")]
        public IActionResult CrearPersonajeMagia(string nombre, int fuerza, int agilidad, int? magia)
        {
            var personaje = magia.HasValue ? new PersonajeDeMagia(nombre, fuerza, agilidad, magia.Value) : new PersonajeDeMagia(nombre, fuerza, agilidad);


            personajes.Add(personaje);
            return Ok($"{personaje.Nombre} creado con éxito");
        }

        // Endpoint para crear un enemigo
        [HttpPost("CrearEnemigo")]
        public IActionResult CrearEnemigo([FromBody] Enemigo enemigo)
        {
            enemigos.Add(enemigo);
            return Ok($"Enemigo de nivel {enemigo.Nivel} creado con éxito");
        }

        // Endpoint para ejecutar la batalla
        [HttpGet("Batalla")]
        public IActionResult Batalla()
        {
            if (!personajes.Any() || !enemigos.Any())
            {
                return BadRequest("Debe haber al menos un personaje y un enemigo para iniciar la batalla.");
            }

            // Simulación de la batalla
            var descripcionBatalla = new StringBuilder("¡Comienza la batalla!\n");

            // Los personajes atacan a los enemigos
            foreach (var personaje in personajes)
            {
                foreach (var enemigo in enemigos)
                {
                    // El personaje ataca y se describe el daño causado
                    descripcionBatalla.AppendLine($"{personaje.Atacar()} al enemigo de nivel {enemigo.Nivel}");

                    // Movimiento del enemigo en el campo de batalla
                    Turno.MoverFichas(enemigo);
                    descripcionBatalla.AppendLine($"El enemigo de nivel {enemigo.Nivel} se ha movido en el campo de batalla.");
                }
            }

            // Los enemigos atacan a los personajes
            foreach (var enemigo in enemigos)
            {
                foreach (var personaje in personajes)
                {
                    // Simulación del daño de un enemigo hacia un personaje (puedes agregar una fórmula específica si lo deseas)
                    descripcionBatalla.AppendLine($"El enemigo de nivel {enemigo.Nivel} contraataca a {personaje.Nombre}.");
                }
            }

            descripcionBatalla.AppendLine("¡La batalla ha terminado!");

            return Ok(descripcionBatalla.ToString());
        }
    }
}
