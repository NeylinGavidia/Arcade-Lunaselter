using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblio1;
using Biblio2;

namespace MenuJuegos
{
    public class GameMenu
    {
        Juego1 Juego1 = new Juego1();
        Juego2 Juego2 = new Juego2();
        public void JuegosMenu() {

            int juegop;
            do
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Menú de juegos");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. [A]lumine's Fate");
                Thread.Sleep(500);
                Console.WriteLine("2. Adivina la fruta");
                Thread.Sleep(500);
                Console.WriteLine("3. ");
                Thread.Sleep(500);
                Console.WriteLine("4. ");
                Thread.Sleep(500);
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                juegop = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (juegop)
                {
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Adivina la fruta!");
                        Thread.Sleep(300);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Pista: " + Juego2.ObtenerPista());
                        Thread.Sleep(300);
                        Console.WriteLine();


                        for (int intento = 1; intento <= 2; intento++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Intento: ¿Cuál es la fruta? ");
                            Thread.Sleep(300);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            string respuesta = Console.ReadLine();

                            Console.Clear();

                            if (Juego2.Adivinar(respuesta))
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
                                    Console.WriteLine("No adivinaste. Te queda 1 intento."); Console.WriteLine();
                                    Thread.Sleep(300);
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Si estás segur@, por favor revisa la ortografía y acentuación~"); Console.WriteLine();
                                    Thread.Sleep(300);
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" No adivinaste. La fruta era: " + Juego2.ObtenerFruta());
                                    Thread.Sleep(1000);
                                    Console.WriteLine();
                                }
                            }

                        }
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Presiona cualquier tecla para salir...");
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3: //Biblioteca juego 3

                        break;
                    case 4: //Biblioteca juego 4

                        break;
                    case 0:
                        //retorno al menu principal
                        Console.Clear();
                        return;
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
