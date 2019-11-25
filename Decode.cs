using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class HelloWorld
{
    static public void Main()
    {
        String line;
        line = Console.ReadLine();
        int T = Convert.ToInt32(line);

        for (int t_i = 0; t_i < T; t_i++)
        {
            String s;
            s = Console.ReadLine();

            String out_ = decode(s);
            Console.Out.WriteLine(out_);

        }
    }

    static String decode(String s)
    {
        // Write your code here
        StringBuilder a = new StringBuilder();
        StringBuilder b = new StringBuilder();

        if (s.Length % 2 != 0)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 != 0)
                {
                    // a = s[i] + a;
                    a.Insert(0, s[i]);
                    //a.Append(a.ToString());
                }
                else
                {
                    //b += s[i];
                    b.Append(s[i]);

                }
            }

            return a.ToString() + b.ToString();
        }
        else
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 != 0)
                {
                    //a += s[i];
                    a.Append(s[i]);
                }
                else
                {
                    //b  = s[i] + b ;
                    // b.Append(s[i] + "" + b.ToString());
                    b.Insert(0, s[i]);

                }
            }

            return b.ToString() + a.ToString();
        }
    }

}