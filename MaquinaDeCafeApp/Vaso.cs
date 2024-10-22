using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafeApp
{
    public class Vaso
    {
        public int Oz { get; private set; }

        public Vaso(int oz)
        {
            Oz = oz;
        }
    }
}
