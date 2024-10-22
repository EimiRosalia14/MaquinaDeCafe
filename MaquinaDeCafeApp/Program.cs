using System;

namespace MaquinaDeCafeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var maquinaDeCafe = new MaquinaDeCafe();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== Bienvenido a la Máquina de Café ====");
                Console.WriteLine("Por favor selecciona el tamaño del vaso:");
                Console.WriteLine("1. Pequeño (3 oz)");
                Console.WriteLine("2. Mediano (5 oz)");
                Console.WriteLine("3. Grande (7 oz)");
                Console.Write("Selección: ");
                string tamañoSeleccionado = Console.ReadLine();

                string tamañoVaso = tamañoSeleccionado switch
                {
                    "1" => "Pequeño",
                    "2" => "Mediano",
                    "3" => "Grande",
                    _ => "Mediano"
                };

                Console.Write("¿Cuántas cucharadas de azúcar deseas? (0-5): ");
                int cantidadAzucar = int.Parse(Console.ReadLine());

                // Verificar disponibilidad de café, azúcar y vasos
                if (!maquinaDeCafe.Cafetera.HayCafe(maquinaDeCafe.SeleccionarTamañoVaso(tamañoVaso).Oz))
                {
                    Console.WriteLine("Error: No hay suficiente café.");
                }
                else if (!maquinaDeCafe.Azucarero.HayAzucar(cantidadAzucar))
                {
                    Console.WriteLine("Error: No hay suficiente azúcar.");
                }
                else if (maquinaDeCafe.CantidadVasos() == 0)
                {
                    Console.WriteLine("Error: No hay vasos disponibles.");
                }
                else
                {
                    // Preparar el café
                    maquinaDeCafe.SeleccionarAzucar(cantidadAzucar);
                    maquinaDeCafe.ConsumirVaso(tamañoVaso);
                    maquinaDeCafe.Cafetera.ConsumirCafe(maquinaDeCafe.SeleccionarTamañoVaso(tamañoVaso).Oz);

                    Console.WriteLine($"¡Tu café {tamañoVaso} con {cantidadAzucar} cucharadas de azúcar está listo!");
                }

                // Preguntar si desea continuar
                Console.WriteLine("\n¿Deseas preparar otro café? (S/N): ");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "S")
                {
                    continuar = false;
                }
            }

            Console.WriteLine("Gracias por usar la máquina de café. ¡Que tengas un buen día!");
        }
    }
}