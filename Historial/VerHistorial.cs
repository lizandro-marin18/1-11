using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historial
{
    public class VerHistorial
    {
        public void Historial(ref string[] alertas, ref int contador)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Mostrando historial de eventos...\n");
            Console.ResetColor();
            for (int i = 0; i < alertas.Length; i++)
                {
                    if (string.IsNullOrEmpty(alertas[i]))
                    {
                        Console.WriteLine($"Alerta {i + 1}: [Vacío]");
                    }
                    else
                        Console.WriteLine($"Alerta {i + 1}: {alertas[i]}");
                }
                if (contador == 9)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine($"\nEl historial está lleno. Los elementos más antiguos se eliminarán automáticamente.");
                    Console.ResetColor();
                }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
