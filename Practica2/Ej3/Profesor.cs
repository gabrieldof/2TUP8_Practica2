namespace Practica2.Ej3
{
    public class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre) { }
        public override string Saludar()
        {
            return ($"Hola soy el Profesor {Nombre}");
        }
        public string Explicar()
        {
            return ("Estoy explicando.");
        }
    }
}
