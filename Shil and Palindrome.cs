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

           
            string s = Console.ReadLine();
            //string s = "aabcc";
            //string s = "bbbbbbbaaaaaaaann";
            //string s = "a";

            Dictionary<char, int> frec = new Dictionary<char, int>();
            for (char ch = 'a'; ch <= 'z'; ch++) frec[ch] = 0;
            for (int i = 0; i < s.Length; i++) frec[s[i]]++;
           
            char[] keys = frec.Keys.ToArray();
            int[] values = frec.Values.ToArray();

            int valuesImpares = values.Count(e => e % 2 != 0);
           // Console.WriteLine(valuesImpares);
      
            if (valuesImpares > 1)
            {
                Console.WriteLine("-1");
            }
            else
            {

                string izq = "", der = "", resto = "";

                char unico = ' ';
                for (int i = 0; i < keys.Length-1; i++)
                {
                    if (values[i] % 2 == 0)
                    {
                        izq += new string(keys[i], values[i] / 2);
                        der = new string(keys[i], values[i] / 2) + der;
                    }
                    else
                    {
                        //resto += new string(keys[i], values[i]);
                        izq += new string(keys[i], (values[i] - 1) / 2);
                        der = new string(keys[i], (values[i] - 1) / 2) + der;
                        unico = keys[i];
                    }
                }

                if (valuesImpares == 1)
                {
                    resto += new string(keys[keys.Length - 1], values[values.Length - 1] / 2) + unico + new string(keys[keys.Length - 1], values[values.Length - 1] / 2);
                }
                else if(valuesImpares ==0)
                {
                    resto += new string(keys[keys.Length - 1], values[values.Length - 1] / 2)  + new string(keys[keys.Length - 1], values[values.Length - 1] / 2);
                }

                if (s.Length == 1) Console.WriteLine(s);
                else Console.WriteLine(izq + resto + der);
            }

            Console.ReadLine();
        }
    }
}
