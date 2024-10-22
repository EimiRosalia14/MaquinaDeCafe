using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MaquinaDeCafeApp;

namespace MaquinaDeCafeTest
{
    public class TestMaquinaDeCafe
    {
        [Fact]
        public void deberiaRestarCafe()
        {
            var maquina = new MaquinaDeCafe();
            var cafeInicial = maquina.Cafetera.CafeRestante();
            maquina.PrepararCafe();
            Assert.True(maquina.Cafetera.CafeRestante() < cafeInicial);
        }

        [Fact]
        public void deberiaRestarVaso()
        {
            var maquina = new MaquinaDeCafe();
            var vasosIniciales = maquina.CantidadVasos();
            maquina.PrepararCafe();
            Assert.Equal(vasosIniciales - 1, maquina.CantidadVasos());
        }

        [Fact]
        public void deberiaDevolverUnVasoPequeno()
        {
            var maquina = new MaquinaDeCafe();
            var vaso = maquina.SeleccionarTamañoVaso("Pequeño");
            Assert.Equal(3, vaso.Oz);
        }

        [Fact]
        public void deberiaDevolverNoHayAzucar()
        {
            var maquina = new MaquinaDeCafe();
            maquina.Azucarero.ConsumirAzucar(10);
            var resultado = maquina.PrepararCafe();
            Assert.Equal("Error: No hay suficiente azúcar.", resultado.Mensaje);
        }

        [Fact]
        public void deberiaDevolverUnVasoGrande()
        {
            var maquina = new MaquinaDeCafe();
            var vaso = maquina.SeleccionarTamañoVaso("Grande");
            Assert.Equal(7, vaso.Oz);
        }

        [Fact]
        public void deberiaDevolverFelicitaciones()
        {
            var maquina = new MaquinaDeCafe();
            maquina.SeleccionarTamañoVaso("Mediano");
            maquina.SeleccionarAzucar(2);
            var resultado = maquina.PrepararCafe();
            Assert.Equal("Café preparado: Mediano con 2 cucharadas de azúcar. Felicitaciones!", resultado.Mensaje);
        }

        [Fact]
        public void deberiaDevolverUnVasoMediano()
        {
            var maquina = new MaquinaDeCafe();
            var vaso = maquina.SeleccionarTamañoVaso("Mediano");
            Assert.Equal(5, vaso.Oz);
        }

        [Fact]
        public void deberiaRestarAzucar()
        {
            var maquina = new MaquinaDeCafe();
            var azucarInicial = maquina.Azucarero.AzucarRestante();
            maquina.SeleccionarAzucar(3);
            maquina.PrepararCafe();
            Assert.Equal(azucarInicial - 3, maquina.Azucarero.AzucarRestante());
        }

        [Fact]
        public void deberiaDevolverNoHayCafe()
        {
            var maquina = new MaquinaDeCafe();
            maquina.Cafetera.ConsumirCafe(50); // Sin café
            var resultado = maquina.PrepararCafe();
            Assert.Equal("Error: No hay suficiente café.", resultado.Mensaje);
        }

        [Fact]
        public void deberiaDevolverNoHayVasos()
        {
            var maquina = new MaquinaDeCafe();
            maquina.ConsumirVaso("Grande"); // Sin vasos grandes
            var resultado = maquina.PrepararCafe();
            Assert.Equal("Error: No hay vasos disponibles.", resultado.Mensaje);
        }
    }
}
