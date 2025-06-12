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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("BIENVENID@ al Arcade Lunaselter, elige una opción:");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Ver juegos");
                Thread.Sleep(500);
                Console.WriteLine("2. Ver créditos");
                Thread.Sleep(500);
                Console.WriteLine("0. Salir -(> <;-)");
                Console.WriteLine();
                menuop = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menuop)
                {
                    case 1:
                        juegos.JuegosMenu();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("           * --------------------------------------------- CRÉDITOS --------------------------------------------- *");
                        Console.WriteLine("           |                                                                                                      |");
                        Console.WriteLine("           |                                                                                                      |");
                        Console.WriteLine("           |     ->  C U R S O : Fundamento de algoritmos                                                         |");
                        Thread.Sleep(300);
                        Console.WriteLine("           |                                                                                                      |");
                        Console.WriteLine("           |     ->  A U T O R E S:                                                                               |");
                        Thread.Sleep(300);
                        Console.WriteLine("           |                                                                                                      |");
                        Console.WriteLine("           |        1. Anderson Jair Cruzado Alvarez                                                              |");
                        Thread.Sleep(300);
                        Console.WriteLine("           |        2. Neylin Yoselin Gavidia Saavedra                                                            |");
                        Thread.Sleep(300);
                        Console.WriteLine("           |        3. Luz Marita Sánchez Pérez                                                                   |");
                        Thread.Sleep(300);
                        Console.WriteLine("           |        4. Nataly Jhyre Solano Gómez                                                                  |");
                        Thread.Sleep(300);
                        Console.WriteLine("           |                                                                                                      |");
                        Console.WriteLine("           |                                                                                                      |");
                        Console.WriteLine("           * ------------------------------------------ THANKS SO MUCH ------------------------------------------ *");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("                                                  PRESIONA ENTER PARA SALIR");
                        Console.ReadKey();
                        Console.Clear();
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
                                Console.WriteLine("Sistema: Es una pena QwQ. Por favor, vuelve pronto ^^");
                                Thread.Sleep(1500);
                                Console.ReadKey();
                                Console.Clear();
                                return; //cierra el juego
                            }
                            else if (aux == 2)
                            {
                                Console.WriteLine("Sistema: Yay~ Ya te regreso al menú principal (/^^)/");
                                Thread.Sleep(1500); //aqui debe retornar al menu principal
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Sistema: Opción no válida, intentalo de nuevo");
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
            while (true);  //esto es en true y no con condiciones, ya que las condiciones se estan manejando desde el switch
            //ponerle condiciones en lugar de bool, repite lo que ya se repite xd es decir es redundante
        }
    }
}
