namespace Practica2.Ej5
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }


        public abstract double CalcularDanio();

        public virtual string Atacar()
        {
            var danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de daño";
        }

        // Métodos de la interfaz IMoverse
        public void MoverseEjeX(int x)
        {
            Console.WriteLine($"{Nombre} se movió en el eje X: {x}");
        }

        public void MoverseEjeY(int y)
        {
            Console.WriteLine($"{Nombre} se movió en el eje Y: {y}");
        }
    }
}
