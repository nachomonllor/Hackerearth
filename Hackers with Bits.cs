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

            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            //int[] arr = { 1,0,1 };
           // int[] arr = { 0, 1, 0 };
            //int[] arr = { 0, 0, 0, 0, 1 };
            // int[] arr = { 1, 1, 1, 0, 1 };
           // int[] arr = { 1, 1, 0, 1, 1, 0, 1 }; //->5
           // int[] arr = { 1, 1, 0, 1, 1, 0, 1,1}; //->5
           // int[] arr = { 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1 }; //->6


            //cuento los grupos consecutivos de unos
            int i=0;
            int max_cont = 0;
            int grupos = 0;
            while (i < arr.Length)
            {
                bool entro = false;
                int cont = 0;
                while (i < arr.Length && arr[i] == 1)
                {
                    cont++;
                    entro = true;
                    i++;
                }
                if (entro)
                {
                    grupos++;
                }
                max_cont = Math.Max(max_cont, cont);

                i++;
            }


            //Console.WriteLine(grupos);
            if (grupos > 2)
            {

                List<int> indicesCerosSolos = new List<int>();

                for (i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        if (arr[i] == 0 && i + 1 < arr.Length && arr[i + 1] == 1)
                        {
                            indicesCerosSolos.Add(i);
                        }
                    }
                    else if (i + 1 < arr.Length)
                    {
                        if (i - 1 >= 0 && arr[i - 1] == 1 && arr[i] == 0 && i + 1 < arr.Length && arr[i + 1] == 1)
                        {
                            indicesCerosSolos.Add(i);
                        }
                    }
                    else if (i == arr.Length - 1)
                    {
                        if (i - 1 >= 0 && arr[i - 1] == 1 && arr[i] == 0)
                        {
                            indicesCerosSolos.Add(i);
                        }
                    }
                }

                
                foreach (int indice in indicesCerosSolos)
                {
                    i = indice-1;
                    int cont = 0;
                    while (i >= 0 && arr[i] == 1)
                    {
                        cont++;
                        i--;
                    }
                    i = indice+1;
                    while (i < arr.Length && arr[i] == 1)
                    {
                        cont++;
                        i++;
                    }
                    max_cont = Math.Max(max_cont, cont);
                }
                Console.WriteLine(max_cont+1);

            }
            else if (grupos == 2)
            {

                i = 0;
               
              
                while (i < arr.Length)
                {
                    int cont = 0;
                    while (i < arr.Length && arr[i] == 1)
                    {
                 
                        cont++;
                        i++;
                    }
                    max_cont = Math.Max(max_cont, cont);

                    i++;
                }

                Console.WriteLine(max_cont + 1);
            }
            else if (grupos == 1)
            {
                i = 0;
               

                while (i < arr.Length)
                {
                    int cont = 0;
                    while (i < arr.Length && arr[i] == 1)
                    {

                        cont++;
                        i++;
                    }
                    max_cont = Math.Max(max_cont, cont);

                    i++;
                }

                Console.WriteLine(max_cont);

            }
            else if (grupos == 0)
            {
                Console.WriteLine(0);
            }


            Console.ReadLine();

        }
    }
}

