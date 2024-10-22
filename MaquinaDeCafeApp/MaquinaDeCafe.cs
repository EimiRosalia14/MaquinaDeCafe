using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafeApp
{
    public class MaquinaDeCafe
    {
        public Cafetera Cafetera { get; private set; }
        public Azucarero Azucarero { get; private set; }
        private Dictionary<string, int> _vasosDisponibles;

        public MaquinaDeCafe()
        {
            Cafetera = new Cafetera(50); // Cantidad inicial de café
            Azucarero = new Azucarero(10); // Cantidad inicial de azúcar
            _vasosDisponibles = new Dictionary<string, int>
            {
                { "Pequeño", 10 },
                { "Mediano", 10 },
                { "Grande", 10 }
            };
        }

        public bool HayVasos()
        {
            return _vasosDisponibles.Values.Any(cantidad => cantidad > 0);
        }

        public int CantidadVasos()
        {
            return _vasosDisponibles.Sum(v => v.Value);
        }

        public void ConsumirVaso(string tamaño)
        {
            if (_vasosDisponibles.ContainsKey(tamaño) && _vasosDisponibles[tamaño] > 0)
            {
                _vasosDisponibles[tamaño]--;
            }
        }

        public Vaso SeleccionarTamañoVaso(string tamaño)
        {
            int onzas = tamaño switch
            {
                "Pequeño" => 3,
                "Mediano" => 5,
                "Grande" => 7,
                _ => 0
            };

            return new Vaso(onzas);
        }

        public void SeleccionarAzucar(int cucharadas)
        {
            Azucarero.ConsumirAzucar(cucharadas);
        }

        public Resultado PrepararCafe()
        {
            var tamañoVaso = "Mediano"; // Default para pruebas
            var cucharadasAzucar = 2; // Default para pruebas

            var vaso = SeleccionarTamañoVaso(tamañoVaso);

            if (!Cafetera.HayCafe(vaso.Oz))
            {
                return new Resultado("Error: No hay suficiente café.");
            }

            if (!Azucarero.HayAzucar(cucharadasAzucar))
            {
                return new Resultado("Error: No hay suficiente azúcar.");
            }

            if (_vasosDisponibles[tamañoVaso] == 0)
            {
                return new Resultado("Error: No hay vasos disponibles.");
            }

            // Restar café y vaso
            Cafetera.ConsumirCafe(vaso.Oz);
            ConsumirVaso(tamañoVaso);

            return new Resultado($"Café preparado: {tamañoVaso} con {cucharadasAzucar} cucharadas de azúcar. Felicitaciones!");
        }
    }
}
