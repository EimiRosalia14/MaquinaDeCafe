using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafeApp
{
    public class Azucarero
    {
        private int _cantidadAzucar;

        public Azucarero(int cantidadAzucar)
        {
            _cantidadAzucar = cantidadAzucar;
        }

        public bool HayAzucar(int cantidadRequerida)
        {
            return _cantidadAzucar >= cantidadRequerida;
        }

        public void ConsumirAzucar(int cantidad)
        {
            _cantidadAzucar -= cantidad;
        }

        public int AzucarRestante()
        {
            return _cantidadAzucar;
        }
    }
}
