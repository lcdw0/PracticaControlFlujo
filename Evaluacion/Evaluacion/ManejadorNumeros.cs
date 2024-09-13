using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    internal class ManejadorNumeros
    {
        private List<int> numeros;

        public ManejadorNumeros()
        {
            numeros = new List<int>();
        }

        public void AgregarNumero(int numero)
        {
            if (numero >= 0)
            {
                numeros.Add(numero);
            }
        }

        public int ObtenerSuma()
        {
            return numeros.Sum();
        }

        public int ObtenerMayor()
        {
            return numeros.Count > 0 ? numeros.Max() : 0;
        }

        public int ObtenerMenor()
        {
            return numeros.Count > 0 ? numeros.Min() : 0;
        }

        public bool HayNumeros()
        {
            return numeros.Count > 0;
        }
    }
}
