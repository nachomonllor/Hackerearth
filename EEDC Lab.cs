https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/eedc/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static string SumBigNumbersString(string a, string b)
        {

            //List<int> c = new List<int>();
            string c = "";

            int mellevo = 0;

            int i = a.Length - 1, j = b.Length - 1;

            while (i >= 0 && j >= 0)
            {
                //int res = int.Parse(a[i].ToString()) + int.Parse(b[j].ToString()) + mellevo;
                int res = (a[i] - '0') +  (b[j] - '0') + mellevo;
                //c.Insert(0, res % 10);
                c = c.Insert(0, (res % 10).ToString());
                if (res > 9)
                {
                    mellevo = res / 10;
                }
                else
                {
                    mellevo = 0;
                }
                i--;
                j--;
            }

            while (i >= 0)
            {
                //int res = int.Parse(a[i].ToString()) + mellevo;
                int res =  (a[i] - '0') + mellevo;
                c = c.Insert(0, (res % 10).ToString());
                if (res > 9)
                    mellevo = res / 10;
                else
                    mellevo = 0;

                i--;
            }

            while (j >= 0)
            {
                //int res = int.Parse(b[j].ToString()) + mellevo;
                int res =  (b[j] - '0') + mellevo;
                c = c.Insert(0, (res % 10).ToString());

                if (res > 9)
                    mellevo = res / 10;
                else
                    mellevo = 0;
                j--;
            }

            if (mellevo > 0)
            {
                c = c.Insert(0, mellevo.ToString());
            }


            return c;

        }

        static bool EsDivPor2(string num)
        {
            return  (num[num.Length - 1] - '0')  % 2 == 0;
        }

        static bool EsDivPor5(string num)
        {
            char ult = num[num.Length - 1];
            return ult == '0' || ult == '5';
        }

        static bool EsDivPor3(string num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += (num[i] - '0');  //int.Parse(num[i].ToString());
            }
            return sum % 3 == 0;
        }

        static int[] EEDCLab(string arr)
        {
            //List<int> indices = new List<int>();
            //Dictionary<int, int> indices =
            //    new Dictionary<int, int>();

            int[] indices = new int[arr.Length + 1];

            //int sum = 0;
            int acum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string pre = arr.Substring(0, i);
                string post = arr.Substring(i + 1);
                //Console.WriteLine(pre + " " + post);
                //int sum = Suma(pre) + Suma(post);

                if (pre == "") pre = "0";
                if (post == "") post = "0";

                string sumBig = SumBigNumbersString(pre, post);

                //if (EsDiv(pre) && EsDiv(post))
                //if (sum % 2 == 0 && sum % 3 == 0 && sum % 5 == 0)
                //{
                //    acum++;
                //}

                if (EsDivPor2(sumBig) && EsDivPor3(sumBig) && EsDivPor5(sumBig))
                {
                    acum++;
                }

                //indices.Add(i + 1, acum);
                indices[i + 1] = acum;
            }

            return indices;
        }


        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine().Trim());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
            //string arr = string.Join("", Console.ReadLine().Trim() );
            string[] arr = Console.ReadLine().Trim().Split(' ');

            string s = string.Join("", arr);
        
            int[] ind = EEDCLab(s);


            int q = int.Parse(Console.ReadLine().Trim());

            while (q-- > 0)
            {
                string[] que = Console.ReadLine().Trim().Split(' ');
                int a = int.Parse(que[0].ToString());
                int b = int.Parse(que[1].ToString());

                if (a - 1 >= 1)
                {
                    Console.WriteLine(ind[b] - ind[a - 1]);
                }
                else
                {
                    Console.WriteLine(ind[b]);
                }
            }

            Console.ReadLine();
        }
    }
}


