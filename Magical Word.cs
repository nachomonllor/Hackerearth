using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {



            int[] primos = /*{ 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59,*/ {  67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113 }; //, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499 };

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
               // string s = "1234567890";
               // string s = "S@#!#$op";
                //string s = "AvfmaLgLRpQadLyThsxVzkUqbFOdxfbLGdpBWOwmAnflENlYFbdhNHerHVtZkaPLgMtNQovVHpwGfHJdXXWAhYrhwXKPxtnpxCIsaXVAkcxTpVprFNeOVcnSEsgIvfqXPRSUASSDCvAGrFJCDbzGLFhrMYWALElChmurLrEeQttIWctyhQXzZUVAYuCIZecBJbXMxlMHFbZxJRTSZJmZAwCggGabVsovqBrdmmbCTaIHDfUunLFntfGzodKqoAKwCassKMDybethRaQgegsOawfNCNrIAkECEKpbwElhvWtlZBEZqJQpEkzpiSjrqZZIHbszUxwuWreXkxFKxSAiKoemIqETGVxcCjweKhbyXxhVKCbNTQBKgHD";
                //string s = "1234567890";
                //10
                //1234567890
                //8
                //S@#!#$op
                //6
                //S#!v@m
                //11
                //!@#$%^&*()_
                //15
                //+=-\|]}[{'";:>< 

                // string s = "AWGrOwUcFWnghtAyvxSb";
                //CYGqOqSaGYmggqCqqqSa

                bool[] nums = new bool[200];

                for (int i = 0; i < primos.Length; i++)
                {
                    nums[primos[i]] = true;
                }

                //for (int i = 0; i < nums.Length; i++)
                //{
                //    Console.WriteLine(i +  " "  + nums[i] + " ");
                //}

                //string s = "AFREEN";
                string ans = "";

                for (int i = 0; i < s.Length; i++)
                {
                    //Console.Write((int)s[i] + " ");

                    int ASCIant = 0, ASCIpost = 0;
                    int indice = s[i];
                    //if (char.IsNumber(s[i]))
                    //{
                    //    indice = int.Parse(s[i].ToString());
                    //}

                    int j = indice;
                    while (j >= 0)
                    {
                        if (nums[j])
                        {
                           
                                ASCIant = j;
                                break;
                            
                        }
                        j--;
                    }

                    if (j < 0)
                    {
                        ASCIant = int.MaxValue;
                    }

                    j = indice;
                    while (j < nums.Length)
                    {
                        if (nums[j])
                        {
                            
                                ASCIpost = j;
                                break;
                           
                        }

                        j++;
                    }

                    int dif_a = Math.Abs(s[i] - ASCIant);
                    int dif_b = Math.Abs(s[i] - ASCIpost);



                    //Console.WriteLine(((int)(ASCIant) + " " + (int)s[i] + " "
                    //    + ((int)(ASCIpost))));

                    if (dif_a <= dif_b)
                    {
                        ans += (char)ASCIant;
                    }
                    else if (dif_b < dif_a)
                    {
                        ans += (char)ASCIpost;
                    }

                }

                Console.WriteLine(ans);

                //for (int i = 0; i < ans.Length; i++)
                //{
                //    Console.Write((int)ans[i] + " ");
                //}


            }

            Console.ReadLine();

        }
    }
}


