using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblio1
{
    public class Juego1
    {
        int pve = 100; //boss principal
        int atqe = 50;
        int defe = 40;
        int pv = 60; //prota
        int atq = 20;
        int def = 20;
        int epv = 70; //boss secreto
        int eatq = 40;
        int edef = 20;
        int alt1, alt2, v1, v2, f1, f2, apv;
        int clase, afir, op1, op2, op3, op4, confir, op5, op6;
        public string name, obj;
        public void Menu(string load)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                          *******************************************");
            Thread.Sleep(500);
            Console.WriteLine("                                 Bienvenid@ a [A]Lumine's Fate ^^");
            Thread.Sleep(1000);
            Console.WriteLine("                          *******************************************");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            string inicio = ("                                           "); //para hacer que parezca escrito letra por letra
            for (int I = 0; I < inicio.Length; I++)
            {
                Console.Write(inicio[I]);
                Thread.Sleep(30);
            }
            for (int i = 0; i < load.Length; i++)
            {
                Console.Write(load[i]);
                Thread.Sleep(80);
            }
            string final = ("                                            ");
            for (int J = 0; J < final.Length; J++)
            {
                Console.Write(final[J]);
                Thread.Sleep(30);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void seleccion()
        { //elegir clase para conseguir el arma conforme a eso

            Thread.Sleep(2500);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("Antes de comenzar la historia elige una clase:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("(NOTA: No influye en la historia)");
            Console.WriteLine();
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1) Mago/a " + "2) Arquero/a " + "y 3) Espadachin");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                clase = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (clase)
                {
                    case 1:
                        obj = "Bastón";
                        break;
                    case 2:
                        obj = "Arco";
                        break;
                    case 3:
                        obj = "Espada";
                        break;
                    default:
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Elije una opcion válida");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        break;
                }
            }
            while (clase != 1 && clase != 2 && clase != 3);
            Console.Clear();
            Console.WriteLine("Por favor ingrese su nombre");
            Console.WriteLine();
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                                          WELCOME");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("                              ------------------------------");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                           " + name);
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(1000);
            Console.WriteLine("                              ------------------------------");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                               PRESIONA ENTER PARA CONTINUAR");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                                     This is your FATE");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                            " + name);
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                     ¿Escuchas mi voz?");
            Thread.Sleep(50);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                            " + name);
            Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("                                   No te pierdas en el camino");
            Thread.Sleep(10);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                           Suerte");
            Thread.Sleep(10);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                           ************************************");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                             -------------------------------");
            Console.WriteLine("                            | PRESIONA ENTER PARA CONTINUAR |");
            Console.WriteLine("                             -------------------------------");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                           ************************************");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey();
        }
        public bool intro(string carga) //intro de la historia
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("                        " + name + " despierta...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                              " + name);
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                            Despierta");
            Thread.Sleep(500);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("                            ¡Despierta!                               ");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Abres los ojos y ves un cielo de diferente tonalidades de azul sobre ti.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Parecían manchas oscuras repartidas desordenamente sobre el claro cielo, como si fuese una pintura frustrada");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Tus pensamientos se cortan cuando escuchas una voz a tu lado");
            Thread.Sleep(500);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("- Hola, visitante celestial... tuviste una caída muy fuerte del cielo. ¿Cómo llegaste aquí?");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Miras a la criatura flotante sobre ti, sin saber que decir.");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("- ¿Quizás no sabes hablar? Mmmm... bueno, soy Ylx, un Opus ");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine("[criaturas casi diminutas con aspecto de esfera de luz de energía y flotantes]");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("A pesar de que la esfera de luz no tenía rasgos faciales.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("De alguna manera podías intuir sus estados de ánimo");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Ylx (´ v ´)9");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(": Vamos, ya me presente... Ahora es tu turno, cuéntame sobre ti visitante, ¿cuál es tu nombre?");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Cyan; Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-- Soy " + name + " --");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (~ v ~)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Es un gusto, " + name + ". Gracias por venir cuando más lo necesitabamos...");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx t(>  < t)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": En realidad... el pueblo de Lyos, ha sido condenado debido a Arphes, él era un antiguo héroe nos rescató de la primera calamidad.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (T ~ T)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(": Pero lamentablemente fue corrompido por la podredumbre, y se convirtió en Ynfamous, desde entonces cada día parece más oscuro...");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Ylx: (suspira y mira el cielo)");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (; v ;)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": El sol está desapareciendo lentamente... Pero ahora estás aquí ¡Yay!~");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (+ v +)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Por favor, ayúdanos a restaurar la paz en el pueblo de Lyos, visitante celestial");
            Thread.Sleep(500);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            //es importante el repetir
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¿Aceptas la misión?");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("1) Si / 2) No");
                Console.WriteLine();
                afir = int.Parse(Console.ReadLine()); //confirmacion de seguir adelante
                Console.Clear();
                switch (afir)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkGreen; Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("La misión {Salva al pueblo de Lyos} ha sido agregada");
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (^ ^)/");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Gracias, gracias " + name + ". Yo me encargaré de guiarte en la travesía. Primero debemos ir al pueblo de Lyos");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (-v-)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Estoy seguro de que tú eres quien nos salvará, después de todo, no todos los días caen personas del cielo");
                        Thread.Sleep(500);
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("Mientras van conversando, caminan entre el bosque, hasta divisar un pequeño pueblo a lo lejos");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("Se acercan al lugar");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("El bosque parece denso, no hay muchos espacios por donde la luz pueda entrar");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("Tus pensamientos son interrumpidos por Ylx");
                        Thread.Sleep(500);
                        return true;
                    case 2: //Aqui debe regresar al menu principal
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ylx ^ ^: Así que no...");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("- ... ¿No eres cruel?");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("- Quizás tú también seas un demonio...");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("- Entonces, solo desaparece.");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Tu vista se nubla y de pronto eres teletransportad@ al Abismo de Deal");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("Ves como un grupo de demonios se acerca a ti y te arrastra hacia abajo");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("Mientras sientes desesperación todo a tu alrededor se vuelve negro");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Yellow;
                        string inicio = ("                                           ");
                        for (int I = 0; I < inicio.Length; I++)
                        {
                            Console.Write(inicio[I]);
                            Thread.Sleep(30);
                        }
                        for (int i = 0; i < carga.Length; i++)
                        {
                            Console.Write(carga[i]);
                            Thread.Sleep(80);
                        }
                        string final = ("                                            ");
                        for (int J = 0; J < final.Length; J++)
                        {
                            Console.Write(final[J]);
                            Thread.Sleep(30);
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Sistema: Has obtenido el");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Final Malo 1:"); Console.WriteLine(" Aprendiendo a hacer favores");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("Sistema: Quizás deberías intentar ser más amable la siguiente vez.");
                        Console.WriteLine();
                        return false; //falta ver como hacer que se regrese al menu principal despues de este caso
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                        Console.WriteLine();
                        break;
                }
            }
            while (true);
        }
        public void tutorial()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Write("Ylx ('u')");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(": Estamos en el bosque de la penumbra");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" (JAJA los creadores no tenían muchas ideas~)");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (+ +)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(": Oh~ puedes verlo también " + name + ". Ese es un ente~");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine(" [espíritus muertos por podredumbre que vagan en Lyos]");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (*v*)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Una oportunidad de practicar~, los entes son criaturas generalmente débiles~");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (^0^)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Es tu momento de brillar, yo estaré aquí para ayudarte~ ¡Tú puedes!");
            Thread.Sleep(500);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("El ente te ha visto y viene hacia ti (Ylx te hace porras de fondo, y te mira expectante)");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("No tienes más armas que tu puño limpio");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("¿Qué quieres hacer?");
            Thread.Sleep(500);
            do
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Ente desconocido");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("[Alma en pena]");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("1. Atacar");
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" (Ylx: Deberías elegir esta)");
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(300);
                Console.Write("2. Huir");
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" (Ylx: No la recomiendo)");
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("3. Escabullirse");
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" (Ylx: Bueno, si no hay de otra)");
                Thread.Sleep(300);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                op1 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (op1)
                {
                    case 1:
                        atq = atq + 5;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (^ ^)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Lo lograste, siempre confíe~");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (0.0)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": ¿Eso es lo que creo que es?");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Te acercas hacia Ylx, y coges el objeto caído");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[" + obj + " ha sido añadido a tu inventario (+5 atq)]");
                        Console.WriteLine(); Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (^ ^)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Sigamos avanzando hacia el bosque~");
                        Thread.Sleep(500);
                        return;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (-''-)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Emmmmm..........");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx ('-.-)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Solo sigamos avanzando...");
                        Thread.Sleep(550);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        return;
                    case 3:
                        def = def + 5;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (. - .)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": No fue lo más valiente, pero...");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (0.0)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": ¿Ves eso?");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Te acercas hacia Ylx, y coges el objeto caído");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Un amuleto ha sido añadido a tu inventario (+5 def)]");
                        Thread.Sleep(500);
                        Console.WriteLine(); Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (^ ^)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Sigamos avanzando hacia el bosque~");
                        Thread.Sleep(500);
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                        break;
                }

            }
            while (true); //si cambias a true tendras que poner return o eso presumo
        }
        public void capitulo1()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Junto a Ylx avanzan por el puente para adentrarse en el espesor de bosque");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (= v =)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Esto me hace recordar~ se dice que el anterior héroe también camino por este bosque a derrotar a la calamidad");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (* *)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Fue guiado por un Opus también hehe~ ¿Crees que seamos iguales?");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (+ +)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Espero que sí~ pero sin lo malo~ La codicia y la cobardía hacen a uno flaquear siempre~");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (^ ^)/");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Nosotros no tambalearemos en nuestra voluntad, ¿verdad?");
            Thread.Sleep(800);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("El ambiente se llena de comodidad gracias a la charla de Ylx");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Casi al final del bosque, se divisa un camino que esta obstaculizado por una piedra y un árbol");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("También parece haber un puente al lado izquierda, aunque no se ve demasiado estable.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (-''-)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Tsk, podría intentar abrir el camino o escalar. Mmmm... ¿o vemos el otro camino?");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (-n-)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": AGHHHHHHHHHH, demasiado que pensar...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine();
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Ylx (' v ')");
                Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(": ¿Qué quieres hacer tú?");
                Thread.Sleep(800);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Intentar romper la piedra");
                Thread.Sleep(300);
                Console.WriteLine("2. Ir por el puente");
                Thread.Sleep(300);
                Console.WriteLine("3. Trepar el árbol");
                Thread.Sleep(300);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                op2 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (op2)
                {
                    case 1:
                        pv = pv + 20;
                        Console.WriteLine("Era una piedra muy débil, así que la rompes con facilidad");
                        Console.WriteLine();
                        Thread.Sleep(800);
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (o - o)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Increíble, tienes súper fuerza~ ¡Mira, Mira! Algo brilla ahí");
                        Thread.Sleep(800);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Te acercas a revisar el objeto, parece ser un anillo");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[El anillo ha sido añadido a tu inventario (+20 pv)]");
                        Console.WriteLine(); Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (~^ ^)/");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Esto es genial~ Parece que podemos ir hacia el castillo ahora. Let's gooo");
                        Thread.Sleep(500);
                        return;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx ('v')");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Así que probaremos el camino nuevo~");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (0-0)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Espera hay un globin ahí, tengamos cuidado");
                        Console.ReadKey();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Globin ladrón");
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("[Pequeño diablillo verde]");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("1. Atacar");
                            Thread.Sleep(300);
                            Console.WriteLine("2. Esconderse");
                            Thread.Sleep(300);
                            Console.Write("3. Robar");
                            Thread.Sleep(300);
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" (Ylx 0 - 0)");
                            Thread.Sleep(300);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Black;
                            op3 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine();
                            switch (op3)
                            {
                                case 1:
                                    atq = atq + 10;
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (>v<)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Lo hiciste YAYYYYYYYYY~ Estos goblins, creen que pueden andar libremente");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (* *)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": También hay un botín ehe~");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Te pruebas el casco del globin. Te queda perfectamente");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("[El casco ha sido añadido a tu inventario (+10 atq)]");
                                    Console.WriteLine(); Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (+ +)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Ahora hacia el castillo~");
                                    Thread.Sleep(500);
                                    break;
                                case 2:
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (. _ .)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Puffff.... casi nos ve");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx ('-.-)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Estoy agotado, vamos hacia el castillo rápido");
                                    Thread.Sleep(550);
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    atq = atq - 5;
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (' - ')");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Algo no parece estar bien...");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (0.0)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Se dio cuenta, corre, corre");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("El goblin enojado comienza a perseguirlos, mientras corren al castillo");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("[Una decisión justa... pero no adecuada de un héroe (-5 atq)]");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Thread.Sleep(500);
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                                    break;
                            }
                        }
                        while (op3 != 1 && op3 != 2 && op3 != 3);
                        return;
                    case 3:
                        atq = atq - 5;
                        def = def - 5;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Decides comenzar a trepar el árbol");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (o o)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Esperaaaa");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Cuando pisaste una rama y rompiste parte de ella, el árbol destelló hasta marchitarse");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (0-0)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Nononononononono, ese era un árbol bendito");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Todo alrededor comenzó a podrirse y desfallecer. Ese árbol mantenía el área viva.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Deberías cuidar el ambiente ^^ no seas egoísta (-5 atq y -5 def)]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (-''-)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Vayamos hacia el castillo, si la podredumbre nos atrapa, seremos corrompidos.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                        Console.WriteLine();
                        break;
                }
            }
            while (true);
        }
        public void capitulo2()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Antes de entrar al castillo, ambos pudieron visualizar una pequeña fogata y ambos se acercan con interés");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Entonces lo vieron, un hombre con piel llena de manchas oscuras y casi moribundo");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (0~0)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": Ese hombre parece ser afectado por podredumbre, quizás deberíamos rodear");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            do
            {
                Console.BackgroundColor = ConsoleColor.Cyan; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("El hombre, casi ciego, se levantó y sacó una espada, preguntando quien esta ahí");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Pasar de largo sigilosamente");
                Thread.Sleep(300);
                Console.WriteLine("2. Atacar");
                Thread.Sleep(300);
                Console.WriteLine("3. Hablar");
                Thread.Sleep(300);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                op4 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (op4)
                {
                    case 1:
                        Console.WriteLine("Deciden silenciar sus pasos y pasar por la puerta principal, hacia el interior del castillo");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        Console.Write("Ylx ('n')");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Por suerte, logramos librarnos de él~ parecía ser un traidor.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        return;
                    case 2:
                        pv = pv - 5;
                        atq = atq - 10;
                        def = def - 10;
                        Console.WriteLine("Sacaste tu arma, y atacaste primero, aprovechando su falta de visión");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.Write("Ylx (0-0)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Eso no era necesario... Para nada...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("El hombre cayó, mientras susurraba 'Arphes' y sus ojos se apagaron");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Mataste un inocente. Se aplica una maldición (-10 def, -10 atq, - 5 PV)]");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        return;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (´n´)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": No amenaces a la persona que nos salvará, baja esa espada, ser corrompido");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.WriteLine("El hombre pareció sorprendido al ver a un Opus, y casi enseguida se sentó de nuevo en la fogata y habló.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("- Corrompido");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(": Perdone mi acto, no se ven forasteros por esta zona, solo a seres corrompidos como yo.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("- Corrompido");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(": Soy Lyndur, llevo años peleando contra los seres corrompidos, para que no invadan Lyos.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Lyndur");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(": Pronto moriré... quizás es mi penitencia... después de todo no detuve Arphes y elegí huir para salvarme.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Lyndur");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(": Tuve miedo y deje a mi querido amigo corromperse, todas estas manchas son evidencia de mi cobardía...");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Lyndur");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(": ... No merezco pedirlo, pero ¿podría darme un poco de su luz?");
                        Thread.Sleep(800);
                        Console.ReadKey();
                        Console.Clear();
                        do
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Lyndur");
                            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("[Traidor moribundo]");
                            Thread.Sleep(800);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("¿Aceptas darle tu luz?");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("1) Si / 2) No");
                            Console.WriteLine();
                            confir = int.Parse(Console.ReadLine()); //confirmación para seguir
                            Console.Clear();
                            Console.WriteLine();
                            switch (confir)
                            {
                                case 1:
                                    pv = pv - 5;
                                    atq = atq + 10;
                                    def = def + 10;
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Lyndur");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine(": ¿En serio?... ¡Gracias! Muchas gracias, ser bendecido.");
                                    Thread.Sleep(800);
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Lyndur");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine(": Gracias a usted, al fin podré limpiar mis pecados, y volveré a casa, con mi familia...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (´-´)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Mhffff... si estás de acuerdo con ello entonces, solo tengo que también apoyarte...");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Thread.Sleep(800);
                                    Console.WriteLine();
                                    Console.WriteLine("Ylx se acerca a ti y crea una conexión entre tú y Lyndur");
                                    Console.WriteLine();
                                    Thread.Sleep(800);
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (-´-)");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Bueno, ya está...");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Thread.Sleep(1000);
                                    Console.WriteLine();
                                    Console.WriteLine("[Has perdido algo de luz (-5 PV, +10 atq, + 10 def)]");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine();
                                    Console.WriteLine("Una horda de seres corrompidos fueron atraídos por la luz, y se dirigían hacia ustedes");
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Lyndur");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine(": Vayan dentro, yo me quedaré a cuidar aquí. Por favor liberen a Lyos y Arphes.");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Thread.Sleep(800);
                                    Console.WriteLine();
                                    Console.WriteLine("Asienten y corres junto a Ylx hacia el interior, mientras ves a Lyndur pelear contra los corrompidos");
                                    return;
                                case 2:
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Lyndur");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine(": Entiendo... sé que no merezco compasión, he cometido el pecado más grande de todos...");
                                    Thread.Sleep(800);
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Lyndur");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine(": Gracias por haberme escuchado, espero puedan salvar a Arphes.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Una horda de seres corrompidos aparecieron, y se dirigían hacia ustedes");
                                    Console.WriteLine();
                                    Thread.Sleep(800);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Lyndur");
                                    Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine(": Vayan dentro, al menos haré que mi muerte, valga la pena. Dejen arreglar mis errores.");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Thread.Sleep(800);
                                    Console.WriteLine();
                                    Console.WriteLine("Él sonrie, mientras corres junto a Ylx, una vez dentro, vez como Lyndur cierra la puerta antes de ser atravesado pr una lanza.");
                                    return;
                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        while (true);
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                        Console.WriteLine();
                        break;
                }
            }
            while (true);
        }
        public bool capitulo3(string carg)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Ya dentro del castillo, caminan con cautela y visualizas una puerta. Deciden entrar...");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Parecía una antigua catedral, luz filtrandose por los vidrios de colores que formaban imágenes de seres que no conocías.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Y al centro de todo, una copa, que parecía estratégicamente iluminada...");
            Thread.Sleep(500);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (´0^0)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": El ambiente aquí se siente extraño... ");
            Console.WriteLine();
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx (´^´)");
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": No tengo un buen presentimiento con esa copa...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Ylx se oculta tras de ti, mientras se acercan lentamente hacia la copa, parecía tener agua dentro de ella.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            do
            {
                Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Entonces tú");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Bebes de la copa");
                Thread.Sleep(300);
                Console.WriteLine("2. Levantas la copa");
                Thread.Sleep(300);
                Console.WriteLine("3. Te miras en la copa");
                Thread.Sleep(300);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                op5 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (op5)
                {
                    case 1:
                        pv = pv + 20;
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx ( °o°)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Pero... ¡¿Qué haces?! ¡¿Y si está envenenado?!");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.WriteLine("Ylx intenta arrebatarte la copa, pero ya es tarde. Sientes tu cuerpo energizado.");
                        Console.WriteLine();
                        Thread.Sleep(800);
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (T.T)");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": No vuelvas a ser así de imprudente...");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("[Has bebido agua sagrada (+20 PV)]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        Console.WriteLine("Después de eso, escuchan un estruendo tras ustedes. No pudiste leer la expresión de Ylx, parecía aterrado.");
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": El aire se siente frío, ¿qué está pasando? La copa...");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.WriteLine("Ylx se coloca delante de ti, redirigiendo toda la podredumbre que se dirigía a ti, entonces, su luz se apaga.");
                        return true;
                    case 2:
                        atq = atq + 10;
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx ('°')");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Parece haber algo ahí...");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ves una semilla roja, así que la coges para inspeccionarla.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx ('v')");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Es una semilla de tejedora, una planta medicinal, si la comes tendrás más fuerza~");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Al momento de comerla, te sientes más con más fuerza");
                        Console.WriteLine();
                        Thread.Sleep(800);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Has comido semilla de tejedora (+10 atq)]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        Console.WriteLine("Después de eso, escuchan un estruendo tras ustedes. No pudiste leer la expresión de Ylx, parecía aterrado.");
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx");
                        Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": El aire se siente frío, ¿qué está pasando? La copa...");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.WriteLine("Ylx se coloca delante de ti, redirigiendo toda la podredumbre que se dirigía a ti, entonces, su luz se apaga.");
                        return true;
                    case 3:
                        apv = pv;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        Console.WriteLine("Viste tu reflejo en el agua, hasta que tu vista se nubló y todo se volvió rojo alrededor. No viste a Ylx cerca.");
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Oh... Parece que me has encontrado...");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Una niebla granate, se proyecta delante de ti, mientras lentamente se materializa.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Pido disculpas por la descortesía, no esperaba una visita, y menos de iluminados...");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Los ves jugar con una esencia de luz en la mano, Ylx. Cuando quieres alcanzarlo, él se lo come.");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Hace mucho que no me sentía así. Entrétenme, ser iluminado");
                        Thread.Sleep(800);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("El monstruo saca un bastón y sus ojos se iluminan con un brillo magenta.");
                        Console.ReadKey();
                        Console.Clear();
                        do
                        {
                            while (apv > 0 || epv > 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Alator");
                                Thread.Sleep(500);
                                Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("[Maestro desterrado (secreto)]");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("1. Atacar");
                                Thread.Sleep(300);
                                Console.WriteLine("2. Rendirse");
                                Thread.Sleep(300);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                alt1 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine();
                                switch (alt1)
                                {
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        epv = (epv + edef) - atq;
                                        v1 = (atq - edef);
                                        if (v1 < 0)
                                        {
                                            v1 = 0;
                                        }
                                        Console.WriteLine("[Has atacado a Alator, le has hecho " + v1 + " de daño]");
                                        Console.WriteLine();
                                        Thread.Sleep(1000);
                                        apv = (apv + def) - eatq;
                                        v2 = (eatq - def);
                                        if (v2 < 0)
                                        {
                                            v2 = 0;
                                        }
                                        Console.WriteLine("[Alator te ha atacado de vuelta y te ha hecho: " + v2 + " de daño]");
                                        Thread.Sleep(2000);
                                        break;
                                    case 2:
                                        apv = 0;
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                                        Console.WriteLine();
                                        break;
                                }
                                if (apv > 0 && epv > 0)
                                {
                                    Console.WriteLine();
                                    Console.Clear();
                                }
                                else if (epv <= 0)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine();
                                    Console.WriteLine("                                   [Has vencido]");
                                    pv = pv + 30;
                                    def = def + 10;
                                    atq = atq + 20;
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.Magenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Alator");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("...No... yo... ¿cómo he podido perder?");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();
                                    Console.WriteLine("El monstruo se desvanece, Ylx se muestra llorando y cuando te ve, se acerca a abrazarte.");
                                    Console.WriteLine();
                                    Thread.Sleep(800); Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("[Derrotaste al Maestro Desterrado (+ 20 atq, +10 def y +30 de PV)]");
                                    Console.WriteLine();
                                    Thread.Sleep(800);
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("Ylx (T.T)");
                                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(": Era demasiado oscuro, por favor, no me dejes caer ahí de nuevo.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Thread.Sleep(800);
                                    Console.WriteLine("Lo tranquilizas y luego sientes como regresan a su realidad.");
                                    Thread.Sleep(2000);
                                    return true;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine();
                                    Console.WriteLine("                                   [Has perdido]");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.Magenta; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Alator");
                                    Console.WriteLine();
                                    Thread.Sleep(500);
                                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Solo eras alguien que no valía la pena. Lástima ser iluminado, solo pereciste sin gracia.");
                                    Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Tu vista se apaga y ves como un grupo de demonios se acerca a ti y te arrastra hacia abajo");
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Mientras sientes desesperación todo a tu alrededor se envuelve en niebla roja");
                                    Console.WriteLine();
                                    Thread.Sleep(2000);
                                    Console.Write("                                       ");
                                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine();
                                    Thread.Sleep(800);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Yellow;
                                    string inicio = ("                                           ");
                                    for (int I = 0; I < inicio.Length; I++)
                                    {
                                        Console.Write(inicio[I]);
                                        Thread.Sleep(30);
                                    }
                                    for (int i = 0; i < carg.Length; i++)
                                    {
                                        Console.Write(carg[i]);
                                        Thread.Sleep(80);
                                    }
                                    string final = ("                                            ");
                                    for (int J = 0; J < final.Length; J++)
                                    {
                                        Console.Write(final[J]);
                                        Thread.Sleep(30);
                                    }
                                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("La podredumbre se extendió después de tu muerte. Lyos no sobrevivió.");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.WriteLine("Moriste sin que nadie recuerde tu nombre o tu hazañas. Envuelto en oscuridad y soledad.");
                                    Thread.Sleep(4000);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Sistema: Has obtenido el");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(" Final Malo 2:"); Console.WriteLine(" La sombra de un ser insignificante");
                                    Console.WriteLine();
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Sistema: Decisiones erradas, solo llevan al fracaso");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return false; //falta ver como hacer que se regrese al menu principal despues de este caso
                                }
                            }
                        }
                        while (true);
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                        Console.WriteLine();
                        break;
                }
            }
            while (true); //cambiar todos los do-while con switch a true /solo los finales, sino pueden cortar los procesos
        }
        public void capitulo4()
        {
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("Al parpadear, te das cuenta que hay 3 objetos donde antes estaba la copa, eliges tomar:");
                Console.WriteLine();
                Thread.Sleep(800);
                Console.WriteLine("1. El libro con niebla roja");
                Thread.Sleep(300);
                Console.WriteLine("2. Una capa polvorienta");
                Thread.Sleep(300);
                Console.WriteLine("3. La poción burbujeante");
                Thread.Sleep(300);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
                op6 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (op6)
                {
                    case 1:
                        atq = atq + 20;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Se ha añadido 'Libro maldito' al inventario (+20 atq)]");
                        Console.WriteLine();
                        return;
                    case 2:
                        def = def + 20;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Se ha añadido 'Capa sólida' al inventario (+20 def)]");
                        Console.WriteLine();
                        return;
                    case 3:
                        pv = pv + 20;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Se ha añadido 'Vida líquida' al inventario (+20 pv)]");
                        Console.WriteLine();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                        Console.WriteLine();
                        break;
                }
            }
            while (true);
        }
        public void batallafinal(string max)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(800);
            Console.WriteLine("De pronto, sientes el aire enfriarse y una voz habla a tus espaldas.");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine(": Ha pasado casi un siglo...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("El sonido del hierro pesado al ser rozado en el suelo, arrastrado por un licántropo de pelaje negro y ojos rojos.");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.WriteLine("Avanzando sin apuro, mientras la podredumbre infectaba todo a su alrededor, notaste las heridas putrefactas en su cuerpo.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(": Prepárate ser iluminado, esta será tu tumba");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Ylx");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(": ¡Cuidado!");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sin espera blande su espada hacia ti, gracias a que Ylx te empuja, logras esquivar, pero un leve ventisca te roza.");
            Thread.Sleep(800);
            Console.WriteLine();
            pv = pv - 10;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[Has sido herido (-10 pv)]");
            Thread.Sleep(800);
            Console.WriteLine();
            Console.WriteLine("Ylx es capturado");
            Console.ReadKey();
            Console.Clear();
            do
            {
                while (pv > 0 || pve > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ynfamous");
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("[Señor de la podredumbre]");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Atacar");
                    Thread.Sleep(300);
                    Console.WriteLine("2. Rendirse");
                    Thread.Sleep(300);
                    Console.WriteLine("3. Unirte a él");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    alt2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine();
                    switch (alt2)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            pve = (pve + defe) - atq;
                            f1 = (atq - defe);
                            if (f1 < 0)
                            {
                                f1 = 0;
                            }
                            Console.WriteLine("[Has atacado a Ynfamous, le has hecho " + f1 + " de daño]");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            pv = (pv + def) - atqe;
                            f2 = (atqe - def);
                            if (f2 < 0)
                            {
                                f2 = 0;
                            }
                            Console.WriteLine("[Ynfamous te ha atacado de vuelta y te ha hecho: " + f2 + " de daño]");
                            Thread.Sleep(2000);
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine();
                            Console.WriteLine("                                   [Te has rendido]");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Ynfamous");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Ser asqueroso... dar la espalda a los tuyos, es peor que la corrosión.");
                            Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Tu vista se apaga mientras ves a lo lejos como Ynfamous mata a Ylx");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("Sales del castillo y vagas por los alrededores...");
                            Console.WriteLine();
                            Thread.Sleep(2000);
                            Console.Write("                                       ");
                            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("GAME OVER");
                            Console.WriteLine();
                            Thread.Sleep(800);
                            Console.Clear();
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Magenta; Console.ForegroundColor = ConsoleColor.Yellow;
                            string inicio = ("                                           ");
                            for (int I = 0; I < inicio.Length; I++)
                            {
                                Console.Write(inicio[I]);
                                Thread.Sleep(30);
                            }
                            for (int i = 0; i < max.Length; i++)
                            {
                                Console.Write(max[i]);
                                Thread.Sleep(80);
                            }
                            string final = ("                                            ");
                            for (int J = 0; J < final.Length; J++)
                            {
                                Console.Write(final[J]);
                                Thread.Sleep(30);
                            }
                            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Creíste que nadie lo sabría, pero lo rumores viajan rápido. En el pueblo te despreciaban...");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("Decidieron sacrificarte cuando tuvieron la oportunidad.");
                            Thread.Sleep(5000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Sistema: Has obtenido el");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" Final Malo 3:"); Console.WriteLine(" Cobarde");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Sistema: Nos hay peor demonio, que el que abandona a los demás");
                            Console.ReadKey();
                            Console.Clear();
                            return;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine();
                            Console.WriteLine("                                   [Te has unido a la corrosión]");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Ynfamous");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Así que quieres unirte a mí... Primero mata a esta cosa flotante...");
                            Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("A pesar de los ruegos de Ylx, apagas su luz...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("De pronto, tu vista se nubla, sientes frío en todo el cuerpo.");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("Bajas la mirada, y ves la hoja pesada, atravesar tu abdomen.");
                            Console.WriteLine();
                            Thread.Sleep(2000);
                            Console.Write("                                       ");
                            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("GAME OVER");
                            Console.WriteLine();
                            Thread.Sleep(800);
                            Console.Clear();
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Magenta; Console.ForegroundColor = ConsoleColor.Black;
                            string ini = ("                                           ");
                            for (int I = 0; I < ini.Length; I++)
                            {
                                Console.Write(ini[I]);
                                Thread.Sleep(30);
                            }
                            for (int i = 0; i < max.Length; i++)
                            {
                                Console.Write(max[i]);
                                Thread.Sleep(80);
                            }
                            string fin = ("                                            ");
                            for (int J = 0; J < fin.Length; J++)
                            {
                                Console.Write(fin[J]);
                                Thread.Sleep(30);
                            }
                            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Después de matarte, Ynfamous se comió tu esencia, el último rastro de luz.");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("Y sumió a Lyos, en la eterna oscuridad.");
                            Thread.Sleep(4000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Sistema: Has obtenido el");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(" Final Malo 4:"); Console.WriteLine(" Marioneta efímera");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Sistema: Un ser iluminado debe dar luz, no unirse a las sombras.");
                            Console.ReadKey();
                            Console.Clear();
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Sistema: Opción no válida");
                            Console.WriteLine();
                            break;
                    }
                    if (pv > 0 && pve > 0)
                    {
                        Console.WriteLine();
                        Console.Clear();
                    }
                    else if (pve <= 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        Console.WriteLine("                                   [Has vencido]");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ynfamous");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Al fin... Gracias, ser iluminado");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("Lo ves volverse humano mientras lentamente se desintegra con una sonrisa...");
                        Console.WriteLine();
                        Thread.Sleep(800);
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (Q n Q)");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Es Arphes... ");
                        Console.WriteLine();
                        Thread.Sleep(800);
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Ylx (T^T)");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(": Lo lograste " + name + ", salvaste a Lyos. Nos salvaste...");
                        Console.WriteLine();
                        Thread.Sleep(800);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Ylx te abraza, mientras la esencia de Arphes resuena con la tuya y comienzas a limpiar la podredumbre.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.Yellow;
                        string inicio = ("                                           ");
                        for (int I = 0; I < inicio.Length; I++)
                        {
                            Console.Write(inicio[I]);
                            Thread.Sleep(30);
                        }
                        for (int i = 0; i < max.Length; i++)
                        {
                            Console.Write(max[i]);
                            Thread.Sleep(80);
                        }
                        string final = ("                                            ");
                        for (int J = 0; J < final.Length; J++)
                        {
                            Console.Write(final[J]);
                            Thread.Sleep(30);
                        }
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Después de eso, la luz alcanzó a limpiar toda la podredumbre de Lyos.");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine("Perdiste tu esencia, pero recibiste el agradecimiento de todos y los salvaste. Gracias...");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Sistema: Has obtenido el");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Final Bueno 1 (Real): "); Console.WriteLine(name + " el ser iluminado");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Sistema: Gracias... los salvaste a todos ^^");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        Console.WriteLine("                                   [Has perdido]");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ynfamous");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Así que... tú tampoco eras el ser iluminado... Que pérdida, eres farsante...");
                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Tu vista se apaga y ves como un grupo de demonios se acerca a ti y te arrastra hacia abajo");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("Mientras sientes desesperación todo a tu alrededor se envuelve en sombras sollozantes...");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Console.Write("                                       ");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("GAME OVER");
                        Console.WriteLine();
                        Thread.Sleep(800);
                        Console.Clear();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Yellow;
                        string inicio = ("                                           ");
                        for (int I = 0; I < inicio.Length; I++)
                        {
                            Console.Write(inicio[I]);
                            Thread.Sleep(30);
                        }
                        for (int i = 0; i < max.Length; i++)
                        {
                            Console.Write(max[i]);
                            Thread.Sleep(80);
                        }
                        string final = ("                                            ");
                        for (int J = 0; J < final.Length; J++)
                        {
                            Console.Write(final[J]);
                            Thread.Sleep(30);
                        }
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Después de oír tus valientes actos por parte de Ylx, Lyos decidió dejar de temer y derrotar la podredumbre");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine("Luego de 50 años y muchas muertes... pudieron librarse de la podredumbre...");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Sistema: Has obtenido el");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Final Bueno 2:"); Console.WriteLine(" Mártir");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine("Sistema: No diste salvación, pero trajiste esperanza...");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    }
                }
            }
            while (true);
        }
    }
}
