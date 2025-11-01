using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Multimedia;

namespace Monitoreo
{
    public class Sensores
    {
        public String[] alertas = new String[9];//arreglo para guardar las alertas
        public int cont=0;//contador para las alertas
        public int s1, s2, s3, s4, s5;//para sacar valores de los sensores
        //-----------------------------------------------------------------------------------------------------------------------------------
        Sonidos sonidos = new Sonidos();
        public void sensores_temp()
        {
            //70-90 estándar y de alerta 90
            Random random = new Random();
            do
            {
                int sensor1 = random.Next(10, 99);
                s1 = sensor1;
                int sensor2 = random.Next(10, 99);
                s2 = sensor2;
                int sensor3 = random.Next(10, 99);
                s3 = sensor3;
                int sensor4 = random.Next(10, 99);
                s4 = sensor4;
                int sensor5 = random.Next(10, 99);
                s5 = sensor5;
                //---------------MAPA-------------------------------------------------------------

                Console.WriteLine("┌──────────────────────────────────────────────────────┐");
                Console.Write("|");
                if (sensor1 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("     S1: " + sensor1);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("     S1: " + sensor1);
                    Console.ResetColor();
                }
                Console.Write("               |");
                if (sensor2 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("     S2: " + sensor2);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("     S2: " + sensor2);
                    Console.ResetColor();
                }
                Console.Write("                |");
                Console.WriteLine("\n|                          |                           |");
                Console.WriteLine("|                          |                           |");
                Console.WriteLine("|        Almacén           |        Máquinas 1         |");
                Console.WriteLine("|                          |                           |");
                Console.WriteLine("|                          |    ____________________   |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|   ---------|   ----------|    --------------------   |");
                Console.Write("|");
                if (sensor3 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    S3: " + sensor3);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("    S3: " + sensor3);
                    Console.ResetColor();
                }
                Console.Write("  |");
                if (sensor4 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    S4: " + sensor4);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("    S4: " + sensor4);
                    Console.ResetColor();
                }
                Console.Write("   |");
                if (sensor5 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("         S5: " + sensor5);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("         S5: " + sensor5);
                    Console.ResetColor();
                }
                Console.Write("            |");
                Console.WriteLine("\n|            |             |                           |");
                Console.WriteLine("|  Sala 1    |  Sala 2     |        Máquinas 2         |");
                Console.WriteLine("|            |             |                           |");
                Console.WriteLine("|            |             |                           |");
                Console.WriteLine("└──────────────────────────────────────────────────────┘");


                //verificar si algun sensor supera el umbral de 90-------------------------------------
                if (sensor1 > 90 | sensor2 > 90 | sensor3 > 90 | sensor4 > 90 | sensor5 > 90)
                {
                    sonidos.ReproducirAlerta();
                    break;
                }

                //tiempo de reinicio del mapa------------------------------------------------------------
                Thread.Sleep(1000);
                Console.Clear();
                Console.ResetColor();
            }
            while (true);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public void alerta_temp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("┌─────────────────────────────────────────────┐");
            Console.WriteLine("|        ¡ALERTA DE TEMPERATURA!              |");
            Console.WriteLine("├─────────────────────────────────────────────┤");
            Console.Write("|   Luces estroboscópicas encendidas ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("   ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("      |");
            Console.ResetColor();
            Console.WriteLine("\n├─────────────────────────────────────────────┤");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("           Evacuando personal");
            Console.ResetColor();
            Console.Write("                |\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|           REINICIE EL SISTEMA               |");
            Console.ResetColor();
            Console.WriteLine("└─────────────────────────────────────────────┘");

            //--------------Lugar de riesgo----------------------------------------------------------------
            Console.Write("\nAlmacén:    ");
            if (s1 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(s1 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: Si");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(s1 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: No");
            }

            Console.ResetColor();
            Console.Write("\nMáquinas 1: ");
            if (s2 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(s2 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: Si");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(s2 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: No");
            }

            Console.ResetColor();
            Console.Write("\nSala 1:     ");
            if (s3 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(s3 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: Si");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(s3 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: No");
            }

            Console.ResetColor();
            Console.Write("\nSala 2:     ");
            if (s4 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(s4 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: Si");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(s4 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: No");
            }

            Console.ResetColor();
            Console.Write("\nMáquinas 2: ");
            if (s5 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(s5 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: Si");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(s5 + "°");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("  Humo: No");
            }

            Console.ResetColor();
            Console.WriteLine("\n\nPresione una tecla para llamar a la bomberos");
            Console.ReadKey();
            Console.Clear();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        public void Reporte()
        {
            alertas[cont] = DateTime.Now.ToString();
            cont++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reporte del caso:");
            Console.WriteLine("Fecha y hora: " + DateTime.Now);
            Console.WriteLine("Llamando a los bomberos...");
            sonidos.ReproducirLLamada();
            Console.Clear();
        }
    }
}
