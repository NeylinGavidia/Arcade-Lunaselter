using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nombre_Arcade
{
    public class Title
    {
        public void Titulo(string Titulo) //PARA EL TITULO
        {

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"                                

                    _                  _       _   _   _ _  _   _   ___ ___ _  _____ ___ ___ 
                   /_\  _ _ __ __ _ __| |___  | | | | | | \| | /_\ / __| __| ||_   _| __| _ \
                  / _ \| '_/ _/ _` / _` / -_) | |_| |_| | .` |/ _ \\__ \ _|| |__| | | _||   /
                 /_/ \_\_| \__\__,_\__,_\___| |____\___/|_|\_/_/ \_\___/___|____|_| |___|_|_\
                                                                                             
                                                                             
              ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string inicio = ("    ---------------------------------------------- ");
            for (int I = 0; I < inicio.Length; I++)
            {
                Console.Write(inicio[I]);
                Thread.Sleep(30);
            }
            for (int i = 0; i < Titulo.Length; i++)
            {
                Console.Write(Titulo[i]);
                Thread.Sleep(80);
            }
            string final = (" -----------------------------------------------");
            for (int J = 0; J < final.Length; J++)
            {
                Console.Write(final[J]);
                Thread.Sleep(30);
            }
        }
    }
}
