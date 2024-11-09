using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MaquinaDeCafeApp;

namespace MaquinaDeCafeTest
{
    public class TestVaso
    {
        [Fact]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            var maquina = new MaquinaDeCafe();
            Assert.True(maquina.HayVasos());
        }

        /*
        [Fact]
        public void deberiaDevolverFalsoSiNoExistenVasos()
        {
            var maquina = new MaquinaDeCafe();
            maquina.ConsumirVaso("Mediano");
            Assert.False(maquina.HayVasos());
        }
        */

        [Fact]
        public void deberiaRestarCantidadDeVaso()
        {
            var maquina = new MaquinaDeCafe();
            var vasosIniciales = maquina.CantidadVasos();
            maquina.ConsumirVaso("Grande");
            Assert.Equal(vasosIniciales - 1, maquina.CantidadVasos());
        }
    }
}
