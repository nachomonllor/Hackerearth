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
            int q = int.Parse(Console.ReadLine());

            while (q-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

            
                    int sum = 0;
                    for (int i = 1; i <= Math.Sqrt(n); i++)
                    {
                        if (i != n && n % i == 0)
                        {
                            //div.Add(i);
                            sum += i;
                            if (i != 1 && n / i != i)
                            {
                                //div.Add(n / i);
                                sum += (n / i);
                            }
                        }
                    }

                    Console.WriteLine(sum);
                

            }

            Console.ReadLine();

        }
    }
}

