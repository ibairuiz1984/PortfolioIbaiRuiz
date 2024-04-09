using System;

namespace Portfolio.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        private DateTime FechaNacimiento { get; set; }

        public int Edad
        {
            get
            {
                DateTime fechaActual = DateTime.Now;
                int edad = fechaActual.Year - FechaNacimiento.Year;
                if (fechaActual < FechaNacimiento.AddYears(edad))
                {
                    edad--;
                }
                return edad;
            }
        }

        // Constructor
        public Persona(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }
    }
}