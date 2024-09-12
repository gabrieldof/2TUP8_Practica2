﻿namespace Practica2.Ej3
{
    public class Persona
    {
        public int Edad { get; set; }
        public string? Nombre { get; set; }


        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public virtual string Saludar()
        {
            return ($"Hola soy {Nombre}");
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }

    }
}
