namespace Practica2.Ej5
{
    public class PersonajeDeMagia : Personaje, IMoverse
    {


        public PersonajeDeMagia(string nombre, int agilidad,  int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = 60;
            Fuerza = fuerza;

        }
        public PersonajeDeMagia(string nombre, int agilidad, int magia , int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;

        }

        public override double CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;
        }

        public override string Atacar()
        {
            double danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de daño gracias a su magia";
        }
    }
}
