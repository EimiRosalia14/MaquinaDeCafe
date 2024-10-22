using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafeApp
{
    public class Cafetera
    {
        private int _cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            _cantidadCafe = cantidadCafe;
        }

        public bool HayCafe(int cantidadRequerida)
        {
            return _cantidadCafe >= cantidadRequerida;
        }

        public void ConsumirCafe(int cantidad)
        {
            _cantidadCafe -= cantidad;
        }

        public int CafeRestante()
        {
            return _cantidadCafe;
        }
    }
}
