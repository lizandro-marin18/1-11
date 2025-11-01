using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historial
{
    public class VerHistorial
    {
        public void Historial(ref string[] alertas)
        {
            Console.WriteLine("Mostrando historial de eventos...");
            if (alertas.Length == 0)
            {
                Console.WriteLine("No hay alertas registradas.");
            }
            else
            {
                for (int i = 0; i < alertas.Length; i++)
                {
                    if (string.IsNullOrEmpty(alertas[i]))
                    {
                        Console.WriteLine($"Alerta {i + 1}: [Vacío]");
                    }
                    else
                        Console.WriteLine($"Alerta {i + 1}: {alertas[i]}");
                }
            }
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
