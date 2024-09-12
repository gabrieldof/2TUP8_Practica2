using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2.Ej2;
using Practica2.Ej3;

namespace Practica2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        private static List<Persona> personas = new List<Persona>();

        [HttpPost("[action]")]
        public ActionResult CrearPersona([FromBody] string nombre)
        {
            var persona = new Persona ( nombre );
            personas.Add(persona);
            return Ok(persona.Saludar());
        }

        [HttpPost("[action]")]
        public IActionResult CrearEstudiante( string nombre,  int edad)
        {
            var estudiante = new Estudiante (nombre);
            estudiante.SetEdad(edad);
            personas.Add(estudiante);
            return Ok($"{estudiante.Saludar()}. {estudiante.MostrarEdad()}. {estudiante.Estudiar()} ");
            
        }

        [HttpPost("[action]")]
        public IActionResult CrearProfesor( string nombre,  int edad)
        {
            var profesor = new Profesor(nombre);
            profesor.SetEdad(edad);
            personas.Add(profesor);
            return Ok($"{profesor.Saludar()}. {profesor.Explicar()} ");

        }
    }
}
