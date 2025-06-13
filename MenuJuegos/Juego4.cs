using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuJuegos
{
     public class Juego4
    {
        public static int escena;
        public void MostrarEscena(int escena)
        {
            switch (escena)
            {
                case 0:
                    Console.WriteLine("Estás en tu casa, ¿qué harás hoy?");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Estudiar duro (¿o no tanto?)");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Salir con tus locos amigos");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Quedarte en cama viendo memes");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                case 1:
                    Console.WriteLine("Elegiste estudiar. ¿Qué materia te interesa?");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Matemáticas (prepárate para sufrir)");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Historia (para ser un experto en excusas)");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Programación (o eso crees)");
                    Thread.Sleep(300);
                    Console.WriteLine("4) Filosofía (¿para qué sirve la vida?)");
                    Thread.Sleep(300);
                    Console.WriteLine("5) Arte (¡desata al artista interno!)");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("Sales con tus amigos. ¿Qué plan prefieres?");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Ir al cine (popcorn incluido)");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Parque (respira aire fresco)");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Café (charlas profundas garantizadas)");
                    Thread.Sleep(300);
                    Console.WriteLine("4) Karaoke (afina la voz)");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine("Decidiste quedarte en cama. ¿Qué haces?");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Ver memes sin parar");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Dormir más (experto en siestas)");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Llorar un poco (porque sí)");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Mini-juego: Adivina el número entre 1 y 3: ");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("¿Cuál crees que es?");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine("¡Te topaste con un problema que te llena de dudas!");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Intentar hablar con el profesor");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Pedir ayuda a un compañero");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Hacer trampa (¡no recomendado!)");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine("Has llegado a la biblioteca secreta, llena de misterios");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Buscar un libro antiguo");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Dormir en una mesa (otra vez)");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Escribir un poema sobre tu vida");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("Estás en la cafetería, el lugar de encuentro");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Comprar un café y socializar");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Comer pastel y planear una fiesta");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Escuchar música y desconectar");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                case 8:
                    Console.WriteLine("¡Mini juego de concentración! Escoge un número del 1 al 5: ");
                    Console.WriteLine();
                    break;

                case 9:
                    Console.WriteLine("Has encontrado un pasadizo secreto que te lleva a un concierto inesperado");
                    Console.WriteLine();
                    Thread.Sleep(300);
                    Console.WriteLine("1) Bailar hasta el amanecer");
                    Thread.Sleep(300);
                    Console.WriteLine("2) Buscar a tus amigos");
                    Thread.Sleep(300);
                    Console.WriteLine("3) Salir y descansar");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Escena desconocida o final del juego. ¡Bien jugado!");
                    Console.WriteLine();
                    break;
            }
        }

        public static void EjecutarJuego(Juego4 juego)
        {
            int escena = 0;
            int opcion;

            do
            {
                Console.Clear();
                juego.MostrarEscena(escena);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.Write("Elige una opción: ");
                Console.ResetColor();

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Entrada no válida. Presiona enter para intentar de nuevo...");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                int nuevaEscena = Juego4.AvanzarEscena(escena, opcion);

                if (nuevaEscena == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine();
                    Console.WriteLine("Pulsa enter para volver al menú principal...");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine();
                escena = nuevaEscena;

            } while (true);
        }
        public static int AvanzarEscena(int escena, int opcion)
        {
            switch (escena)
            {
                case 0:
                    if (opcion == 1)
                        return 1;
                    if (opcion == 2)
                        return 2;
                    if (opcion == 3)
                        return 3;
                    break;

                case 1:
                    if (opcion == 1)
                        return 5;
                    if (opcion == 2)
                    {
                        Console.WriteLine("Estudias Historia... porque recordar errores del pasado es tu pasatiempo favorito");
                        Console.WriteLine();
                        MostrarFinal(1);
                        return -1;
                    }
                    if (opcion == 3)
                    {
                        Console.WriteLine("Estudias Programación... y descubres que 'Hola Mundo' es solo el inicio del sufrimiento");
                        Console.WriteLine();
                        MostrarFinal(1);
                        return -1;
                    }
                    if (opcion == 4)
                    {
                        Console.WriteLine("Estudias Filosofía... y te pasas la clase preguntándote si la clase realmente existe");
                        Console.WriteLine();
                        MostrarFinal(5);
                        return -1;
                    }
                    if (opcion == 5)
                    {
                        Console.WriteLine("Te metes a Arte... y accidentalmente creas una obra maestra pegando plastilina en una hoja");
                        Console.WriteLine();
                        MostrarFinal(1);
                        return -1;
                    }
                    break;

                case 2:
                    if (opcion == 1)
                    {
                        Console.WriteLine("Juega mientras esperas que sea hora de entrar a ver la película");
                        return 4;
                    }
                    if (opcion == 2)
                    {
                        Console.WriteLine("Vas al parque... y terminas compitiendo con ardillas por un lugar en la sombra");
                        Console.WriteLine();
                        Console.WriteLine("======================================================================");
                        Console.WriteLine("¡Gracias por jugar! Espero que tu vida haya sido... al menos divertida");
                        Console.WriteLine("======================================================================");
                        return -1;
                    }
                    if (opcion == 3)
                    {
                        MostrarFinal(11);
                        return -1;
                    }
                    if (opcion == 4)
                    {
                        Console.WriteLine("Te lanzas al karaoke... desafías la lógica del sonido y ganas aplausos por tu valentía");
                        Console.WriteLine();
                        MostrarFinal(4);
                        return -1;
                    }
                    break;

                case 3:
                    if (opcion == 1)
                    {
                        Console.WriteLine("¡Memes ilimitados desbloqueados!");
                        Console.WriteLine();
                        MostrarFinal(3);
                        return -1;
                    }
                    if (opcion == 2)
                    {
                        Console.WriteLine("¿Ya es de noche?. ¡Ups!");
                        Console.WriteLine();
                        MostrarFinal(2);
                        return -1;
                    }
                    if (opcion == 3)
                    {
                        Console.WriteLine("A veces llorar ayuda... y otras te pone rojo.");
                        Console.WriteLine();
                        Console.WriteLine("================================================================================");
                        Console.WriteLine("¡Gracias por jugar! Espero que tu vida haya sido... al menos un poco entretenida");
                        Console.WriteLine("================================================================================");
                        return -1;
                    }
                    break;

                case 4:
                    // Mini juego de adivinar número (suponiendo que el número secreto es 2)
                    int numeroSecreto = 2;
                    if (opcion == numeroSecreto)
                    {
                        Console.WriteLine("¡Correcto! Eres un adivino nato");
                        Console.WriteLine();
                        Console.WriteLine("Disfruta el tiempo con tus amigos y espero que nadie diga spoilers de la película");
                        Console.WriteLine();
                        MostrarFinal(10);
                        return -1;
                    }
                    else
                    {
                        Console.WriteLine("¡No! Pero no te rindas, inténtalo de nuevo");
                        Console.WriteLine();
                        return 4;
                    }

                case 5:
                    if (opcion == 1)
                    {
                        Console.WriteLine("El profesor te ayuda con un consejo sabio y resuelves todas tus dudas");
                        Console.WriteLine();
                        MostrarFinal(8);
                        return -1;
                    }
                    if (opcion == 2)
                    {
                        Console.WriteLine("Tu compañero te presta sus apuntes");
                        Console.WriteLine();
                        MostrarFinal(8);
                        return -1;
                    }
                    if (opcion == 3)
                    {
                        Console.WriteLine("¡Te atraparon haciendo trampa! Fin del juego");
                        Console.WriteLine();
                        MostrarFinal(9);
                        return -1;
                    }
                    break;

                case 6:
                    if (opcion == 1)
                        return 8;
                    if (opcion == 2)
                    {
                        Console.WriteLine("Dormiste en la biblioteca, el bibliotecario no está feliz");
                        Console.WriteLine();
                        MostrarFinal(2);
                        return -1;
                    }
                    if (opcion == 3)
                    {
                        Console.WriteLine("Escribiste un poema épico. ¡Eres un artista!");
                        Console.WriteLine();
                        MostrarFinal(7);
                        return -1;
                    }
                    break;

                case 7:
                    if (opcion == 1)
                        return 9;
                    if (opcion == 2)
                    {
                        Console.WriteLine("Planeaste una fiesta inolvidable. ¡Todos te aman!");
                        Console.WriteLine();
                        Console.WriteLine("Luego de la fiesta... Tu casa quedó hecha un desastre");
                        Console.WriteLine();
                        MostrarFinal(6);
                        return -1;
                    }
                    if (opcion == 3)
                    {
                        Console.WriteLine("Escuchaste música y te relajaste");
                        Console.WriteLine();
                        MostrarFinal(2);
                        return -1;
                    }
                    break;

                case 8:
                    if (opcion >= 1 & opcion <= 5)
                    {
                        Console.WriteLine("¡Excelente concentración!");
                        Console.WriteLine();
                        return 5;
                    }
                    else
                    {
                        Console.WriteLine("Fallaste el mini juego. Intenta de nuevo");
                        Console.WriteLine();
                        return 8;
                    }

                case 9:
                    if (opcion == 1)
                    {
                        Console.WriteLine("Bailaste hasta el amanecer, ¡qué energía!");
                        Console.WriteLine();
                        MostrarFinal(3);
                        return -1;
                    }
                    if (opcion == 2)
                    {
                        Console.WriteLine("Encontraste a tus amigos y disfrutaron juntos");
                        Console.WriteLine();
                        MostrarFinal(12);
                        return -1;
                    }
                    if (opcion == 3)
                    {
                        Console.WriteLine("Decidiste descansar. Mañana será otro día");
                        Console.WriteLine();
                        MostrarFinal(0);
                        return -1;
                    }
                    break;
            }

            return -1;
        }

        public static void MostrarFinal(int tipoFinal)
        {
            Console.WriteLine("=========================================================================================");

            switch (tipoFinal)
            {
                case 1:
                    Console.WriteLine("Lograste sobrevivir a la universidad sin convertirte en café");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Graduado con ojeras");
                    break;

                case 2:
                    Console.WriteLine("Dormiste tanto que ahora el colchón te considera familia");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Espíritu de la cama");
                    break;

                case 3:
                    Console.WriteLine("Te volviste influencer por subir un meme mal recortado");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Señor/a de los likes");
                    break;

                case 4:
                    Console.WriteLine("Cantaste en karaoke y firmaste contrato con una banda de covers");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Estrella de medio tiempo");
                    break;

                case 5:
                    Console.WriteLine("Pensaste tanto sobre tu existencia que abriste un portal filosófico");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: El pensador dimensional");
                    break;

                case 6:
                    Console.WriteLine("Fuiste abducido por aliens, pero solo para hacer tareas domésticas");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Amo/a intergaláctico del trapeador");
                    break;

                case 7:
                    Console.WriteLine("Tu vida fue tan artística que te invitaron a una exposición llamada 'Lo Inexplicable'");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Instalación viviente");
                    break;

                case 8:
                    Console.WriteLine("Superaste todos los desafíos, hiciste amigos y aprendiste algo valioso...");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: ¡Ganador de la Vida!");
                    break;

                case 9:
                    Console.WriteLine("Cometiste tantas decisiones absurdas que Netflix quiere hacer una serie sobre ti");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Protagonista de comedia existencial");
                    break;

                case 10:
                    Console.WriteLine("Fuiste al cine con tus amigos... pero entraste a la sala equivocada y terminaste viendo un documental de 4 horas sobre caracoles");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Crítico de cine involuntario");
                    break;

                case 11:
                    Console.WriteLine("Fuiste al café con amigos... y terminaste filosofando sobre el significado de la espuma en el capuchino");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: Barista del alma");
                    break;

                case 12:
                    Console.WriteLine("Rieron, comieron, recordaron cosas tontas y prometieron volver a verse pronto");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: El verdadero tesoro eran los amigos que hiciste en el camino");
                    break;

                default:
                    Console.WriteLine("¿Qué fue esto? ¿Un sueño? ¿Un bug? ¿Una lección de vida?");
                    Console.WriteLine();
                    Console.WriteLine("Final alcanzado: El misterioso 'final por defecto'");
                    break;
            }

            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
        }
    }
}
