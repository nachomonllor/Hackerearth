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
            string num = Console.ReadLine();

            string ans = "YES";
            for (int i = 0; i < num.Length; i++)
            {
                if (!"0123456789".Contains(num[i]))
                {
                    ans = "NO";
                    break;
                }
            }
            if (ans == "NO")
            {
                Console.WriteLine(ans);
                continue;
            }
            else
            {
                if (long.Parse(num).ToString().Length != 10)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }

            
        }

        Console.ReadLine();
    }
}
