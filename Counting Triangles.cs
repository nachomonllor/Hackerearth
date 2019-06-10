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

            Dictionary<string, int> diccio = new Dictionary<string, int>();
            while (n-- > 0)
            {
                string[] triang = Console.ReadLine().Split(' ');
                long a = long.Parse(triang[0]);
                long b = long.Parse(triang[1]);
                long c = long.Parse(triang[2]);

                long[] triangulo = { a, b, c };
                Array.Sort(triangulo);

                string t = triangulo[0] + " " + triangulo[1] + " " + triangulo[2];

                if (diccio.ContainsKey(t))
                {
                    diccio[t]++;
                }
                else
                {
                    diccio[t] = 1;
                }
            }

            int ans = 0;
            foreach (KeyValuePair<string, int> kvp in diccio)
            {
                if (kvp.Value == 1)
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
