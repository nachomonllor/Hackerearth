using System;
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {


        string initial = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //string[] list = { "aA1", "b" };
        //string[] list = { "a" ,"b", "c", "d"};
        //string[] list = { "aa", "BB", "cc", "DD"};

        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            string[] list = Console.ReadLine().Split(' ');

            int ans = 0;

            foreach (string elem in list)
            {
                for (int i = 0; i < elem.Length; i++)
                {
                    ans += i + initial.IndexOf(elem[i]);
                }
            }
            ans *= list.Length;
            Console.WriteLine(ans);

        }


    }
}
