using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Arcade_Lunaselter;
using Nombre_Arcade;
using MenuJuegos;

namespace Arcade_Lunaselter
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menuop, aux;
            
            //Bibliotecas

            Title princi = new Title();
            GameMenu juegos = new GameMenu();
            
            //TITULO

            Console.Title = "PROFE, APRUEBENOS";
            princi.Titulo("LOADING");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.ReadKey();
            Console.Clear();

            //FIN DEL TITULO 

            //MENU PRINCIPAL

            do
            {
                Console.WriteLine();
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                Console.WriteLine("BIENVENID@ al Arcade Lunaselter, elige una opción:");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Ver juegos");
                Thread.Sleep(500);
                Console.WriteLine("2. Ver créditos");
                Thread.Sleep(500);
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                menuop = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menuop)
                {
                    case 1:
                        juegos.JuegosMenu();
                        break;
                    case 2:

                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Sistema: ¿Estás segur@? T^T");
                        Console.WriteLine();
                        Thread.Sleep(500);

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("|1. Si | 2. No|");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            aux = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine();
                            if (aux == 1)
                            {
                                Console.WriteLine("Sistema: Es una pena :c. Por favor, vuelve pronto ^^");
                                Thread.Sleep(1500);
                                return; //cierra el juego
                            }
                            else if (aux == 2)
                            {
                                Console.WriteLine("Sistema: Yay~ Ya te regreso al menú principal (/^^)/");
                                Thread.Sleep(1500); //aqui debe retornar al menu comun
                                
                            }
                        }
                        while (aux != 1 && aux != 2);
                            break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Sistema: Opción no válida, intentalo de nuevo");
                        break;
                }
            }
            while (menuop != 0 && menuop !=1 && menuop !=2);  
        }
    }
}
