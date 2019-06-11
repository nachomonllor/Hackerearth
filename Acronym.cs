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
            int k =  int.Parse(Console.ReadLine());
            var dislikes = new List<string>();
            int i;
                            
             //string [] d = {   "oik",
             //   "ppui",
             //   "aw",
             //   "xs",
             //   "x",
             //   "itxoohe"};
            for (  i = 0; i < k; i++)
            {
                dislikes.Add( Console.ReadLine());
            }

            int n = int.Parse(Console.ReadLine());
            //string[] words = "qd tkrvcifam aqvzmdgj blutejpglx oik quiy aw mj oajrzmuat ecxbpasqq scdbolfur x fhdktmmsy qsqq xs".Split(' ');
            string[] words = Console.ReadLine().Split(' ');
 

            List<string> lista = new List<string>();

            for ( i = 0; i < words.Length; i++)
            {
                if (!dislikes.Contains(words[i]))
                {
                    lista.Add(words[i]);
                }
            }

            string ans = "";
            for ( i = 0; i < lista.Count - 1; i++)
            {
                ans += char.ToUpper(lista[i][0]) + ".";
            }
            ans += char.ToUpper( lista[i][0] );


            Console.WriteLine(ans);


            Console.ReadLine();
        }

    }
}

