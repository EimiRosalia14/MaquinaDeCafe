using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MaquinaDeCafeApp;

namespace MaquinaDeCafeTest
{
    public class TestAzucarero
    {
        [Fact]
        public void deberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
        {
            var azucarero = new Azucarero(10); // 10 cucharadas disponibles
            Assert.True(azucarero.HayAzucar(5));
        }

        [Fact]
        public void deberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
        {
            var azucarero = new Azucarero(3); // Solo 3 cucharadas
            Assert.False(azucarero.HayAzucar(5));
        }

        [Fact]
        public void deberiaRestarAzucarAlAzuquero()
        {
            var azucarero = new Azucarero(10); // 10 cucharadas
            azucarero.ConsumirAzucar(3);
            Assert.Equal(7, azucarero.AzucarRestante());
        }
    }
}
