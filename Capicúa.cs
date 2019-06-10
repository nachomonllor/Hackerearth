using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class MyClass
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            string n = Console.ReadLine().Trim() ;

            char[] rev = n.ToCharArray();
            Array.Reverse(rev);

            if (n == new string(rev))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        Console.ReadLine();
    }
}

