using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2
{    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string nombres, string apellidos, DateTime fechaNacimiento)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
        }

        public int CalcularEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear)
            {
                edad--;
            }
            return edad;
        }

        public override string ToString()
        {
            return $"{Nombres} {Apellidos}, Edad: {CalcularEdad()} años";
        }
    }
}
