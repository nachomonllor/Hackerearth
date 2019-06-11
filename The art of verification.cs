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

            //string url = "http://www.cleartrip.com/signin/service?username=test&pwd=test&profile=developer&role=ELITE&key=manager";
           // string url = "http://www.cleartrip.com/signin/service?username=test&pwd=test&12=3&profile=developer&role=ELITE&key=manager";
            string url = Console.ReadLine(); 

            int i_username = url.IndexOf("username");
            int i_pwd = url.IndexOf("pwd");
            int i_profile = url.IndexOf("profile");
            int i_role = url.IndexOf("role");
            int i_key = url.IndexOf("key");

            Console.WriteLine(url.Substring(i_username, i_pwd - i_username-1).Replace("=",": "));
            //Console.WriteLine(url.Substring(i_pwd, i_profile - i_pwd - 1));
            string pwd = url.Substring(i_pwd, i_profile - i_pwd - 1);
            int igual = pwd.IndexOf("=");
            string a = pwd.Substring(0, igual) + ": ";
            string b = pwd.Substring(igual+1, pwd.Length - igual-1);
            Console.WriteLine(a + b);

            Console.WriteLine(url.Substring(i_profile, i_role - i_profile - 1).Replace("=", ": "));
            Console.WriteLine(url.Substring(i_role, i_key - i_role - 1).Replace("=", ": "));
            Console.WriteLine(url.Substring(i_key, url.Length - i_key).Replace("=", ": "));

            Console.ReadLine();
        }


    }
}


