using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool esValida(string ip)
        {
            string[] partes = ip.Split('.');
            if (partes.Length != 4) return false;

            foreach (string elem in partes)
            {
                if (elem.Length == 0) return false;

                int num = int.Parse(elem);
                if (num < 0 || num > 255) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            // string ip = "255.255.255.0";
            string ip = Console.ReadLine();

            Console.WriteLine(esValida(ip) ? "YES" : "NO");

            Console.ReadLine();
        }


    }
}

