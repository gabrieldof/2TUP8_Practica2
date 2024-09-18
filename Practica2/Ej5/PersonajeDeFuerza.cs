namespace Practica2.Ej5
{
    public class PersonajeDeFuerza : Personaje, IMoverse
    {
        public PersonajeDeFuerza(string nombre, int agilidad, int magia)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = 100;

        }
        public override double CalcularDanio()
        {
            return Fuerza * (Agilidad / 2) + Magia;
        }
    }
}
