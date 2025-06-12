using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblio1;

namespace MenuJuegos
{
    public class GameMenu
    {
        Juego1 Juego1 = new Juego1();
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
                Console.WriteLine("2. ");
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
                        Juego1.intro("C A R G A N D O");
                        //esto es para cuando se rechaza seguir jugando //Console.WriteLine("------------------------ Sistema: Gracias por jugar :D ------------------------");
                        Juego1.tutorial();
                        Juego1.capitulo1();
                        Juego1.capitulo2();
                        Juego1.capitulo3("C A R G A N D O");
                        Juego1.capitulo4();
                        Juego1.batallafinal("C A R G A N D O");
                        break;
                    case 2: //Biblioteca juego 2

                        break;
                    case 3: //Biblioteca juego 3

                        break;
                    case 4: //Biblioteca juego 4

                        break;
                    case 0:
                        //retorno al menu principal
                        break;
                    default:
                        break;
                }
            }
            while (juegop != 0 && juegop != 1 && juegop != 2 && juegop != 3 && juegop != 4) ;
        }
    }
}
