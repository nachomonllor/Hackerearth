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

        static void Main(string[] args)
        {           
                    
            int n = int.Parse(Console.ReadLine());
                    
            while (n-- > 0)
            {       
                string Jhool = Console.ReadLine();
                string Jaadu = Console.ReadLine();
                // Console.WriteLine(Jhool.Contains(Jaadu) ? "YES" : "NO");

                HashSet<char> hashJhool =
                    new HashSet<char>(Jhool.ToCharArray());

                string ans = "NO";
                for (int i = 0; i < Jaadu.Length; i++)
                {   
                    //if(Jhool.Contains(Jaadu[i]))
                    //{
                    //    ans = "YES";
                    //    break;
                    //}
                    if(hashJhool.Contains(Jaadu[i]))
                    {
                        ans = "YES";
                        break;
                    }
                }

                Console.WriteLine(ans);
            }       

            //Console.WriteLine("hm".Contains("hm"));
            Console.ReadLine();
        }
    }
}

