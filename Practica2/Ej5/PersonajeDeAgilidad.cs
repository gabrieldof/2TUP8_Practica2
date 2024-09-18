using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica2.Ej5
{
    public class PersonajeDeAgilidad : Personaje, IMoverse
    {
        public PersonajeDeAgilidad(string nombre, int agilidad, int magia, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
        }

        public override double  CalcularDanio()
        {
            return (Fuerza / 2) * Agilidad * (Magia / 2);
        
        }

        public override string Atacar()
        {
            return $"{Nombre} ataca con agilidad y precisión!";
        }

        //public override string DescripcionBatalla()
        //{
        //    return $"{Nombre} usa su agilidad para esquivar y atacar con rapidez!";
        //}
        public void MoverseEjeX(int unidades)
        {

            Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje X.");
        }
        public void MoverseEjeY(int unidades)
        {

            Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje Y.");
        }
    }
}
