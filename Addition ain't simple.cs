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
           //   string h= "hello";
           //string rev = "olleh";

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                //string h = "codeapocalypse";
                //string s = "programming";
                
                //string s = "world";
                string s = Console.ReadLine();
               // char[] rev = s.ToCharArray();
            

                string alfab = "abcdefghijklmnopqrstuvwxyz";

                string concat = "";

                int i = 0, j = s.Length - 1;
                //for (int i = 0; i < s.Length; i++)
                while (j>=0 && i<s.Length)
                {
                    //int sum = ((s[i] - 'a') + (s[j] - 'a') + 1) % alfab.Length;
                   // concat += alfab[sum];
                    Console.Write(alfab[((s[i] - 'a') + (s[j] - 'a') + 1) % alfab.Length]);

                    i++;
                    j--;
                }
                Console.WriteLine();
            }


           Console.ReadLine();
        }
    }
}
