using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica2.Ej3
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre) { }
        public string Estudiar()
        {
            return ("Estoy estudiando.");
        }

        public override string Saludar()
        {
            return ($"Hola soy el Estudiante {Nombre}");
        }

        public string MostrarEdad()
        {
            return ($"mi edad es: {Edad}");
        }
    }
}
