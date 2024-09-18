namespace Practica2.Ej5
{
    public class Enemigo : IMoverse
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public Enemigo(string nombre, int vida, int nivel)
        {
            Nombre = nombre;
            Vida = vida;
            Nivel = nivel;
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
