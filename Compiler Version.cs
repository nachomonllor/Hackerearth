using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string linea = Console.ReadLine();
                if (linea == null)
                {
                    break;
                }
             
                int indiceSeparador = linea.IndexOf("//");

                string sentencia = "", comentario = "";

                if (indiceSeparador > -1)
                {
                    sentencia = linea.Substring(0, indiceSeparador);
                    sentencia = sentencia.Replace("->", ".");

                    comentario = linea.Substring(indiceSeparador);

                }
                else
                {
                    sentencia = linea;
                    sentencia = sentencia.Replace("->", ".");
                }

                Console.WriteLine(sentencia+comentario);
            }

      

            Console.ReadLine();

        }
    }
}
