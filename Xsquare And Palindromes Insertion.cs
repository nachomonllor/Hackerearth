using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {


        static int NumInsertions(string s)
        {
            Dictionary<char, int> frec =
                new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (frec.ContainsKey(s[i])) frec[s[i]]++;
                else frec[s[i]] = 1;
            }

            int impares = 0;
            foreach (KeyValuePair<char, int> kvp in frec)
            {
                if (kvp.Value % 2 != 0)
                {
                    impares++;
                }
            }

            //if(impares > 1)
            //{
            //    impares *= 2;
            //}
            return impares;
        }


        static void Main(string[] args)
        {

            //int t = int.Parse(Console.ReadLine());
            //while(t-- > 0)
            //{
            //    string s = Console.ReadLine().Trim();
            //    Console.WriteLine(NumInsertions(s));
            //}

            string s = "ccacbcddabdaadaabacdcbbcbbdddccadcdcdcbdbbdcdbbccbdbacaccacdaaccbaddaacbcacbabddbdcbbdd";
            //string s = "mbmfgfaqqfbodcmnnfplniododpjcagiglnoprdqqdgmhbqkoqadecccmbnndqgpbqe";
            //string s = "aciicjaabfdaccigahdijigdjghbafjibfegbaehbadbgbacgbhhadahgbabbigghjhihbadjddfie";
            Console.WriteLine(NumInsertions(s));


            Console.ReadLine();
        }
    }
}

