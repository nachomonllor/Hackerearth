using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string a = "98456";
            //string b = "53443";

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {


                //string a = "18";
                //string b = "223";

                string a = Console.ReadLine();
                string b = Console.ReadLine();

                int maxlen = Math.Max(a.Length, b.Length);

                a = new string('0', maxlen - a.Length) + a;
                b = new string('0', maxlen - b.Length) + b;

               // Console.WriteLine(a);
               // Console.WriteLine(b);


                string concat = "";
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    concat = ((int.Parse(a[i].ToString()) + int.Parse(b[i].ToString())) % 10).ToString() + concat;
                }

                BigInteger bigRes = BigInteger.Parse(concat);
                BigInteger bigA = BigInteger.Parse(a);
                BigInteger bigB = BigInteger.Parse(b);

                BigInteger sum = bigA + bigB;
                BigInteger dif = sum - bigRes;

                Console.WriteLine(dif.ToString());

                //Console.WriteLine(concat);

            }

            Console.ReadLine();
        }
    }
}

