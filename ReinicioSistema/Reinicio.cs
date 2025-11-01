using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinicioSistema
{
    public class Reinicio
    {
        public void ReinicioSensore() 
        {
            Console.WriteLine("Reinicio de sistema en curso...");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"Reiniciando en {i} segundos...");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
