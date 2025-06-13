using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuJuegos
{
    public class Juego3
    {
        int[] numeros = new int[4]; //Guarda los 4 números aleatorios que se van a generar
        public void facil()
        {
            Random AE = new Random(); //Genera los números aleatorios

            for (int i = 0; i < numeros.Length; i++) //Sirve para repetir xd
            {
                numeros[i] = AE.Next(1, 10);//Guarda un número aleatorio del 1 al 9 en cada posición
            }
            Console.WriteLine("Memorice los números");
            Console.WriteLine();
            for (int i = 0; i < numeros.Length; i++)//Repite 4 veces(una por cada numero) i empieza desde 0 hasta que sea menor que 4
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(numeros[i] + " ");//Muestra cada número con un pequeño espacio
            }
            Thread.Sleep(3000); //Esperar 3 segundos
            Console.Clear(); //Borra la pantalla para que ya no se muestre los números generados
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ingresa los números en el mismo orden:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Recuerda copiar número por número en cada línea ^^");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            bool correcto = true; //Esto es para saber si el jugador los ingresó bien

            for (int i = 0; i < numeros.Length; i++) //Pide uno por uno los números y lo compara si están bien
            {
                int ingresado = int.Parse(Console.ReadLine());

                if (ingresado != numeros[i]) //Si el número ingresado no es igual al que se generó...
                {
                    correcto = false; // ...entonces no sera correcto
                }
            }
            if (correcto) //Si todos los números son correctos...
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Es correcto. Tienes una memoria excelente"); //...mostrara este mensaje
                Console.Beep(800, 150);
                Console.Beep(1000, 150);
                Console.Beep(1200, 150);
                Console.Beep(1000, 150);
                Console.Beep(800, 150);
                Thread.Sleep(3000);
                Console.Clear();
            }
            else //Y si no pues...
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Es incorrecto. Sigue practicando"); //...mostrara este mensaje y...
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Los numeros mostrados eran: " + string.Join(" ", numeros)); //...tambien este, donde se mostraran los numeros que fueron generados
                //El string.Join junto con el numeros, sirve para mostrar los numeros generados, por si el usuario a fallado
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
        public void medio()
        {
            int[] numeros2 = new int[6];

            Random AE = new Random();

            for (int i = 0; i < numeros2.Length; i++)
            {
                numeros2[i] = AE.Next(1, 10);
            }
            Console.WriteLine("Memorice los números");
            for (int i = 0; i < numeros2.Length; i++)
            {
                Console.Write(numeros2[i] + " ");
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ingresa los números en el mismo orden:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Recuerda copiar número por número en cada línea ^^");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            bool correcto = true;

            for (int i = 0; i < numeros2.Length; i++)
            {
                int ingresado = int.Parse(Console.ReadLine());

                if (ingresado != numeros2[i])
                {
                    correcto = false;
                }
            }
            if (correcto)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Es correcto. Tienes una memoria excelente");
                Console.Beep(800, 150);
                Console.Beep(1000, 150);
                Console.Beep(1200, 150);
                Console.Beep(1000, 150);
                Console.Beep(800, 150);
                Thread.Sleep(3000);
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Es incorrecto. Sigue practicando");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Los numeros mostrados eran: " + string.Join(" ", numeros2));
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
        public void dificil()
        {
            int[] numeros3 = new int[8];

            Random AE = new Random();

            for (int i = 0; i < numeros3.Length; i++)
            {
                numeros3[i] = AE.Next(1, 10);
            }
            Console.WriteLine("Memorice los números");
            for (int i = 0; i < numeros3.Length; i++)
            {
                Console.Write(numeros3[i] + " ");
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ingresa los números en el mismo orden:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Recuerda copiar número por número en cada línea ^^");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            bool correcto = true;

            for (int i = 0; i < numeros3.Length; i++)
            {
                int ingresado = int.Parse(Console.ReadLine());

                if (ingresado != numeros3[i])
                {
                    correcto = false;
                }
            }
            if (correcto)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Es correcto. Tienes una memoria excelente");
                Console.Beep(800, 150);
                Console.Beep(1000, 150);
                Console.Beep(1200, 150);
                Console.Beep(1000, 150);
                Console.Beep(800, 150);
                Thread.Sleep(3000);
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Es incorrecto. Sigue practicando");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Los numeros mostrados eran: " + string.Join(" ", numeros3));
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}
