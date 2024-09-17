namespace Practica2.Ej4
{
    public class Coche : IVehiculo
    {
        int CombustibleInicial { get; set; }
        private int _combustible;
        public Coche(int combustibleInicial)
        {
            _combustible = combustibleInicial;
        }

        public string Conducir()
        {
            return _combustible > 0 ? "El coche está siendo manejado." : "El coche no tiene combustible.";
        }

        public bool CargarCombustible(int cantidad)
        {
            _combustible += cantidad;
            return true;
        }
    }
}

