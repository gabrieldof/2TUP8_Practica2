namespace Practica2.Ej1
{
    public class Persona
    {
        public string? Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public string GetSaludo()
        {
            return $"Hola! Mi nombre es {Nombre}"; 
        }


    }
}
