using Monitoreo;
using ReinicioSistema;
using Historial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace User
{
    public class Menu
    {
        public void Menu1()
        {
            int opcion0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t┌──────────────────────────────────┐");
                Console.WriteLine("\t\t\t\t│Bienvenido al sistema de monitoreo│");
                Console.WriteLine("\t\t\t\t└──────────────────────────────────┘");
                Console.ResetColor();
                Console.Write("\n\t\t | 1) Iniciar sesión \n\t\t | 0) Salir\n\t\t");
                opcion0 = int.Parse(Console.ReadLine());
                //--------------------------------------------------------------------

                switch (opcion0)
                {
                    case 1:
                        UserLogin();
                        Menucito();
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\tOpción no válida");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            } while (opcion0 != 0);
        }
        static void UserLogin()
        {
            string usuario, contraseña;
            Console.Clear();
            do {
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t┌─────────────────────────────");
                Console.Write("\t\t│ Ingrese su usuario: ");
                usuario = Console.ReadLine();
                Console.Write("\t\t│ Ingrese su contraseña: ");


                contraseña = "";
                ConsoleKeyInfo tecla; //Variable para guardar la tecla presionada

                do
                {
                    tecla = Console.ReadKey(true); //Lee la tecla presionada, true evita que se muestre

                    if (tecla.Key == ConsoleKey.Backspace && contraseña.Length > 0) //Maneja la tecla Backspace (Borrar)
                    {
                        contraseña = contraseña.Substring(0, contraseña.Length - 1); //Borra el último caracter de la variable
                        Console.Write("\b \b"); //Mueve el cursor hacia atrás, escribe un espacio para borrar el * y vuelve a mover el cursor hacia atrás.
                    }
                
                    else if (tecla.Key != ConsoleKey.Backspace && tecla.Key != ConsoleKey.Enter)
                    {
                        
                        contraseña += tecla.KeyChar; // Guarda la tecla en la variable
                        Console.Write("*");
                    }

                } while (tecla.Key != ConsoleKey.Enter);

                Console.WriteLine();
                Console.WriteLine("\t\t│");
                Console.Write("\t\t│");
                Console.ResetColor();

                if (usuario == "admin" && contraseña == "123")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Inicio de sesión exitoso\n");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Usuario o contraseña incorrectos\n");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    Console.Clear();
                }
            }while(true);
        }
        static void Menucito()
        {
            Sensores sensores = new Sensores();
            Reinicio reinicio = new Reinicio();
            VerHistorial historial = new VerHistorial();
            int opcion1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t┌──────────────┐");
                Console.WriteLine("\t\t\t\t│Menú Principal│");
                Console.WriteLine("\t\t\t\t└──────────────┘");
                Console.Write("\t\t|1) Monitorear \n\t\t|2) Reiniciar sistema\n\t\t|3) Historial de alertas\n\t\t|0) Salir\n\t\t");
                Console.ResetColor();
                opcion1 = int.Parse(Console.ReadLine());
                switch (opcion1)
                {
                    case 1:
                        Console.Clear();
                        sensores.sensores_temp();
                        sensores.alerta_temp();
                        sensores.Reporte();
                        break;
                    case 2:
                        Console.Clear();
                        reinicio.ReinicioSensore();
                        break;
                    case 3:
                        Console.Clear();
                        historial.Historial(ref sensores.alertas, ref sensores.cont);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\tOpción no válida");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }
            while (opcion1 != 0);
        }
    }
}
