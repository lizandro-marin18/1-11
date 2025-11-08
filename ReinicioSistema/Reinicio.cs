using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReinicioSistema
{
    public class Reinicio
    {
        public void ReinicioSensore() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\t┌────────────────────────────────────────────┐");
            Console.WriteLine("\t│Iniciando proceso de reinicio de sensores...│");
            Thread.Sleep(1000);
            Console.WriteLine("\t│Reinicio de sistema en curso...             │");
            Thread.Sleep(1000);
            Console.WriteLine("\t│                                            │");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"\t│Reiniciando sensor de temperatura {i}...      │");
                Console.WriteLine($"\t│Reiniciando sensor de humo {i}...             │");
                Console.WriteLine("\t│                                            │");
                Thread.Sleep(1500);

            }
            Console.WriteLine("\t│                                            │");
            Console.WriteLine("\t│Reinicio completado con éxito.              │");
            Console.WriteLine("\t│Todos los sensores están operativos.        │");
            Console.WriteLine("\t└────────────────────────────────────────────┘");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tPresiona cualquier tecla para continuar...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
