using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class MyClass
{
    static void Main(string[] args)
    {

        //string[] t = {
        //"Donald Trump becomes the 45th #US President",
        //"Potentially habitable exoplanet #ProximaB discovered",
        //"#RogerFederer wins #US Open for 5th time",
        //"#GravitationalWaves detection successful",
        //"Traces of liquid water discovered on #Mars",
        //"Life Could Survive on Exoplanet #ProximaB",
        //"Go go #RogerFederer",
        //"Ten ways #ProximaB is different from Earth",
        //"ISRO becomes 4th space agency to reach #Mars",
        //"#RogerFederer beats #Nadal"
        //};

        int n = int.Parse(Console.ReadLine());

        string[] t = new string[n];
        for (int i = 0; i < n; i++)
        {
            t[i] = Console.ReadLine().Trim();
        }


        Dictionary<string, int> diccio = new Dictionary<string, int>();

        for (int i = 0; i < t.Length; i++)
        {
            string[] s = t[i].Trim(). Split(' ');

            foreach (string elem in s)
            {
                if (elem.StartsWith("#"))
                {
                    string pal = elem.Substring(1);
                    if (diccio.ContainsKey(pal))
                    {
                        diccio[pal]++;
                    }
                    else
                    {
                        diccio[pal] = 1;
                    }
                }
            }
        }

        Dictionary<int, List<string>> x = new Dictionary<int, List<string>>();

        foreach (KeyValuePair<string, int> item in diccio.OrderBy(i => i.Value).Reverse())
        {
            //Console.WriteLine(item.Key + " " + item.Value);
            if (x.ContainsKey(item.Value))
            {
                x[item.Value].Add(item.Key);
            }
            else
            {
                x[item.Value] = new List<string>();
                x[item.Value].Add(item.Key);
            }
        }



        int cont = 0;
        //bool sigue = true;
        foreach (KeyValuePair<int, List<string>> kvp in x)
        {
            //Console.Write(kvp.Key);

            List<string> value = kvp.Value;
            value.Sort(StringComparer.Ordinal);


            foreach (string elem in value)
            {
                Console.WriteLine("#"+elem );
                //Console.WriteLine();
                cont++;
                if (cont >= 5)
                {
                    goto e;
                
                }
            }
 
            //Console.WriteLine();
        }

        e:


        Console.ReadLine();
    }
}
