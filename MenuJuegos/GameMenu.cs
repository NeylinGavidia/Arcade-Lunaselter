﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuJuegos
{
    public class GameMenu
    {
        //Bibliotecas de juegos
        Juego1 Juego1 = new Juego1();
        Juego2 Juego2 = new Juego2();
        Juego3 Juego3 = new Juego3();
        Juego4 Juego4 = new Juego4();
        public void JuegosMenu() {

            int juegop;
            do
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Menú de juegos");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1. [A]lumine's Fate");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. Frutivinanza");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("3. M E M O R I C E");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("4. Life's Game");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                juegop = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (juegop)
                {
                    case 0:
                        Console.Clear();
                        return;
                    case 1: //Bibliotea juego 1
                        Juego1.Menu("cargando...");
                        Juego1.seleccion();
                        Console.Clear();
                        if (Juego1.intro("C A R G A N D O")) //esto es para cuando se rechaza seguir jugando / se debe hacer bool y condicionar
                        {
                            Juego1.tutorial();
                            Juego1.capitulo1();
                            Juego1.capitulo2();
                            if (Juego1.capitulo3("C A R G A N D O"))
                            {
                                Juego1.capitulo4();
                                Juego1.batallafinal("C A R G A N D O");
                                Console.WriteLine("------------------------ Sistema: Gracias por jugar :D ------------------------");
                                Thread.Sleep(2000);
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("------------------------ Sistema: Gracias por jugar :D ------------------------");
                                Thread.Sleep(2000);
                                Console.Clear();
                                return;
                            }

                        }
                        else
                        {
                            Console.WriteLine("------------------------ Sistema: Gracias por jugar :D ------------------------");
                            Thread.Sleep(2000);
                            Console.Clear();
                            return;
                        }
                    case 2: //Biblioteca juego 2

                        Juego2 juego = new Juego2();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Adivina la fruta!");
                        Thread.Sleep(300);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Pista: " + juego.ObtenerPista());
                        Thread.Sleep(300);
                        Console.WriteLine();

                        for (int intento = 1; intento <= 2; intento++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Intento: ¿Cuál es la fruta?");
                            Thread.Sleep(300);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            string respuesta = Console.ReadLine();

                            Console.Clear();

                            if (juego.Adivinar(respuesta))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine();
                                Console.WriteLine("¡Adivinaste!");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                if (intento == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("No adivinaste. Te queda 1 intento.");
                                    Thread.Sleep(300);
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Si estás segur@, por favor revisa la ortografía y acentuación~");
                                    Thread.Sleep(300);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("No adivinaste. La fruta era: " + juego.ObtenerFruta());
                                    Thread.Sleep(1000);
                                }
                            }
                        }

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        Console.WriteLine("Presiona cualquier tecla para salir...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3: //Biblioteca juego 3
                        int opcion;

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Escoger nivel de dificultad");
                            Console.WriteLine();
                            Thread.Sleep(300);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("1. Nivel Facil");
                            Thread.Sleep(300);
                            Console.WriteLine("2. Nivel Medio");
                            Thread.Sleep(300);
                            Console.WriteLine("3. Nivel Dificil");
                            Thread.Sleep(300);
                            Console.WriteLine("0. Salir");
                            Thread.Sleep(300);
                            Console.WriteLine();
                            opcion = int.Parse(Console.ReadLine());

                            switch (opcion)
                            {
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Saliendo...");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("¡Hasta pronto!");
                                    Thread.Sleep(1000);
                                    break;
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("A continuacion se mostraran 4 números. ¡PREPARATE!");
                                    Thread.Sleep(4000);
                                    Console.Clear();
                                    Console.Beep(800, 300);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Juego3.facil();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("A continuacion se mostraran 6 números, preparate");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.Beep(800, 300);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Juego3.medio();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A continuacion se mostraran 8 números, preparate");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.Beep(800, 300);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Juego3.dificil();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Opción no valida");
                                    Console.WriteLine();
                                    break;
                            }
                        } while (opcion != 0);
                        Console.Clear();
                        break;
                    case 4: //Biblioteca juego 4
                        int opcionMenu;

                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("======================================");
                            Console.WriteLine("   LA GRAN AVENTURA DE TU VIDA");
                            Console.WriteLine("======================================");
                            Console.ResetColor();
                            Thread.Sleep(300);
                            Console.WriteLine();
                            Console.WriteLine("1. Jugar");
                            Thread.Sleep(300);
                            Console.WriteLine("2. Salir");
                            Thread.Sleep(300);
                            Console.WriteLine();
                            Console.Write("Selecciona una opción: ");

                            if (!int.TryParse(Console.ReadLine(), out opcionMenu))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.WriteLine("Por favor, introduce un número válido.");
                                Console.ResetColor();
                                Console.ReadKey();
                                continue;
                            }

                            switch (opcionMenu)
                            {
                                case 1:
                                    Juego4.EjecutarJuego(Juego4);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine();
                                    Console.WriteLine("¡Gracias por jugar! Hasta la próxima.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Saliendo...");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    return;

                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Opción inválida. Intenta nuevamente.");
                                    Console.WriteLine();
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    break;
                            }

                        } while (true);
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Sistema: Opción no válida, intentalo de nuevo");
                        break;
                }
            }
            while (true); //misma condicion que en el menu principal, solo bool para no ser redundantes y poder regresar

        }
    }
}
