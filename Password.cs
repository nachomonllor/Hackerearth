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

            //string[] s = {
            //                "ykifvgqqdfjge",
            //                "mofkjxetcqdra",
            //                "bhessfdbmbher",
            //                "njdvnplvcuvgo",
            //                "awruxvcequkvv",
            //                "wygbqtmvrdldy",
            //                "oywwpwwirwgub",
            //                "ypluoltwomsci",
            //                "kfvogmpdmfajp",
            //                "ugvpjufvrvhns",
            //                "bugwriwwpwwyo",
            //                "xanakyhjppvfu",
            //                "ikxtdsabimypi",
            //                "qorhjphxsuyce",
            //                "osctnngnhlgkn",
            //                "qwmjhfxbmhsuh",
            //                "lrgoxujaqynan",
            //                "xlvkynhnwqtwr",
            //                "gekdmyuupuqyv",
            //                "jxljnlxkvyxfn",
            //                "wvjtnpabvmcsk",
            //                "robsmmsayhmwt",
            //                "ixtonqmwkdpkg",
            //                "laiekcunuhcpi",
            //                "byuasfymvodjm",
            //                "pmedspddvpfrf",
            //                "cbhrjlrglkoma",
            //                "kcdvqvkuyfmci",
            //                "itpcyreimptey",
            //                "iqpuqcwwypslk",
            //                "rtwveipukqoqb",
            //                "bjxhkgbabrcbq",
            //                "dqjpcdjbynjqk",
            //                "wjapndblnlrol",
            //                "uiqvatpllrpwu",
            //                "qnfkxevatjgvu",
            //                "tjoixksoiskxh",
            //                "yryvnrjuckbym",
            //                "ukssiofywdjqr",
            //                "uleusdntcdmna",
            //                "oabpnxditlxyk",
            //                "wcwnvtccowger",
            //                "khgxjuymnmnqw",
            //                "heuiqsmnikjmm",
            //                "ykudefnkewhfm",
            //                "wtanqjtmrlhgb",
            //                "rqlfdmrbpvgfi",
            //                "mfrrrplrfddar",
            //                "unydqqtcxyqpa",
            //                "jnhoxttqongah",
            //                "nfkpwhdvkupey",
            //                "neqgeatnoukll",
            //                "yytbhhhrxecbd",
            //                "mxurxkxqqeqns",
            //                "hifstguphewox",
            //                "wvabynytfyefp",
            //                "xjgleqvjjrpgh",
            //                "xkeojcklfjyef",
            //                "gemlvkvfxcvtm",
            //                "hlcoscbyrmdcy",
            //                "ioapthvgurqsw"

            //             };


            int n = int.Parse(Console.ReadLine());

            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }

            string ans = "";

            for (int i = 0; ans == "" && i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    char[] rev = s[j].ToCharArray();
                    Array.Reverse(rev);

                    if (s[i] == new string(rev))
                    {
                        ans = s[i].Length + " " + s[i][s[i].Length / 2];
                        break;
                    }
                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }



    }
}
