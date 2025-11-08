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
        public int cont=0;//contador para las alertas y numero que va dentro dentro del array (Longitud) de array
        public int s1, s2, s3, s4, s5;//para sacar valores de los sensores de temperatura
        public int h1, h2, h3, h4, h5;//para sacar valores de los sensores de humo
        //-----------------------------------------------------------------------------------------------------------------------------------
        Sonidos sonidos = new Sonidos();
        //-----------------------------------------------------------------------------------------------------------------------------------
        public void sensores_temp()
        {
            //70-90 estándar y de alerta 90
            Random random = new Random();
            do
            {
                // sensores de temperatura--------------------------------------------------------
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

                //sensores de humo --------------------------------------------------------------
                int sensorHumo1 = random.Next(10, 17);
                h1 = sensorHumo1;
                int sensorHumo2 = random.Next(10, 17);
                h2 = sensorHumo2;
                int sensorHumo3 = random.Next(10, 17);
                h3 = sensorHumo3;
                int sensorHumo4 = random.Next(10, 17);
                h4 = sensorHumo4;
                int sensorHumo5 = random.Next(10, 17);
                h5 = sensorHumo5;

                //---------------MAPA-------------------------------------------------------------

                Console.WriteLine("┌──────────────────────────────────────────────────────┐");
                Console.Write("|");
                if (sensor1 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    T1: " + sensor1+"°");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("    T1: " + sensor1+"°");
                    Console.ResetColor();
                }
                Console.Write("               |");
                if (sensor2 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("     T2: " + sensor2+"°");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("     T2: " + sensor2+"°");
                    Console.ResetColor();
                }
                Console.Write("               |");
                //humo----------------------------------------
                Console.Write("\n|");
                if (h1 > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    H1: " + h1+"%");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("    H1: " + h1+"%");
                    Console.ResetColor();
                }
                Console.Write("               |");
                if (h2 > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("     H2: " + h2+"%");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("     H2: " + h2+"%");
                    Console.ResetColor();
                }
                Console.Write("               |");

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
                    Console.Write("   T3: " + sensor3+"°");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("   T3: " + sensor3+"°");
                    Console.ResetColor();
                }
                Console.Write("  |");
                if (sensor4 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   T4: " + sensor4+"°");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("   T4: " + sensor4+"°");
                    Console.ResetColor();
                }
                Console.Write("   |");
                if (sensor5 > 90)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("        T5: " + sensor5+"°");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("        T5: " + sensor5+"°");
                    Console.ResetColor();
                }
                Console.Write("            |");
                //humo----------------------------------------

                Console.Write("\n|");
                if (h3 > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   H3: " + h3 + "%");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("   H3: " + h3 + "%");
                    Console.ResetColor();
                }
                Console.Write("  |");
                if (h4 > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   H4: " + h4 + "%");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("   H4: " + h4 + "%");
                    Console.ResetColor();
                }
                Console.Write("   |");
                if (h5 > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("        H5: " + h5 + "%");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("        H5: " + h5 + "%");
                    Console.ResetColor();
                }
                Console.Write("            |");

                Console.WriteLine("\n|            |             |                           |");
                Console.WriteLine("|  Sala 1    |  Sala 2     |        Máquinas 2         |");
                Console.WriteLine("|            |             |                           |");
                Console.WriteLine("|            |             |                           |");
                Console.WriteLine("└──────────────────────────────────────────────────────┘");


                //verificar si algun sensor supera el umbral de 90-------------------------------------
                if (sensor1 > 90 | sensor2 > 90 | sensor3 > 90 | sensor4 > 90 | sensor5 > 90 | h1 > 15 | h2 > 15 | h3 > 15 | h4 > 15 | h5 > 15)
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
            Console.WriteLine("\t\t\t\t┌─────────────────────────────────────────────┐");
            Console.WriteLine("\t\t\t\t|        ¡ALERTA DE TEMPERATURA!              |");
            Console.WriteLine("\t\t\t\t├─────────────────────────────────────────────┤");
            Console.Write("\t\t\t\t|   Luces estroboscópicas encendidas ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("   ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("      |");
            //Console.ResetColor();
            Console.WriteLine("\n\t\t\t\t├─────────────────────────────────────────────┤");
            Console.Write("\t\t\t\t|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("           Evacuando personal");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                |\n");
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t|           REINICIE EL SISTEMA               |");
            //Console.ResetColor();
            Console.WriteLine("\t\t\t\t└─────────────────────────────────────────────┘");
            Console.ResetColor();


            //--------------Lugar de riesgo----------------------------------------------------------------
           
            
            Console.Write("\n\n\t\t\t\tAlmacén:    ");
            if (s1 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Temperatura: " + s1 + "° ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Temperatura: " + s1 + "° ");
            }
            if (h1 > 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Humo: "+h1+"%");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  Humo: "+h1+"%");
            }
            Console.ResetColor();
            //maquinas 1----------------------------------------------------------------
            Console.Write("\n\t\t\t\tMáquinas 1: ");
            if (s2 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Temperatura: " + s2 + "° ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Temperatura: " + s2 + "° ");
            }
            if (h2 > 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Humo: "+h2+"%");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  Humo: "+h2+"%");
            }
            Console.ResetColor();
            //sala 1----------------------------------------------------------------
            Console.Write("\n\t\t\t\tSala 1:     ");
            if (s3 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Temperatura: " + s3 + "° ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Temperatura: " + s3 + "° ");
            }
            if (h3 > 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Humo: "+h3+"%");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  Humo: "+h3+"%");
            }
            Console.ResetColor();
            //sala 2----------------------------------------------------------------
            Console.Write("\n\t\t\t\tSala 2:     ");
            if (s4 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Temperatura: " + s4 + "° ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Temperatura: " + s4 + "° ");
            }
            if (h4 > 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Humo: "+h4+"%");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  Humo: "+h4+"%");
            }
            Console.ResetColor();
            //maquinas 2----------------------------------------------------------------
            Console.Write("\n\t\t\t\tMáquinas 2: ");
            if (s5 > 90)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Temperatura: " + s5 + "° ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Temperatura: " + s5 + "° ");
            }
            if (h5 > 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  Humo: "+h5+"%");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  Humo: "+h5+"%");
            }
            Console.ResetColor();
            Console.WriteLine("\n\n\n\t\tPresione una tecla para llamar a la bomberos");
            Console.ReadKey();
            Console.Clear();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
       
        
        public void Reporte()
        {
            if (cont == 9)
            {
                for (int i = 0; i < alertas.Length ; i++)
                {
                    alertas[i] = null;
                }
                cont = 0;
            }
            alertas[cont] = DateTime.Now.ToString();
            cont++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\t\t\t\t┌────────────────────────────────────────────┐");
            Console.WriteLine("\t\t\t\t│Reporte del caso:                           │");
            Console.WriteLine("\t\t\t\t│Fecha y hora: " + DateTime.Now + "            │");
            Console.WriteLine("\t\t\t\t│Llamando a los bomberos...                  │");
            Console.WriteLine("\t\t\t\t└────────────────────────────────────────────┘");
            sonidos.ReproducirLLamada();
            Console.Clear();
        }
    }
}
