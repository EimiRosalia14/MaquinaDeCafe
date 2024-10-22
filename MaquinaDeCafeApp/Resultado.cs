using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafeApp
{
    public class Resultado
    {
        public string Mensaje { get; private set; }

        public Resultado(string mensaje)
        {
            Mensaje = mensaje;
        }
    }
}
