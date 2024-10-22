using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MaquinaDeCafeApp;

namespace MaquinaDeCafeTest
{
    public class TestCafetera
    {
        [Fact]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            var cafetera = new Cafetera(100); // 100 oz de café disponible
            Assert.True(cafetera.HayCafe(10));
        }

        [Fact]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            var cafetera = new Cafetera(0); // Sin café
            Assert.False(cafetera.HayCafe(10));
        }

        [Fact]
        public void deberiaRestarCafeAlaCafetera()
        {
            var cafetera = new Cafetera(50); // 50 oz disponibles
            cafetera.ConsumirCafe(10);
            Assert.Equal(40, cafetera.CafeRestante());
        }
    }
}
