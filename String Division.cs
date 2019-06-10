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

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string s = Console.ReadLine();
                if (s.Length >= 10)
                {
                    Console.WriteLine("YES");
                }
                else
                {

                    //string s = "ababca";
                    // string s = "123456";
                    //string s = "aaabb";

                    string ans = "NO";

                    for (int i = 0; ans == "NO" && i < s.Length; i++)
                    {
                        for (int j = i + 1; ans == "NO" && j < s.Length; j++)
                        {
                            for (int k = j + 1; ans == "NO" && k < s.Length; k++)
                            {
                                HashSet<string> partes = new HashSet<string>();
                                string a = s.Substring(0, i);
                                string b = s.Substring(i, j - i);
                                string c = s.Substring(j, k - j);
                                string d = s.Substring(k);

                                if (a.Length > 0)
                                {
                                    partes.Add(a);
                                }
                                if (b.Length > 0)
                                {
                                    partes.Add(b);
                                }
                                if (c.Length > 0)
                                {
                                    partes.Add(c);
                                }
                                if (d.Length > 0)
                                {
                                    partes.Add(d);
                                }

                                // Console.WriteLine(a + " " + b + " " + c + " " + d);
                                if (partes.Count == 4)
                                {
                                    ans = "YES";
                                    //Console.WriteLine("NO");
                                    break;

                                }

                            }
                        }

                    }

                    Console.WriteLine(ans);

                }
            }


            Console.ReadLine();
        }



    }
}
